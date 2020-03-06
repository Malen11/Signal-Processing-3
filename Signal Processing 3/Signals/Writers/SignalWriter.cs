using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals.Writers
{
    public class SignalsWriter
    {
        public void WriteSimpleSignalToFile(SimpleSignal signal, string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            double[] data = DataConverter.ConvertFrom(signal.Data, signal.Type);

            WriteSimpleDataToFile(data, filePath);
        }

        public void WriteSimpleDataToFile(double[] data, string filePath)
        {
            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {
                using (TextWriter tw = new StreamWriter(fs))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        tw.WriteLine(data[i]);
                    }
                }
            }
        }



        public void WriteAudioSignalToFile(AudioSignal signal, string filePath)
        {
            WriteAudioSignalPropertiesToFile(signal.AudioProperties, signal.Count, filePath);
            WriteAudioDataToFile(signal.Data, signal.AudioProperties.CalculateHeaderSize(), filePath, signal.AudioProperties.BitsPerSample);
        }

        public void WriteAudioSignalPropertiesToFile(AudioSignalProperties audioProperties, long count, string filePath)
        {
            using (FileStream fs = File.Open(filePath, FileMode.Create))
            {
                WriteRIFFChunk(audioProperties, fs);
                WriteFmtChunk(audioProperties, fs);
                WriteDataChunk(audioProperties, count, fs);
            }
        }
        
        private void WriteRIFFChunk(AudioSignalProperties audioProperties, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'R', 'I', 'F', 'F' });
            writer.Write(audioProperties.CalculateHeaderSize());
            writer.Write(new char[] { 'W', 'A', 'V', 'E' });

            return;
        }
        
        private void WriteFmtChunk(AudioSignalProperties audioProperties, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'f', 'm', 't', ' ' });

            writer.Write(audioProperties.CalculateSubchunk1Size());
            writer.Write(audioProperties.AudioFormat);
            writer.Write(audioProperties.NumChannels);
            writer.Write(audioProperties.SampleRate);
            writer.Write(audioProperties.GetByteRate());
            writer.Write(audioProperties.GetBlockAlign());
            writer.Write(audioProperties.BitsPerSample);

            if (audioProperties.ExtraParams != null)
            {
                writer.Write((short)audioProperties.ExtraParams.Length);
                writer.Write(audioProperties.ExtraParams);
            }

            return;
        }
        
        private void WriteDataChunk(AudioSignalProperties audioProperties, long count, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'd', 'a', 't', 'a' });
            writer.Write(audioProperties.CalculateSubchunk2Size(count));

            return;
        }
        
        public void WriteAudioDataToFile(double[] data, long offset, String filePath, int bitPerSample = 16)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {
                fs.Position = offset;
                BinaryWriter writer = new BinaryWriter(fs);

                switch (bitPerSample)
                {
                    case 16:

                        for (int i = 0; i < data.Length; i++)
                        {
                            writer.Write((short)data[i]);
                        }
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return;
        }
    }
}
