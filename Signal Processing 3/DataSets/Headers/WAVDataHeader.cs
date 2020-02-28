using Signal_Processing_3;
using Signal_Processing_3.DataSets.Headers.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets.Headers
{
    /// <summary>
    /// Класс заголовка WAV файла
    /// </summary>
    public class WAVDataHeader : DataHeader
    {
        //public int ChunkSize { get; private set; }

        //public int Subchunk2Size { get; private set; }
        //public int ByteRate { get; private set; }
        //public short BlockAlign { get; private set; }

        public short AudioFormat { get; private set; }
        public short NumChannels { get; private set; }
        public int SampleRate { get; private set; }
        public short BitsPerSample { get; private set; }
        public byte[] ExtraParams { get; private set; }

        ///// <summary>
        ///// Конструктор
        ///// </summary>
        ///// <param name="filePath">filestream файла</param>
        //public WAVDataHeader(string filePath)
        //{
        //    using (FileStream fs = File.Open(filePath, FileMode.Open))
        //    {
        //        var riffChunck = WAVDataHeaderReader.ReadRIFFChunk(fs);

        //        //ChunkSize = riffChunck.chunkSize;

        //        var fmtChunk = WAVDataHeaderReader.ReadFmtChunk(fs);

        //        AudioFormat = fmtChunk.audioFormat;
        //        NumChannels = fmtChunk.numChannels;
        //        SampleRate = fmtChunk.sampleRate;
        //        //ByteRate = fmtChunk.byteRate;
        //        //BlockAlign = fmtChunk.blockAlign;
        //        BitsPerSample = fmtChunk.bitsPerSample;
        //        ExtraParams = fmtChunk.extraParams;

        //        var dataChank = WAVDataHeaderReader.ReadDataChunk(fs);

        //        //Subchunk2Size = dataChank.subchunk2Size;

        //        base.Count = dataChank.subchunk2Size / (NumChannels * BitsPerSample / 8);
        //        base.Hz = SampleRate;
        //        base.Type = DataType.Audio;
        //    }
        //}

        /// <summary>
        /// Конструктор
        /// </summary>
        public WAVDataHeader()
        {
            AudioFormat = 0;
            NumChannels = 0;
            SampleRate = 0;
            BitsPerSample = 0;
            ExtraParams = null;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="dataHeader"></param>
        public WAVDataHeader(WAVDataHeader dataHeader)
        {
            AudioFormat = dataHeader.AudioFormat;
            NumChannels = dataHeader.NumChannels;
            SampleRate = dataHeader.SampleRate;
            BitsPerSample = dataHeader.BitsPerSample;
            ExtraParams = (byte[])ExtraParams.Clone();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="audioFormat"></param>
        /// <param name="numChannels"></param>
        /// <param name="sampleRate"></param>
        /// <param name="bitsPerSample"></param>
        /// <param name="extraParams"></param>
        /// <param name="count"></param>
        public WAVDataHeader(short audioFormat, short numChannels, int sampleRate, short bitsPerSample, byte[] extraParams, long count)
        {
            AudioFormat = audioFormat;
            NumChannels = numChannels;
            SampleRate = sampleRate;
            BitsPerSample = bitsPerSample;

            base.Count = count;
            base.Hz = SampleRate;
            base.Type = DataType.Audio;
        }

        /// <summary>
        /// Получить размер заголовка
        /// </summary>
        /// <returns>Размер заголовка</returns>
        public int GetHeaderSize()
        {
            return 4 + (8 + GetSubchunk1Size()) + (8 + GetSubchunk2Size());
        }

        /// <summary>
        /// Получить размер подзаголовка 1
        /// </summary>
        /// <returns>Размер подзаголовка 1</returns>
        public int GetSubchunk1Size()
        {
            if(ExtraParams != null)
            {
                return 16 + ExtraParams.Length;
            }
            else
            {
                return 16;
            }
        }

        /// <summary>
        /// Получить размер подзаголовка 2
        /// </summary>
        /// <returns>Размер подзаголовка 2</returns>
        public int GetSubchunk2Size()
        {
            return (int)(Count * NumChannels * BitsPerSample / 8);
        }

        /// <summary>
        /// Получить ByteRate
        /// </summary>
        /// <returns></returns>
        public int GetByteRate()
        {
            return SampleRate * NumChannels * BitsPerSample / 8;
        }

        /// <summary>
        /// Получить BlockAlign
        /// </summary>
        /// <returns></returns>
        public int GetBlockAlign()
        {
            return NumChannels * BitsPerSample / 8;
        }

        public override object Clone()
        {
            return new WAVDataHeader(AudioFormat, NumChannels, SampleRate, BitsPerSample, ExtraParams, Count);
        }
    }
}
