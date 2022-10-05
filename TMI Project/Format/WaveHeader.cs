using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Format
{
    public class WaveHeader
    {
        public byte[] ChunkID { get; set; }
        public byte[] ChunkSize { get; set; }
        public byte[] Format { get; set; }

        public byte[] Subchunk1ID { get; set; }
        public byte[] Subchunk1Size { get; set; }
        public byte[] AudioFormat { get; set; }
        public byte[] NumChannels { get; set; }
        public byte[] SampleRate { get; set; }
        public byte[] ByteRate { get; set; }
        public byte[] BlockAlign { get; set; }
        public byte[] BitsPerSample { get; set; }
        
        public byte[] Subchunk2ID { get; set; }
        public byte[] Subchunk2Size { get; set; }
        
        public byte[] WAVEHEADER { get; set; }
        public WaveHeader()
        {
            ChunkID = new byte[4];
            ChunkSize = new byte[4];
            Format = new byte[4];

            Subchunk1ID = new byte[4];
            Subchunk1Size = new byte[4];
            AudioFormat = new byte[2];
            NumChannels = new byte[2];
            SampleRate = new byte[4];
            ByteRate = new byte[4];
            BlockAlign = new byte[2];
            BitsPerSample = new byte[2];

            Subchunk2ID = new byte[4];
            Subchunk2Size = new byte[4];
        }
        public void Concat()
        {
            List<byte> aux = new List<byte>();
            aux.AddRange(ChunkID);
            aux.AddRange(ChunkSize);
            aux.AddRange(Format);
            aux.AddRange(Subchunk1ID);
            aux.AddRange(Subchunk1Size);
            aux.AddRange(AudioFormat);
            aux.AddRange(NumChannels);
            aux.AddRange(SampleRate);
            aux.AddRange(ByteRate);
            aux.AddRange(BlockAlign);
            aux.AddRange(BitsPerSample);
            aux.AddRange(Subchunk2ID);
            aux.AddRange(Subchunk2Size);
            WAVEHEADER = aux.ToArray();
        }
    }
}
