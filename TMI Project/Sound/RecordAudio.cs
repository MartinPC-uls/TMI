using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Sound
{
    public class RecordAudio
    {

        public readonly string DefaultName = "pruebita.wav";

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

        public void start()
        {
            mciSendString("open new Type waveaudio Alias recsound", null, 0, 0);
            mciSendString("set recsound time format ms bitspersample 16 channels 2 samplespersec 44100 bytespersec" +
                " 192000 alignment 4", null, 0, 0);
            mciSendString("record recsound", null, 0, 0);
        }
        public void stop()
        {
            string filePath = "\"" + AppDomain.CurrentDomain.BaseDirectory + DefaultName + "\"";
            mciSendString("save recsound " + filePath, null, 0, 0);
            mciSendString("close recsound", null, 0, 0);
        }

    }
}
