using Signal_Processing_3.DataSets.Headers;
using Signal_Processing_3.DataSets.Headers.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets.Writers
{
    public class SimpleDataSetWriter
    {
        public DataSet WriteDataSet(DataSet dataSet, string filePath)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            switch (type)
            {
                case DataType.Cardio:
                case DataType.Reo:
                case DataType.Spiro:
                case DataType.Velo:
                case DataType.Test:
                    dataSet = GetSimpleDataSetFromFile(filePath);
                    break;

                case DataType.Audio:
                    dataSet = GetAudioDataSetFromFile(filePath);
                    break;

                default:
                    throw new ArgumentException("Необрабатываемое нажатие клавиши");
            }

            return dataSet;
        }

        public DataSet GetSimpleDataSetFromFile(string filePath)
        {
            double[] data = GetDataFromFile(filePath);
            DataHeader dataHeader = new DataHeader(DataType.Test, data.LongLength, 360.0);

            return new DataSet(dataHeader, data);
        }

        public DataSet GetAudioDataSetFromFile(string filePath)
        {
            WAVDataHeaderReader headerReader = new WAVDataHeaderReader();

            WAVDataHeader dataHeader = (WAVDataHeader)headerReader.ReadHeader(filePath);
            double[] data = GetDataFromAudioFile(filePath, dataHeader.GetHeaderSize(), dataHeader.BitsPerSample);

            return new DataSet(dataHeader, data);
        }

        public double[] GetDataFromFile(string filePath)
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

        /// <summary>
        /// Прочитать данные из WAV файла (подправить, так как не учитывает глубину и канальность)
        /// </summary>
        /// <param name="filePath">Название файла</param>
        /// <param name="offset">Отступ заголовка</param>
        /// <returns>Массив данных</returns>
        public static double[] GetDataFromAudioFile(String filePath, int offset, int bitPerSample = 16)
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
    }
}
