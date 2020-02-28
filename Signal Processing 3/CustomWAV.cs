//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Signal_Processing_3
//{
//    public class CustomWAV
//    {
//        public WAVHeader header { get; private set; }
//        public int[] data { get; private set; }

//        /// <summary>
//        /// Конструктор
//        /// </summary>
//        /// <param name="filePath">Название файла</param>
//        public CustomWAV(string filePath)
//        {
//            header = ReadWAVHeader(filePath);
//            data = ReadWAVData(filePath, header.GetHeaderSize());
//        }

//        /// <summary>
//        /// Записать WAV в файл
//        /// </summary>
//        /// <param name="filePath">Название файла</param>
//        public void WriteWAV(string filePath)
//        {
//            WriteWAVHeader(header, filePath);
//            WriteWAVData(data, header.GetHeaderSize(), filePath);

//            return;
//        }

//        /// <summary>
//        /// Записать заголовок WAV файла
//        /// </summary>
//        /// <param name="filePath">Название файла</param>
//        public static void WriteWAVHeader(WAVHeader  header, String filePath)
//        {
//            header.WriteWAVHeader(filePath);

//            return;
//        }

//        /// <summary>
//        /// Записать данные WAV файла
//        /// </summary>
//        /// <param name="data"></param>
//        /// <param name="offset"></param>
//        /// <param name="filePath">Название файла</param>
//        public static void WriteWAVData(int[] data, int offset, String filePath, int bitPerSample = 16)
//        {
//            if (filePath == null)
//            {
//                throw new ArgumentNullException("Имя файла с данными не установлено!");
//            }

//            using (FileStream fs = File.Open(filePath, FileMode.Open))
//            {
//                fs.Position = offset;
//                BinaryWriter writer = new BinaryWriter(fs);

//                switch (bitPerSample)
//                {
//                    case 16:

//                        for (int i = 0; i < data.Length; i++)
//                        {
//                            writer.Write((short)data[i]);
//                        }
//                        break;

//                    default:
//                        throw new NotImplementedException();
//                }
//            }

//            return;
//        }

//        /// <summary>
//        /// Прочитать заголовок WAV файла
//        /// </summary>
//        /// <param name="filePath">Название файла</param>
//        /// <returns>Заголовок WAV файла</returns>
//        public static WAVHeader ReadWAVHeader(String filePath)
//        {
//            return new WAVHeader(filePath, DataType.Audio);
//        }

//        /// <summary>
//        /// Прочитать данные из WAV файла (подправить, так как не учитывает глубину и канальность)
//        /// </summary>
//        /// <param name="filePath">Название файла</param>
//        /// <param name="offset">Отступ заголовка</param>
//        /// <returns>Массив данных</returns>
//        public static int[] ReadWAVData(String filePath, int offset, int bitPerSample = 16)
//        {
//            int[] data;

//            if (filePath == null)
//            {
//                throw new ArgumentNullException("Имя файла с данными не установлено!");
//            }

//            using (FileStream fs = File.Open(filePath, FileMode.Open))
//            {
//                long dataLength = fs.Length - offset;
//                fs.Position = offset;

//                BinaryReader reader = new BinaryReader(fs);

//                switch (bitPerSample)
//                {
//                    case 16:

//                        data = new int[dataLength / 2];
//                        for (long i = offset; i < dataLength / 2; ++i)
//                        {
//                            data[i] = reader.ReadInt16();
//                        }
//                        break;

//                    default:
//                        throw new NotImplementedException();
//                }
//            }

//            return data;
//        }

//        public static DataSet GetDataFromAudioFile(string filePath)
//        {
//            DataSet fileData;

//            CustomWAV customWAV = new CustomWAV(filePath);
//            fileData.Header = customWAV.header;
//            fileData.Data = customWAV.data.Select(x => (double)x).ToArray();

//            return fileData;
//        }
//    }
//}
