using Signal_Processing_3.DataSets.Headers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets
{
    public class DataSet
    {
        public DataHeader Header { get; protected set; }
        public double[] Data { get; protected set; }

        public DataSet()
        {
            Header = new DataHeader();
            Data = null;
        }

        public DataSet(DataHeader dataHeader, double[] data)
        {
            Header = (DataHeader)dataHeader.Clone();
            Data = (double[])data.Clone();
        }

        public DataSet(DataSet dataSet)
        {
            Header = (DataHeader)dataSet.Header.Clone();
            Data = (double[])dataSet.Data.Clone();
        }
    }
}
