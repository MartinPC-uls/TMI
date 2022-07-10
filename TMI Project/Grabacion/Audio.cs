using System;
using System.IO;
using System.Numerics;

namespace TMI_Project.Grabacion
{
    public class Audio
    {
        public int NumChannels { get; set; }
        public int SampleRate { get; set; }
        public int ByteRate { get; set; }
        public int BlockAlign { get; set; }
        public int BitsPerSample { get; set; }
        public int SubChunk2Size { get; set; }
        public byte[] Data { get; set; }
        public float[] RealData { get; set; }
        public string NombreArchivoTemporal { get; set; }

        public Audio(string nombreArchivoTemporal)
        {
            this.NombreArchivoTemporal = nombreArchivoTemporal;
            ObtenerElementosAudio();
        }

        private void ObtenerElementosAudio()
        {
            Data = File.ReadAllBytes(NombreArchivoTemporal);
            NumChannels = BitConverter.ToInt16(Data, 22);
            SampleRate = BitConverter.ToInt32(Data, 24);
            ByteRate = BitConverter.ToInt32(Data, 28);
            BlockAlign = BitConverter.ToInt16(Data, 32);
            BitsPerSample = BitConverter.ToInt16(Data, 34);
            SubChunk2Size = BitConverter.ToInt32(Data, 36);
            RealData = new float[(Data.Length - 44) / BlockAlign];
            for (int i = 44, j = 0; i < Data.Length; i += BlockAlign, j++)
            {
                if (BlockAlign == 2)
                {
                    RealData[j] = BitConverter.ToInt16(Data, i) / 32768f;
                }
                else if (BlockAlign == 4)
                {
                    RealData[j] = BitConverter.ToInt32(Data, i) / 32768f;
                }
                else if (BitsPerSample == 8)
                {
                    RealData[j] = BitConverter.ToInt64(Data, i) / 32768f;
                }
            }
        }
    }
}
