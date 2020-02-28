using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signal_Processing_3.DataSets.Headers;
using Signal_Processing_3.DataSets.Headers.Readers;
using Signal_Processing_3.DataSets.Headers.Writers;

namespace Signal_Processing_3.DataSets.Writers
{
    public class AudioDataSetWriter
    {
        /// <summary>
        /// Записать WAV в файл
        /// </summary>
        /// <param name="filePath">Название файла</param>
        public void WriteDataSet(DataSet dataSet, string filePath)
        {
            if(dataSet.Header.Type != DataType.Audio || (dataSet.Header is WAVDataHeader) == false)
            {
                throw new ArgumentException();
            }

            WAVDataHeader dataHeader = (WAVDataHeader)dataSet.Header;
            double[] data = dataSet.Data;

            WriteDataHeader(dataHeader, filePath);
            WriteData(data, dataHeader.GetHeaderSize(), filePath, dataHeader.BitsPerSample);

            return;
        }

        /// <summary>
        /// Записать заголовок WAV файла
        /// </summary>
        /// <param name="filePath">Название файла</param>
        public static void WriteDataHeader(WAVDataHeader header, String filePath)
        {
            WAVDataHeaderWriter dataSetWriter = new WAVDataHeaderWriter();
            dataSetWriter.WriteHeader(header, filePath);
        }

        /// <summary>
        /// Записать данные WAV файла
        /// </summary>
        /// <param name="data"></param>
        /// <param name="offset"></param>
        /// <param name="filePath">Название файла</param>
        public static void WriteData(double[] data, int offset, String filePath, int bitPerSample = 16)
        {
            if (filePath == null)
            {
                throw new ArgumentNullException("Имя файла с данными не установлено!");
            }

            using (FileStream fs = File.Open(filePath, FileMode.Open))
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
