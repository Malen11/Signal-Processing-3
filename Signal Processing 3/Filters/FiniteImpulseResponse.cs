using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Filters
{
    public static class FiniteImpulseResponse
    {
        public static double[] ImpulseCharacteristic(double threshold, double hz, int n)
        {
            double[] h = new double[n];
            double fc = threshold / (hz / 2);

            double twoPiFc = Math.PI * 2 * fc;
            double m = (n - 1.0);
            double mDiv2 = m / 2.0;

            for (int i = 0; i < n; i++)
            {
                if (i != m / 2.0)
                {
                    h[i] = Math.Sin(twoPiFc * (i - mDiv2)) / (Math.PI * (i - mDiv2));
                }
                else {
                    h[i] = 2 * fc;
                }
            }

            return h;
        }

        public static double[] lPFirFilter(double[] data, double threshold, double hz, int n)
        {
            double[] result = new double[data.Length];

            double[] h= ImpulseCharacteristic(threshold, hz, n);

            for (int j = 0; j < n; j++)
            {
                result[j] = data[j];
            }

            for (int i = n; i < data.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i] += data[i - j] * h[j];
                }
            }

            return result;
        }

        public static double[] hPFirFilter(double[] data, double threshold, double hz, int n)
        {
            double[] result = new double[data.Length];

            double[] h = ImpulseCharacteristic(threshold, hz, n);

            for (int j = 0; j < n; j++)
            {
                result[j] = data[j];
            }

            for (int i = n; i < data.Length; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i] += data[i - j] * h[j];
                }
            }

            return result;
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
    }
}
