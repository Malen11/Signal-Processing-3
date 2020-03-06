using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Filters
{
    public static class FourierTransform
    {
        public static (double Re, double Im)[] BaseFourierTransform((double Re, double Im)[] exponentData, bool direct = true)
        {
            int N = exponentData.Length;
            (double Re, double Im)[] result = new(double Ak, double Bk)[N];

            if (direct)
            {
                for (int k = 0; k < N; k++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        result[k].Re += 1.0 / N * exponentData[i].Re * Math.Cos(2.0 * Math.PI * k * i / N);
                        result[k].Im += 1.0 / N * exponentData[i].Re * Math.Sin(2.0 * Math.PI * k * i / N);
                    }
                }
            }
            else
            {
                for (int k = 0; k < N; k++)
                {
                    for (int i = 0; i < N; i++)
                    {
                        result[k].Re += exponentData[i].Re * Math.Cos(2.0 * Math.PI * k * i / N) + exponentData[i].Im * Math.Sin(2.0 * Math.PI * k * i / N);
                    }
                }
            }


            return result;
        }

        //public static double[] FourierTransformReverse((double Ak, double Bk)[] coefficient, FilterType type = FilterType.FourierBase)
        //{
        //    int N = coefficient.Length;

        //    double[] result = new double[coefficient.Length];

        //    for (int k = 0; k < N; k++)
        //    {
        //        for (int i = 0; i < N; i++)
        //        {
        //            result[k] += coefficient[i].Ak * Math.Cos(2.0 * Math.PI * k * i / N) + coefficient[i].Bk * Math.Sin(2.0 * Math.PI * k * i / N);
        //        }
        //    }

        //    return result;
        //}

        public static (double Re, double Im)[] FastFourierTransform((double Re, double Im)[] exponentData, bool direct = true)
        {
            int N = exponentData.Count();

            double powerD = Math.Log(N, 2.0);
            int power = (int)Math.Round(powerD);

            if (Math.Abs(powerD - power) > 0.0000001)
            {
                throw new ArgumentException("Массив data должен быть размером, кратным 2!");
            }

            //(double Re, double Im)[] exponentData = data.Select(x => (x, 0.0)).ToArray();
            (double Re, double Im)[] resultData = reverseArray(exponentData);

            for (int len = 2; len <= N; len <<= 1)
            {
                double angle = 2 * Math.PI / len * (direct ? -1 : 1);
                (double Re, double Im) wlen = (Math.Cos(angle), Math.Sin(angle));

                for (int i = 0; i < N; i += len)
                {
                    (double Re, double Im) w = (1, 0);

                    for (int j = 0; j < len / 2; ++j)
                    {
                        (double Re, double Im) u = resultData[i + j];
                        (double Re, double Im) v = complexMult(resultData[i + j + len / 2], w);

                        resultData[i + j] = complexSum(u, v);
                        resultData[i + j + len / 2] = complexSum(u, (-v.Re, -v.Im));
                        w = complexMult(w, wlen);
                    }
                }
            }

            if (direct)
            {
                for (int i = 0; i < resultData.Length; i++)
                {
                    resultData[i] = (resultData[i].Re / N, resultData[i].Im / N);
                }
            }

            return resultData;
        }

        public static (double Re, double Im)[] SpeedFourierTransform((double Re, double Im)[] exponentData, bool direct = true)
        {
            int N = exponentData.Count();

            int power, M, err, L;

            power = 0;
            M = 0;
            err = N - (int)Math.Pow(2, power) * M;

            for (int selectedPower = 0, selectedM = 0, selectedErr = 0; Math.Pow(2, selectedPower) < N / 2; selectedPower++)
            {
                selectedM = N / (int)Math.Pow(2, selectedPower);
                selectedErr = N - (int)Math.Pow(2, selectedPower) * selectedM;
                if (Math.Abs(selectedErr) <= Math.Abs(err) && selectedM < Math.Pow(2, selectedPower))
                {
                    power = selectedPower;
                    M = selectedM;
                    err = selectedErr;
                }
            }

            if (Math.Abs(N - (Math.Pow(2, power) * M)) > 0.1)
            {
                throw new ArgumentException("Массив data должен быть размером, кратным 2K*L!");
            }

            L = (int)Math.Pow(2, power);

            (double Re, double Im)[] halfWayData = new(double Re, double Im)[N];
            for (int m = 0; m < M; m++)
            {
                var temp = FastFourierTransform(exponentData.Where((x, y) => y % M == m).ToArray(), direct);

                for (int i = 0; i < temp.Length; i++)
                {
                    halfWayData[i * M + m] = temp[i];
                }
            }

            var k = -1;
            if (direct)
            {
                k = 1;
            }

            (double Re, double Im)[] resultData = new(double Re, double Im)[N];
            for (int s = 0; s < M; s++)
            {
                for (int r = 0; r < L; r++)
                {
                    resultData[r + s * L] = (0, 0);
                    for (int m = 0; m < M; m++)
                    {
                        var coef = k*2 * Math.PI * m * (r + s * L) / N;
                        resultData[r + s * L] = complexSum(resultData[r + s * L], complexMult(halfWayData[m + r * M], (Math.Cos(coef), -Math.Sin(coef))));
                        //resultData[r + s * L] = complexSum(resultData[r + s * L], complexMult(halfWayData[m + r * M], (Math.Cos(2 * Math.PI * m * (r + s * L) / N), -Math.Sin(2 * Math.PI * m * (r + s * L) / N))));
                    }
                }
            }

            if (direct)
            {
                return resultData.Select(item => (item.Re / M, item.Im / M)).ToArray();
            }
            else {
                return resultData;
            }
        }

        public static (double Re, double Im)[] FourierTransformDirect(double[] data, FilterType type = FilterType.FourierBase)
        {
            (double Re, double Im)[] exponentData = data.Select(x => (x, 0.0)).ToArray();

            switch (type)
            {
                case FilterType.FourierBase:
                    return BaseFourierTransform(exponentData, true);
                    break;

                case FilterType.FourierFast:
                    return FastFourierTransform(exponentData, true);
                    break;

                case FilterType.FourierSpeed:
                    return SpeedFourierTransform(exponentData, true);
                    break;

                default:
                    throw new ArgumentException("Недействительный тип преобразования");
            }
        }

        public static double[] FourierTransformReverse((double Ak, double Bk)[] coefficient, FilterType type = FilterType.FourierBase)
        {
            switch (type)
            {
                case FilterType.FourierBase:
                    return BaseFourierTransform(coefficient, false).Select(x => x.Re).ToArray();
                    break;

                case FilterType.FourierFast:
                    return FastFourierTransform(coefficient, false).Select(x => x.Re).ToArray();
                    break;

                case FilterType.FourierSpeed:
                    return SpeedFourierTransform(coefficient, false).Select(x => x.Re).ToArray();
                    break;

                default:
                    throw new ArgumentException("Недействительный тип преобразования");
            }
        }

        public static double[] AmplitudeSpectrum((double Ak, double Bk)[] coefficient)
        {
            double[] result = new double[coefficient.Length];

            for (int i = 0; i < coefficient.Length; i++)
            {
                result[i] = Math.Sqrt(coefficient[i].Ak * coefficient[i].Ak + coefficient[i].Bk * coefficient[i].Bk);
            }

            return result;
        }

        public static double[] AmplitudeSpectrum(double[] data, FilterType type)
        {
            (double Re, double Im)[] coef = FourierTransformDirect(data, type).Select(x => (2 * x.Re, 2 * x.Im)).ToArray();
            return AmplitudeSpectrum(coef);
        }

        public static double[] PhaseSpectrum((double Ak, double Bk)[] coefficient)
        {
            double[] result = new double[coefficient.Length];

            for (int i = 0; i < coefficient.Length; i++)
            {
                result[i] = Math.Atan(coefficient[i].Bk / coefficient[i].Ak);
            }

            return result;
        }

        public static double[] PhaseSpectrum(double[] data, FilterType type)
        {
            (double Re, double Im)[] coef = FourierTransformDirect(data, type);
            return PhaseSpectrum(coef);
        }

        public static (double Ak, double Bk)[] LPFilter((double Ak, double Bk)[] coefficient, int end)
        {
            int N = coefficient.Length;

            (double Ak, double Bk)[] result = new(double Ak, double Bk)[N];

            int notRemoved = Math.Max(Math.Min(end, N / 2), 0);

            for (int k = 0; k < notRemoved; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            for (int k = N - notRemoved; k < N; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            return result;
        }

        public static double[] LPFilter(double[] data, int end, FilterType type = FilterType.FourierBase)
        {
            (double Ak, double Bk)[] oldCoef = FourierTransformDirect(data, type);

            (double Ak, double Bk)[] newCoef = LPFilter(oldCoef, end);

            return FourierTransformReverse(newCoef, type);//FourierTransformReverse(newCoef);
        }

        public static (double Ak, double Bk)[] HPFilter((double Ak, double Bk)[] coefficient, int start)
        {
            int N = coefficient.Length;

            (double Ak, double Bk)[] result = new(double Ak, double Bk)[N];

            int notRemoved = Math.Max(Math.Min(start, N / 2), 0);

            for (int k = notRemoved; k < N - notRemoved; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            return result;
        }

        public static double[] HPFilter(double[] data, int start, FilterType type = FilterType.FourierBase)
        {
            (double Ak, double Bk)[] oldCoef = FourierTransformDirect(data, type);

            (double Ak, double Bk)[] newCoef = HPFilter(oldCoef, start);

            return FourierTransformReverse(newCoef, type);
        }

        public static (double Ak, double Bk)[] BPFilter((double Ak, double Bk)[] coefficient, int start, int end)
        {
            int N = coefficient.Length;

            (double Ak, double Bk)[] result = new(double Ak, double Bk)[N];

            for (int k = start; k < end; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            for (int k = N - end; k < N - start; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            return result;
        }

        public static double[] BPFilter(double[] data, int start, int end, FilterType type = FilterType.FourierBase)
        {
            (double Ak, double Bk)[] oldCoef = FourierTransformDirect(data, type);

            (double Ak, double Bk)[] newCoef = BPFilter(oldCoef, start, end);

            return FourierTransformReverse(newCoef, type);
        }

        public static (double Ak, double Bk)[] NotchFilter((double Ak, double Bk)[] coefficient, int pos0, int pos1)
        {
            int N = coefficient.Length;

            (double Ak, double Bk)[] result = new(double Ak, double Bk)[N];

            for (int k = 0; k < pos0; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            for (int k = pos1; k < N - pos1; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            for (int k = N - pos0; k < N; k++)
            {
                result[k].Ak = coefficient[k].Ak;
                result[k].Bk = coefficient[k].Bk;
            }

            return result;
        }

        public static double[] NotchFilter(double[] data, int pos0, int pos1, FilterType type = FilterType.FourierBase)
        {
            (double Ak, double Bk)[] oldCoef = FourierTransformDirect(data, type);

            (double Ak, double Bk)[] newCoef = NotchFilter(oldCoef,  pos0,  pos1);

            return FourierTransformReverse(newCoef, type);
        }

        public static int reverseBite(int data, int power)
        {
            int rest = data;
            int reverseData = 0;

            //перевдим биты в зеркальную позицию
            for (int i = power - 1; i >= 0; i--)
            {
                reverseData += (rest % 2) * (int)Math.Pow(2, i);
                rest /= 2;
            }

            return reverseData;
        }

        public static (double Re, double Im)[] reverseArray((double Re, double Im)[] data)
        {
            int size = data.Count();
            (double Re, double Im)[] reverseData = new(double Re, double Im)[size];

            double powerD = Math.Log(size, 2.0);
            int power = (int)Math.Round(powerD);

            if (Math.Abs(powerD - power) > 0.0000001)
            {
                throw new ArgumentException("Массив data должен быть размером, кратным 2!");
            }

            for (int i = 0; i < size; i++)
            {
                reverseData[reverseBite(i, power)] = data[i];
            }

            return reverseData;
        }

        public static (double Re, double Im) complexSum((double Re, double Im) arg0, (double Re, double Im) arg1)
        {
            return (arg0.Re + arg1.Re, arg0.Im + arg1.Im);
        }

        public static (double Re, double Im) complexMult((double Re, double Im) arg0, (double Re, double Im) arg1)
        {
            return (arg0.Re * arg1.Re - arg0.Im * arg1.Im, arg0.Re * arg1.Im + arg0.Im * arg1.Re);
        }
    }
}