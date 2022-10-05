using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Grabacion
{
    public class RecordAudio
    {

        public readonly static string DefaultName = "temp.wav";

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        /// <summary>
        /// Inicia una grabación de audio
        /// </summary>
        public static void Start()
        {
            mciSendString("open new Type waveaudio Alias recsound", null, 0, 0);
            /*mciSendString("set recsound time format ms bitspersample 16 channels 2 samplespersec 44100 bytespersec" +
                " 192000 alignment 4", null, 0, 0);*/
            mciSendString("set recsound time format ms bitspersample 16 channels 2 samplespersec 44100 bytespersec" +
                " 192000 alignment 4", null, 0, 0);
            mciSendString("record recsound", null, 0, 0);
        }
        public static void Start(int sampleRate, string alias)
        {
            mciSendString("open new Type waveaudio Alias " + alias, null, 0, 0);
            /*mciSendString("set recsound time format ms bitspersample 16 channels 2 samplespersec 44100 bytespersec" +
                " 192000 alignment 4", null, 0, 0);*/
            mciSendString("set " + alias + " time format ms bitspersample 16 channels 2 samplespersec " + sampleRate + " bytespersec" +
                " 192000 alignment 4", null, 0, 0);
            mciSendString("record " + alias, null, 0, 0);
        }
        [DllImport("winmm.dll")]
        public static extern int waveInGetNumDevs();
        /// <summary>
        /// Detiene la grabación de audio
        /// </summary>
        public static void Stop()
        {
            string filePath = "\"" + AppDomain.CurrentDomain.BaseDirectory + DefaultName + "\"";
            mciSendString("save recsound " + filePath, null, 0, 0);
            mciSendString("close recsound", null, 0, 0);
        }
        public static void Stop(string filePath)
        {
            filePath = "\"" + filePath + "\"";
            mciSendString("save recsound " + filePath, null, 0, 0);
            mciSendString("close recsound", null, 0, 0);
        }
        public static void Stop(string filePath, string alias)
        {
            filePath = "\"" + filePath + "\"";
            mciSendString("save " + alias + " " + filePath, null, 0, 0);
            mciSendString("close " + alias, null, 0, 0);
        }

    }
}
