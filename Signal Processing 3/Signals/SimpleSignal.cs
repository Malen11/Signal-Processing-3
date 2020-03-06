using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.Signals
{
    public class SimpleSignal
    {
        /// <summary>
        /// Тип данных
        /// </summary>
        public DataType Type { get; protected set; }

        /// <summary>
        /// Количество элементов
        /// </summary>
        public long Count { get; protected set; }

        /// <summary>
        /// Частота
        /// </summary>
        public double Hz { get; protected set; }

        public double[] Data { get; protected set; }

        ///// <summary>
        ///// Конструктор
        ///// </summary>
        ///// <param name="filePath"></param>
        //public DataHeader(string filePath)
        //{
        //    throw new NotImplementedException();
        //}

        public SimpleSignal()
        {
            Type = DataType.NotSet;
            Count = 0;
            Hz = 0;
            Data = null;
        }

        public SimpleSignal(DataType type, double[] data, double hz = 360.0)
        {
            Type = type;
            Count = data.LongLength;
            Hz = hz;

            Data = (double[])data.Clone();
        }

        public SimpleSignal(SimpleSignal signal)
        {
            Type = signal.Type;
            Count = signal.Count;
            Hz = signal.Hz;
            Data = (double[])signal.Data.Clone();
        }

        /// <summary>
        /// Создать копию данных
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            SimpleSignal signal = new SimpleSignal(this);

            return signal;
        }
    }
}
