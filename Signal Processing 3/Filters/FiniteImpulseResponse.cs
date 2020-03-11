using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Filters
{
    public enum FirFilterType
    {
        LowPass = 1,
        HighPass = 2,
        BandPass = 3,
        NotchPass = 4
    }

    public enum FirWindowType
    {
        Rectangle = 0,
        Hamming = 1,
        Bartlett = 2,
        Hanning = 3,
        Blackman = 4
    }

    public static class ImpulseCharacteristicTypeExtensionMethods
    {
        public static string ToFriendlyString(this FirFilterType type)
        {
            switch (type)
            {
                case FirFilterType.LowPass:
                    return "Низкочастотный фильтр";

                case FirFilterType.HighPass:
                    return "Высокочастотный фильтр";

                default:
                    throw new Exception();
                    break;
            }
        }
    }

    public static class FiniteImpulseResponse
    {
        public static double[] BaseImpulseCharacteristic(double threshold, double hz, int n)
        {
            double[] h = new double[n];
            double fc = threshold / (hz);

            double twoPiFc = 2 * Math.PI * fc;
            double m = (n - 1.0);
            double mDiv2 = m / 2.0;

            for (int i = 0; i < n; i++)
            {
                if (i != m / 2.0)
                {
                    h[i] = Math.Sin(twoPiFc * (i - mDiv2)) / (Math.PI * (i - mDiv2));
                }
                else
                {
                    h[i] = 2 * fc;
                }
            }

            return h;
        }

        public static double[] ImpulseCharacteristic(double hz, int n, double threshold, FirFilterType impulseCharacteristicType = FirFilterType.LowPass, FirWindowType windowType = FirWindowType.Rectangle)
        {
            double[] h;
            double[] w = WindowCoef(windowType, n);
            double fc = threshold / (hz);

            switch (impulseCharacteristicType)
            {
                case FirFilterType.LowPass:
                    h = BaseImpulseCharacteristic(threshold, hz, n);
                    break;

                case FirFilterType.HighPass:
                    h = BaseImpulseCharacteristic(threshold, hz, n).Select(x => (-x)).ToArray();
                    h[n / 2] = 1 - 2 * fc;
                    break;

                default:
                    throw new Exception();
            }

            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = h[i] * w[i];
            }
            return result;
        }

        public static double[] ImpulseCharacteristic(double hz, int n, double threshold0, double threshold1, FirFilterType impulseCharacteristicType = FirFilterType.LowPass, FirWindowType windowType = FirWindowType.Rectangle)
        {
            double[] h0, h1, h;
            double[] w = WindowCoef(windowType, n);
            double fc0 = threshold0 / (hz );
            double fc1 = threshold1 / (hz );

            switch (impulseCharacteristicType)
            {
                case FirFilterType.BandPass:
                    h = new double[n];
                    h0 = BaseImpulseCharacteristic(threshold0, hz, n);
                    h1 = BaseImpulseCharacteristic(threshold1, hz, n);

                    for (int i = 0; i < n; i++)
                    {
                        h[i] = h1[i] - h0[i];
                        h[n / 2] = 2 * (fc1 - fc0);
                    }
                    break;

                case FirFilterType.NotchPass:
                    h = new double[n];
                    h0 = BaseImpulseCharacteristic(threshold0, hz, n);
                    h1 = BaseImpulseCharacteristic(threshold1, hz, n);

                    for (int i = 0; i < n; i++)
                    {
                        h[i] = h0[i] - h1[i];
                        h[n / 2] = 1 - 2 * (fc1 - fc0);
                    }
                    break;

                default:
                    throw new Exception();
            }

            double[] result = new double[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = h[i] * w[i];
            }
            return result;
        }

        public static double[] BaseFirFilter(double[] data, double[] h)
        {
            double[] result = new double[data.Length];
            int n = h.Length, k = data.Length;

            for (int j = 0; j < n; j++)
            {
                result[j] = data[j];
            }

            for (int i = n; i < k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i] += data[i - j] * h[j];
                }
            }

            return result;
        }

        public static double[] FirFilter(double[] data, double hz, int n, double threshold, FirFilterType type = FirFilterType.LowPass, FirWindowType windowType = FirWindowType.Rectangle)
        {
            double[] h = ImpulseCharacteristic(hz, n, threshold, type, windowType);

            return BaseFirFilter(data, h);
        }

        public static double[] FirFilter(double[] data, double hz, int n, double threshold0, double threshold1, FirFilterType type = FirFilterType.LowPass, FirWindowType windowType = FirWindowType.Rectangle)
        {
            double[] h = ImpulseCharacteristic(hz, n, threshold0, threshold1, type, windowType);

            return BaseFirFilter(data, h);
        }

        public static double[] FrequencyResponse(double[] h, double hz)
        {
            return AmplitudeSpectrum(FourierTransform(h, (int)hz));
        }

        public static double[] PhaseResponse(double[] h, double hz)
        {
            return PhaseSpectrum(FourierTransform(h, (int)hz));
        }

        public static (double Re, double Im)[] FourierTransform(double[] h, int hz)
        {
            int n = h.Length;
            (double Re, double Im)[] result = new(double Ak, double Bk)[hz];

            double TwoPiDivHz = 2.0 * Math.PI / hz;

            for (int k = 0; k < hz; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    result[k].Re += h[i] * Math.Cos(TwoPiDivHz * k * i);
                    result[k].Im += h[i] * Math.Sin(TwoPiDivHz * k * i);
                }
            }

            return result;
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

        public static double[] PhaseSpectrum((double Ak, double Bk)[] coefficient)
        {
            double[] result = new double[coefficient.Length];

            for (int i = 0; i < coefficient.Length; i++)
            {
                result[i] = Math.Atan(coefficient[i].Bk / coefficient[i].Ak);
            }

            return result;
        }

        public static double[] WindowCoef(FirWindowType windowType, int n)
        {
            double[] w = new double[n];
            int m = (n - 1);
            double twoPi = Math.PI * 2;
            double fourPi = Math.PI * 4;

            switch (windowType)
            {
                case FirWindowType.Rectangle:
                    for (int i = 0; i < n; i++)
                    {
                        w[i] = 1;
                    }
                    break;

                case FirWindowType.Hamming:
                    for (int i = 0; i < n; i++)
                    {
                        w[i] = 0.54 - 0.46 * Math.Cos(twoPi * i / m);
                    }
                    break;

                case FirWindowType.Bartlett:
                    for (int i = 0; i < n; i++)
                    {
                        w[i] = 1 - 2 * Math.Abs(i - m / 2) / m;
                    }
                    break;

                case FirWindowType.Hanning:
                    for (int i = 0; i < n; i++)
                    {
                        w[i] = 0.5 - 0.5 * Math.Cos(twoPi * i / m);
                    }
                    break;

                case FirWindowType.Blackman:
                    for (int i = 0; i < n; i++)
                    {
                        w[i] = 0.42 - 0.5 * Math.Cos(twoPi * i / m) + 0.08 * Math.Cos(fourPi * i / m);
                    }
                    break;

                default:
                    throw new Exception();
            }

            return w;
        }
    }
}
