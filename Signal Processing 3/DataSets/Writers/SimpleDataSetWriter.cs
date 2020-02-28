using Signal_Processing_3.DataSets.Headers;
using Signal_Processing_3.DataSets.Headers.Readers;
using Signal_Processing_3.DataSets.Headers.Writers;
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

            switch (dataSet.Header.Type)
            {
                case DataType.Cardio:
                case DataType.Reo:
                case DataType.Spiro:
                case DataType.Velo:
                case DataType.Test:
                    WriteDataHeader(dataSet.Header, filePath);
                    WriteData(dataSet.Data, filePath);
                    break;

                default:
                    throw new ArgumentException("Необрабатываемый тип данных");
            }

            return dataSet;
        }

        public void WriteDataHeader(DataHeader header, string filePath)
        {
            SimpleDataHeaderWriter dataHeaderWriter = new SimpleDataHeaderWriter();
            dataHeaderWriter.WriteHeader(header, filePath);
        }

        public void WriteData(double[] data, string filePath, int offset = 0)
        {
            using (FileStream fs = File.Open(filePath, FileMode.OpenOrCreate))
            {
                fs.Position = offset;
                using (TextWriter tw = new StreamWriter(fs))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        tw.WriteLine(data[i]);
                    }
                }
            }
        }
    }
}
