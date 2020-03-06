using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals
{
    public static class SignalUtils
    {
        public static SimpleSignal ResizeSignal(SimpleSignal signal, int newSize)
        {
            SimpleSignal resizedSignal;

            double[] resizedData = GetResizedData(signal.Data, newSize);
            resizedSignal = new SimpleSignal(signal.Type, resizedData, signal.Hz);

            return resizedSignal;
        }

        public static AudioSignal ResizeSignal(AudioSignal signal, int newSize)
        {
            AudioSignal resizedSignal;

            double[] resizedData = GetResizedData(signal.Data, newSize);
            resizedSignal = new AudioSignal(signal.AudioProperties, resizedData);

            return resizedSignal;
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
