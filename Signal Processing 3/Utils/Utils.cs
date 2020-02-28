using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3
{
    public static class Utils
    {
        public static T[] ResizeData<T>(T[] data, int newSize)
        {
            int oldSize = data.Count();

            T[] resizedData = new T[newSize];

            for (int i = 0; i < newSize; i++)
            {
                if (i < oldSize)
                {
                    resizedData[i] = data[i];
                }
            }

            return resizedData;
        }
    }

    public static class DataReader
    {
    }

    public static class DataConverter
    {
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

        public static double[] ConvertToAudio(double[] data)
        {
            int size = data.Count();

            return data;
        }
    }
}
