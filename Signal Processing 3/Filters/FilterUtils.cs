using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Filters
{
    public static class FiltersUtils
    {
        public static double[] PrepareDataToFilter(double[] data, FilterType type)
        {
            double[] preparedData;

            switch (type)
            {
                case FilterType.FourierFast:
                    preparedData = GetResizedData(data, NearestPowerOf2(data.Length));
                    break;

                case FilterType.FourierSpeed:
                    preparedData = GetResizedData(data, NearestPowerOf2MultipliedM(data.Length));
                    break;

                default:
                    preparedData = data;
                    break;
            }

            return preparedData;
        }

        public static int NearestPowerOf2(int value)
        {
            double powerD = Math.Log(value, 2);
            int power = (int)Math.Round(powerD);
            int nearestPowerOf2 = (int)Math.Pow(2, power);

            return nearestPowerOf2;
        }

        public static int NearestPowerOf2MultipliedM(int value)
        {
            int N = value;

            double powerD = Math.Log(N, 2.0);

            int power, M, err;

            power = 1;
            M = 1;
            err = (int)(N - Math.Pow(2, power) * M);

            for (int selectedPower = 1, selectedM = 1, selectedErr = 0; Math.Pow(2, selectedPower) < N / 2; selectedPower++)
            {
                selectedM = (int)Math.Round((double)N / Math.Pow(2, selectedPower));
                selectedErr = (int)(N - Math.Pow(2, selectedPower) * selectedM);
                if (Math.Abs(selectedErr) <= Math.Abs(err) && selectedM < Math.Pow(2, selectedPower))
                {
                    M = selectedM;
                    power = selectedPower;
                    err = selectedErr;
                }
            }

            return (int)(Math.Pow(2, power) * M);
        }

        public static double[] GetResizedData(double[] data, int newSize)
        {
            int oldSize = data.Count();

            double[] resizedData = new double[newSize];

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
}
