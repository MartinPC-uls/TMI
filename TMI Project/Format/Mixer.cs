using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Format
{
    public class Mixer
    {
        public WaveHeader waveHeader;
        public string Target;
        public string Output;
        public List<byte[]> Datas;
        public Mixer(string target, string output)
        {
            Target = target;
            Output = output;
            Datas = new List<byte[]>();
            waveHeader = new WaveHeader();
            waveHeader = GetWaveHeader();
            waveHeader.Concat();
        }
        private WaveHeader GetWaveHeader()
        {
            byte[] bytes = File.ReadAllBytes(Target);
            waveHeader.ChunkID = bytes.Take(4).ToArray();
            waveHeader.ChunkSize = bytes.Skip(4).Take(4).ToArray();
            waveHeader.Format = bytes.Skip(8).Take(4).ToArray();
            waveHeader.Subchunk1ID = bytes.Skip(12).Take(4).ToArray();
            waveHeader.Subchunk1Size = bytes.Skip(16).Take(4).ToArray();
            waveHeader.AudioFormat = bytes.Skip(20).Take(2).ToArray();
            waveHeader.NumChannels = bytes.Skip(22).Take(2).ToArray();
            waveHeader.SampleRate = bytes.Skip(24).Take(4).ToArray();
            waveHeader.ByteRate = bytes.Skip(28).Take(4).ToArray();
            waveHeader.BlockAlign = bytes.Skip(32).Take(2).ToArray();
            waveHeader.BitsPerSample = bytes.Skip(34).Take(2).ToArray();
            waveHeader.Subchunk2ID = bytes.Skip(36).Take(4).ToArray();
            waveHeader.Subchunk2Size = bytes.Skip(40).Take(4).ToArray();
            return waveHeader;
        }
        private void BuildWaveHeader()
        {
            File.Create(Output).Close();
            File.WriteAllBytes(Output, waveHeader.WAVEHEADER);
        }
        public void Mix(params string[] files)
        {
            BuildWaveHeader();
            foreach (var file in files)
            {
                FileStream fs = new FileStream(@file, FileMode.Open, FileAccess.Read);
                byte[] arrfile = new byte[fs.Length - 44];
                fs.Position = 44;
                fs.Read(arrfile, 0, arrfile.Length);
                fs.Close();

                FileStream fo = new FileStream(@Output, FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fo);
                bw.Write(arrfile);
                bw.Close();
                fo.Close();
            }
        }
        public void Merge(params string[] files)
        {
            WaveIO wa_IN = new WaveIO();
            WaveIO wa_out = new WaveIO();

            wa_out.DataLength = 0;
            wa_out.length = 0;


            //Gather header data
            foreach (string path in files)
            {
                wa_IN.WaveHeaderIN(@path);
                wa_out.DataLength += wa_IN.DataLength;
                wa_out.length += wa_IN.length;

            }

            //Reconstruct new header
            wa_out.BitsPerSample = wa_IN.BitsPerSample;
            wa_out.channels = wa_IN.channels;
            wa_out.samplerate = wa_IN.samplerate;
            wa_out.WaveHeaderOUT(@Output);

            byte[] mainData;
            byte[] aux;

            foreach (string path in files)
            {
                FileStream fs = new FileStream(@path, FileMode.Open, FileAccess.Read);
                byte[] arrfile = new byte[fs.Length - 44];
                fs.Position = 44;
                fs.Read(arrfile, 0, arrfile.Length);
                /*aux = arrfile;
                mainData = arrfile;
                for (int i = 0; i < aux.Length; i += BitConverter.ToInt16(waveHeader.BlockAlign, 0))
                {
                    mainData[i] += BitConverter.ToInt16(aux[i + BitConverter.ToInt16(waveHeader.BlockAlign, 0)], 0);
                    mainData[i] /= 2;
                }
                fs.Close();*/

                
            }
            /*FileStream fo = new FileStream(Output, FileMode.Append, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fo);
            bw.Write(arrfile);
            bw.Close();
            fo.Close();*/
        }

    }
}
