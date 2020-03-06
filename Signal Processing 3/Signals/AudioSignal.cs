using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals
{
    public class AudioSignalProperties
    {
        public short AudioFormat { get; private set; }
        public short NumChannels { get; private set; }
        public int SampleRate { get; private set; }
        public short BitsPerSample { get; private set; }
        public byte[] ExtraParams { get; private set; }

        public AudioSignalProperties()
        {
            AudioFormat = 0;
            NumChannels = 0;
            SampleRate = 0;
            BitsPerSample = 0;
            ExtraParams = null;
        }

        public AudioSignalProperties(short audioFormat, short numChannels, int sampleRate, short bitsPerSample, byte[] extraParams)
        {
            AudioFormat = audioFormat;
            NumChannels = numChannels;
            SampleRate = sampleRate;
            BitsPerSample = bitsPerSample;

            if (extraParams != null)
            {
                ExtraParams = (byte[])extraParams.Clone();
            }
            else
            {
                ExtraParams = null;
            }
        }

        public AudioSignalProperties(AudioSignalProperties audioProperties)
        {
            AudioFormat = audioProperties.AudioFormat;
            NumChannels = audioProperties.NumChannels;
            SampleRate = audioProperties.SampleRate;
            BitsPerSample = audioProperties.BitsPerSample;

            if (audioProperties.ExtraParams != null)
            {
                ExtraParams = (byte[])audioProperties.ExtraParams.Clone();
            }
            else
            {
                ExtraParams = null;
            }
        }

        /// <summary>
        /// Получить ByteRate
        /// </summary>
        /// <returns></returns>
        public int GetByteRate()
        {
            return SampleRate * NumChannels * BitsPerSample / 8;
        }

        /// <summary>
        /// Получить BlockAlign
        /// </summary>
        /// <returns></returns>
        public short GetBlockAlign()
        {
            return (short)(NumChannels * BitsPerSample / 8);
        }

        /// <summary>
        /// Получить размер заголовка
        /// </summary>
        /// <returns>Размер заголовка</returns>
        public int CalculateHeaderSize()
        {
            return 8 + 4 + (8 + CalculateSubchunk1Size()) + (8 + CalculateSubchunk2Size(0));
        }

        /// <summary>
        /// Получить размер подзаголовка 1
        /// </summary>
        /// <returns>Размер подзаголовка 1</returns>
        public int CalculateSubchunk1Size()
        {
            if (ExtraParams != null)
            {
                return 16 + ExtraParams.Length;
            }
            else
            {
                return 16;
            }
        }

        /// <summary>
        /// Получить размер подзаголовка 2
        /// </summary>
        /// <returns>Размер подзаголовка 2</returns>
        public int CalculateSubchunk2Size(long count)
        {
            return (int)(count * NumChannels * BitsPerSample / 8);
        }

        public object Clone()
        {
            return new AudioSignalProperties(this);
        }

        //public bool Equals(AudioSignalProperties audioProperties)
        //{
        //    if(audioProperties.AudioFormat != AudioFormat)
        //    {
        //        return false;
        //    }
        //    if(audioProperties.NumChannels != NumChannels)
        //    {
        //        return false;
        //    }
        //    if (audioProperties.SampleRate != SampleRate)
        //    {
        //        return false;
        //    }
        //    if (audioProperties.BitsPerSample != BitsPerSample)
        //    {
        //        return false;
        //    }
        //    if (!audioProperties.ExtraParams.Equals(ExtraParams))
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }

    public class AudioSignal : SimpleSignal
    {
        public AudioSignalProperties AudioProperties;

        public AudioSignal():base()
        {
            AudioProperties = new AudioSignalProperties();
        }

        public AudioSignal(AudioSignalProperties audioProperties, double[] data)
            : base(DataType.Audio, data, audioProperties.SampleRate)
        {
            AudioProperties = (AudioSignalProperties)audioProperties.Clone();
        }

        public AudioSignal(AudioSignal signal) : base(signal)
        {
            AudioProperties = (AudioSignalProperties)signal.AudioProperties.Clone();
        }

        /// <summary>
        /// Создать копию данных
        /// </summary>
        /// <returns></returns>
        public override object Clone()
        {
            AudioSignal dataSet = new AudioSignal(this);

            return dataSet;
        }
    }
}
