using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals
{
    public static class DataConverter
    {
        public static double[] ConvertTo(double[] data, DataType type)
        {
            double[] convertedData = new double[data.Length];

            switch (type)
            {
                case DataType.Cardio:
                    convertedData = ConvertToCardio(data);
                    break;
                case DataType.Reo:
                    convertedData = ConvertToReo(data);
                    break;
                case DataType.Velo:
                    convertedData = ConvertToVelo(data);
                    break;
                case DataType.Spiro:
                    convertedData = ConvertToSpiro(data);
                    break;
                default:
                    convertedData = (double[])data.Clone();
                    break;
            }

            return convertedData;
        }

        public static double[] ConvertToCardio(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (data[i] - 127) / 60;
            }

            return result;
        }

        public static double[] ConvertToReo(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (0.1 * data[i] / 100.0);
            }

            return result;
        }

        public static double[] ConvertToVelo(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (data[i] - 512.0) / 240.0;
            }

            return result;
        }

        public static double[] ConvertToSpiro(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (data[i] - 512.0) / 100.0;
            }

            return result;
        }

        public static double[] ConvertFrom(double[] data, DataType type)
        {
            double[] convertedData = new double[data.Length];

            switch (type)
            {
                case DataType.Cardio:
                    convertedData = ConvertFromCardio(data);
                    break;
                case DataType.Reo:
                    convertedData = ConvertFromReo(data);
                    break;
                case DataType.Velo:
                    convertedData = ConvertFromVelo(data);
                    break;
                case DataType.Spiro:
                    convertedData = ConvertFromSpiro(data);
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }

            return convertedData;
        }

        public static double[] ConvertFromCardio(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = data[i]  * 60 + 127;
            }

            return result;
        }

        public static double[] ConvertFromReo(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = (data[i] * 100.0 / 0.1);
            }

            return result;
        }

        public static double[] ConvertFromVelo(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = data[i] * 240.0 + 512.0;
            }

            return result;
        }

        public static double[] ConvertFromSpiro(double[] data)
        {
            int size = data.Count();
            double[] result = new double[size];

            for (int i = 0; i < size; i++)
            {
                result[i] = data[i] * 100.0 + 512.0;
            }

            return result;
        }
    }
}
