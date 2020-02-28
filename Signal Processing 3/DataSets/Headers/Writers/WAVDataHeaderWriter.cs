using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signal_Processing_3.DataSets.Headers.Writers
{
    public class WAVDataHeaderWriter
    {
        /// <summary>
        /// Записывает заголовок WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        public void WriteHeader(WAVDataHeader header, string filePath)
        {
            using (FileStream fs = File.Open(filePath, FileMode.Create))
            {
                WriteRIFFChunk(header, fs);
                WriteFmtChunk(header, fs);
                WriteDataChunk(header, fs);
            }
        }

        /// <summary>
        /// Запись RIFF заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        private void WriteRIFFChunk(WAVDataHeader header, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'R', 'I', 'F', 'F' });
            writer.Write(header.GetHeaderSize());
            writer.Write(new char[] { 'W', 'A', 'V', 'E' });

            return;
        }

        /// <summary>
        /// Запись fmt заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        private void WriteFmtChunk(WAVDataHeader header, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'f', 'm', 't', ' ' });

            short extraParamSize = 0;
            if (header.ExtraParams != null)
            {
                extraParamSize = (short)header.ExtraParams.Length;
            }

            writer.Write(header.GetSubchunk1Size());
            writer.Write(header.AudioFormat);
            writer.Write(header.NumChannels);
            writer.Write(header.SampleRate);
            writer.Write(header.GetByteRate());
            writer.Write(header.GetBlockAlign());
            writer.Write(header.BitsPerSample);

            if (header.ExtraParams != null)
            {
                writer.Write(extraParamSize);
                writer.Write(header.ExtraParams);
            }

            return;
        }

        /// <summary>
        /// Запись data заголовка WAV файла
        /// </summary>
        /// <param name="fs">filestream файла</param>
        private void WriteDataChunk(WAVDataHeader header, FileStream fs)
        {
            BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(new char[] { 'd', 'a', 't', 'a' });
            writer.Write(header.GetSubchunk2Size());

            return;
        }
    }
}
