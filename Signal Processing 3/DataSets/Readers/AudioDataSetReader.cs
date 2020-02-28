using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signal_Processing_3.DataSets.Headers;
using Signal_Processing_3.DataSets.Headers.Readers;

namespace Signal_Processing_3.DataSets.Readers
{
    public class AudioDataSetReader
    {
        public DataSet GetDataSet(string filePath)
        {
            WAVDataHeader dataHeader = GetDataHeader(filePath);
            double[] data = GetData(filePath, dataHeader.GetHeaderSize(), dataHeader.BitsPerSample);

            return new DataSet(dataHeader, data);
        }

        public WAVDataHeader GetDataHeader(string filePath)
        {
            WAVDataHeaderReader headerReader = new WAVDataHeaderReader();

            WAVDataHeader dataHeader = (WAVDataHeader)headerReader.ReadHeader(filePath);

            return dataHeader;
        }

        public double[] GetData(string filePath, int offset, int bitPerSample = 16)
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
