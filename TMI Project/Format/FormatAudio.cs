using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace TMI_Project.Format
{
    public static class FormatAudio
    {
        private static readonly object ThisLock = new object();

        public static void CompressFile(string fileToCompress, string newFile = null)
        {
            var bytes = File.ReadAllBytes(fileToCompress);
            if (newFile == null)
            {
                newFile = fileToCompress;
                File.Delete(fileToCompress);
            }
            using (FileStream fs = new FileStream(newFile, FileMode.CreateNew))
            using (GZipStream zipStream = new GZipStream(fs, CompressionMode.Compress, false))
            {
                zipStream.Write(bytes, 0, bytes.Length);
            }
        }

        public static void DecompressFile(string fileToDecompress, string newFile = null)
        {
            if (newFile == null)
                newFile = Path.GetFileNameWithoutExtension(fileToDecompress);
            
            using (Stream fd = File.Create(newFile + ".dhim"))
            using (Stream fs = File.OpenRead(fileToDecompress))
            using (Stream csStream = new GZipStream(fs, CompressionMode.Decompress))
            {
                byte[] buffer = new byte[1024];
                int nRead;
                while ((nRead = csStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fd.Write(buffer, 0, nRead);
                }
            }
            if (newFile == null)
            {
                File.Delete(fileToDecompress);
                Path.ChangeExtension(newFile, ".him");
            }
        }
        public static void ConvertFormat(string pathFileToSave, params AudioTrack[] audioTracks)
        {
            File.Create(pathFileToSave).Close();
            int n = 1;
            foreach (var audioTrack in audioTracks)
            {
                Write(pathFileToSave, audioTrack);
                n++;
            }
            CompressFile(pathFileToSave);
        }
        private static void Write(string destiny, AudioTrack audioTrack)
        {
            string INIT_EOF = "-----\n";
            lock (ThisLock)
            {
                byte[] bytes = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"Project\" + audioTrack.Name + ".wav");
                byte[] _bytes = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"Project\_" + audioTrack.Name + ".wav");
                File.AppendAllText(destiny, INIT_EOF);
                File.AppendAllText(destiny, audioTrack.Name + "\n");
                File.AppendAllText(destiny, audioTrack.Volume.ToString() + "\n");
                File.AppendAllText(destiny, audioTrack.IsMuted.ToString() + "\n");
                File.AppendAllText(destiny, Convert.ToBase64String(bytes));
                File.AppendAllText(destiny, "\n");
                File.AppendAllText(destiny, INIT_EOF);
                
                File.AppendAllText(destiny, INIT_EOF);
                File.AppendAllText(destiny, "_" + audioTrack.Name + "\n");
                File.AppendAllText(destiny, audioTrack.Volume.ToString() + "\n");
                File.AppendAllText(destiny, audioTrack.IsMuted.ToString() + "\n");
                File.AppendAllText(destiny, Convert.ToBase64String(_bytes));
                File.AppendAllText(destiny, "\n");
                File.AppendAllText(destiny, INIT_EOF);
            }
        }
        private static void Write(string file, string text)
        {
            using (StreamWriter w = File.AppendText(file))
            {
                w.WriteLine(text);
            }
        }
        private static void Write(string file, byte[] bytes)
        {
            using (var stream = new FileStream(file, FileMode.Append))
            {
                stream.Write(bytes, 0, bytes.Length);
            }
        }
        private static void Write(string file, byte b)
        {
            using (var stream = new FileStream(file, FileMode.Append))
            {
                stream.WriteByte(b);
            }
        }
        private static void WriteBytes(string file, byte[] bytes)
        {
            byte[] test = File.ReadAllBytes(file);
            using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
            {
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                reader.ReadBytes(bytes.Length);
            }
        }
        /*public static void ExtractAudioTracks(string file)
        {
            string[] lines = File.ReadAllLines(file);
            int i = 1;
            foreach (var line in lines)
            {
                File.Create(AppDomain.CurrentDomain.BaseDirectory + "/Project/audioTrack" + i + ".wav").Close();
                Write(AppDomain.CurrentDomain.BaseDirectory + "/Project/audioTrack" + i + ".wav", Convert.FromBase64String(line));
                i++;
            }
        }*/
        public static List<AudioTrack> ExtractAudioTracks(string file)
        {
            string[] lines = File.ReadAllLines(file);
            List<AudioTrack> audioTracks = new List<AudioTrack>();
            string name = "";
            int volume = 0;
            bool isMuted = false;
            int currentLine = 0;
            foreach (var line in lines)
            {
                if (line == "-----")
                {
                    continue;
                }
                else
                {
                    currentLine++;
                    switch (currentLine)
                    {
                        case 1:
                            name = line;
                            break;
                        case 2:
                            volume = int.Parse(line);
                            break;
                        case 3:
                            isMuted = bool.Parse(line);
                            break;
                        case 4:
                            byte[] bytes = Convert.FromBase64String(line);
                            audioTracks.Add(new AudioTrack(null, name, volume, isMuted));
                            Write(AppDomain.CurrentDomain.BaseDirectory + "/Project/" + name + ".wav", Convert.FromBase64String(line));
                            currentLine = 0;
                            break;
                    }
                }
            }
            return audioTracks;
        }
        private static void ReadHIMFile(string file)
        {
            
        }
        /*private static void ReadAudioTrack(string file)
        {
            bool readingAudioTrack = false;
            string content = "";
            int n = 0;
            using (var reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (readingAudioTrack)
                    {
                        File.Create(AppDomain.CurrentDomain.BaseDirectory + "audioTrack" + n + ".wav").Close();
                        if (!Regex.IsMatch(line, "^--------\"([1-9])+\"--------$") && !Regex.IsMatch(line, "^\n$"))
                        {
                            Write("audioTrack" + n + ".wav", line);
                        } else
                        {
                            readingAudioTrack = false;
                            content = "";
                            break;
                        }
                    }
                    if (Regex.IsMatch(line, "^--------\"([1-9])+\"--------$"))
                    {
                        Console.WriteLine("Pista encontrada!");
                        readingAudioTrack = true;
                        n++;
                    }
                }
            }
        }*/
    }
}
