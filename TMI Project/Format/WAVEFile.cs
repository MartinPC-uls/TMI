using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Format
{
    public class WAVEFile
    {
        public string ChunkID { get; set; }
        public int ChunkSize { get; set; }
        public string Format { get; set; }
        public string Subchunk1ID { get; set; }
        public int Subchunk1Size { get; set; }
        public int AudioFormat { get; set; }
        public int NumChannels { get; set; }
        public int SampleRate { get; set; }
        public int ByteRate { get; set; }
        public int BlockAlign { get; set; }
        public int BitsPerSample { get; set; }
        public string Subchunk2ID { get; set; }
        public int Subchunk2Size { get; set; }
        public byte[] Data { get; set; }
        public byte[] RealData { get; set; }
        
        public WAVEFile(string filePath)
        {
            GetWAVEFile(filePath);
        }

        private void GetWAVEFile(string filePath)
        {
            Data = File.ReadAllBytes(filePath);
            
            ChunkID = BitConverter.ToString(Data, 0, 4);
            ChunkSize = BitConverter.ToInt32(Data, 4);
            Format = BitConverter.ToString(Data, 8, 4);
            Subchunk1ID = BitConverter.ToString(Data, 12, 4);
            Subchunk1Size = BitConverter.ToInt32(Data, 16);
            AudioFormat = BitConverter.ToInt16(Data, 20);
            NumChannels = BitConverter.ToInt16(Data, 22);
            SampleRate = BitConverter.ToInt32(Data, 24);
            ByteRate = BitConverter.ToInt32(Data, 28);
            BlockAlign = BitConverter.ToInt16(Data, 32);
            BitsPerSample = BitConverter.ToInt16(Data, 34);
            Subchunk2ID = BitConverter.ToString(Data, 36, 4);
            Subchunk2Size = BitConverter.ToInt32(Data, 36);
            RealData = Data.Skip(44).ToArray();
        }
    }
}
