using Signal_Processing_3.DataSets.Headers;
using Signal_Processing_3.DataSets.Headers.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets.Readers
{
    public class SimpleDataSetReader
    {
        public DataSet GetDataSet(string filePath, DataType type)
        {
            double[] data = GetData(filePath);
            DataHeader dataHeader = new DataHeader(type, data.LongLength, 360.0);

            return new DataSet(dataHeader, data);
        }

        public DataHeader GetDataHeader(string filePath, DataType type)
        {
            SimpleDataHeaderReader headerReader = new SimpleDataHeaderReader();
            return headerReader.ReadHeader(filePath);
        }

        public double[] GetData(string filePath)
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
    }
}