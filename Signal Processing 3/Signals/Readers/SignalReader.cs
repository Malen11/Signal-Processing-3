using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals.Readers
{
    public class SignalReader
    {
        public SimpleSignal ReadSimpleSignalFromFile(string filePath, DataType type, double hz = 360.0)
        {
            SimpleSignal signal;

            double[] data = ReadSimpleDataFromFile(filePath);
            double[] convertedData = DataConverter.ConvertTo(data, type);

            signal = new SimpleSignal(type, data, hz);

            return signal;
        }

        public double[] ReadSimpleDataFromFile(string filePath)
        {
            List<double> data = new List<double>();

            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            using (FileStream fs = File.Open(filePath, FileMode.Open))
            using (TextReader tr = new StreamReader(fs))
            {
                while (tr.Peek() != -1)
                {
                    string line = tr.ReadLine();
                    string[] strValues = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string strValue in strValues)
                    {
                        data.Add(Double.Parse(strValue));
                    }
                }
            }

            return data.ToArray();
        }



        public AudioSignal ReadAudioSignalFromFile(string filePath)
        {
            AudioSignal signal;

            AudioSignalProperties audioProperties = ReadAudioSignalProperties(filePath);
            double[] data = ReadAudioDataFromFile(filePath, audioProperties.CalculateHeaderSize(), audioProperties.BitsPerSample);

            signal = new AudioSignal(audioProperties, data);

            return signal;
        }

        public double[] ReadAudioDataFromFile(string filePath, long offset, int bitPerSample = 16)
        {
            double[] data;

            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            using (FileStream fs = File.Open(filePath, FileMode.Open))
            {
                long dataLength = fs.Length - offset;
                fs.Position = offset;

                BinaryReader reader = new BinaryReader(fs);

                switch (bitPerSample)
                {
                    case 16:

                        data = new double[dataLength / 2];
                        for (long i = offset; i < dataLength / 2; ++i)
                        {
                            data[i] = (double)reader.ReadInt16();
                        }
                        break;

                    default:
                        throw new NotImplementedException();
                }
            }

            return data;
        }

        /// <summary>
        /// Чтение заголовка набора банных из файла
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public AudioSignalProperties ReadAudioSignalProperties(string filePath)
        {
            AudioSignalProperties audioProperties;

            using (FileStream fs = File.Open(filePath, FileMode.Open))
            {
                var riffChunck = ReadRIFFChunk(fs);
                var fmtChunk = ReadFmtChunk(fs);
                var dataChank = ReadDataChunk(fs);

                audioProperties = new AudioSignalProperties(
                    fmtChunk.audioFormat,
                    fmtChunk.numChannels,
                    fmtChunk.sampleRate,
                    fmtChunk.bitsPerSample,
                    fmtChunk.extraParams
                );
            }

            return audioProperties;
        }

        /// <summary>
        /// Чтение RIFF заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        /// <returns>RIFF заголовок</returns>
        public static (char[] chunkID, int chunkSize, char[] format) ReadRIFFChunk(FileStream fs)
        {
            BinaryReader reader = new BinaryReader(fs);

            char[] chunkID = reader.ReadChars(4);
            int chunkSize = reader.ReadInt32();
            char[] format = reader.ReadChars(4);

            if (new string(chunkID) != "RIFF" || new string(format) != "WAVE")
            {
                throw new FormatException("Wrong file format");
            }

            var riffChunck = (chunkID, chunkSize, format);

            return riffChunck;
        }

        /// <summary>
        /// Чтение fmt заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        /// <returns>fmt заголовок</returns>
        public static (char[] subchunk1ID, int subchunk1Size, short audioFormat, short numChannels, int sampleRate, int byteRate, short blockAlign, short bitsPerSample, byte[] extraParams)
            ReadFmtChunk(FileStream fs)
        {
            BinaryReader reader = new BinaryReader(fs);

            char[] subchunk1ID = reader.ReadChars(4);

            if (new string(subchunk1ID) != "fmt ")
            {
                throw new FormatException("Wrong file format");
            }

            int subchunk1Size = reader.ReadInt32();
            short audioFormat = reader.ReadInt16();
            short numChannels = reader.ReadInt16();
            int sampleRate = reader.ReadInt32();
            int byteRate = reader.ReadInt32();
            short blockAlign = reader.ReadInt16();
            short bitsPerSample = reader.ReadInt16();

            short extraParamSize = 0;
            byte[] extraParams = null;
            if (subchunk1Size > 16)
            {
                extraParamSize = reader.ReadInt16();
                extraParams = reader.ReadBytes(extraParamSize);
            }

            var fmtChunk = (subchunk1ID, subchunk1Size, audioFormat, numChannels, sampleRate, byteRate, blockAlign, bitsPerSample, extraParams);

            return fmtChunk;
        }

        /// <summary>
        /// Чтение data заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        /// <returns>data заголовок</returns>
        public static (char[] subchunk2ID, int subchunk2Size) ReadDataChunk(FileStream fs)
        {
            BinaryReader reader = new BinaryReader(fs);

            char[] subchunk2ID = reader.ReadChars(4);

            if (new string(subchunk2ID) != "data")
            {
                throw new FormatException("Wrong file format");
            }

            int subchunk2Size = reader.ReadInt32();

            var dataChunk = (subchunk2ID, subchunk2Size);

            return dataChunk;
        }
    }
}