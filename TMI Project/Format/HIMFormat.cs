using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMI_Project.Format
{
    internal class HIMFormat
    {
        public AudioTrack[] AudioTracks { get; set; }
        public int BPM { get; set; }
        public bool Metronome { get; set; }
        public string JamSession { get; set; }
        public string MusicalScale { get; set; }
        public HIMFormat(AudioTrack[] audioTracks, int bpm, bool metronome, string jamSession, string musicalScale)
        {
            AudioTracks = audioTracks;
            BPM = bpm;
            Metronome = metronome;
            JamSession = jamSession;
            MusicalScale = musicalScale;
        }
    }
}
