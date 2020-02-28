using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets.Headers
{
    /// <summary>
    /// Класс заголовка файла набора данных
    /// </summary>
    public class DataHeader
    {
        /// <summary>
        /// Тип данных
        /// </summary>
        public DataType Type { get; set; }

        /// <summary>
        /// Количество элементов
        /// </summary>
        public long Count { get; set; }

        /// <summary>
        /// Частота
        /// </summary>
        public double Hz { get; set; }

        /// <summary>
        /// Конструктор по-умолчанию
        /// </summary>
        public DataHeader()
        {
            Type = DataType.NotSet;
            Count = 0;
            Hz = 0;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="dataHeader"></param>
        public DataHeader(DataHeader dataHeader)
        {
            Type = dataHeader.Type;
            Count = dataHeader.Count;
            Hz = dataHeader.Hz;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="hz"></param>
        public DataHeader(DataType type, long count, double hz)
        {
            Type = type;
            Count = count;
            Hz = hz;
        }

        ///// <summary>
        ///// Конструктор
        ///// </summary>
        ///// <param name="filePath"></param>
        //public DataHeader(string filePath)
        //{
        //    throw new NotImplementedException();
        //}

        /// <summary>
        /// Создать копию данных
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            DataHeader newDataHeader = new DataHeader(this);

            return newDataHeader;
        }
    }
}
