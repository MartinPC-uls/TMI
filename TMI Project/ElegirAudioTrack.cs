using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMI_Project.Format;

namespace TMI_Project
{
    public partial class ElegirAudioTrack : Form
    {
        private readonly List<AudioTrack> AudioTracks;
        public string AudioTrackSelected;
        public string InstrumentoSelected;
        public string[] AfinacionSelected;
        public ElegirAudioTrack(List<AudioTrack> audioTracks, string audioTrackSelected, string instrumentoSelected, string[] afinacionSelected)
        {
            AudioTrackSelected = audioTrackSelected;
            InstrumentoSelected = instrumentoSelected;
            AfinacionSelected = afinacionSelected;
            InitializeComponent();
            AudioTracks = audioTracks;
            AddAudioTracks();
        }
        private void AddAudioTracks()
        {
            foreach (var audioTrack in AudioTracks)
            {
                audioTrackCB.Items.Add(audioTrack.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string audioTrackSelected = audioTrackCB.GetItemText(audioTrackCB.SelectedItem);
            string instrumentoSelected = diagramaInstrumentoCB.GetItemText(diagramaInstrumentoCB.SelectedItem);

            int afinacionSelected = afinacionCB.SelectedIndex + 1;

            /* 
                0. E A D G B E
                1. D# G# C# F# A# D#
                2. D G C F A D 
                3. C# F# B E G# C#
                4. C F A# D# G C
                5. E A D G B E
             */
            if (txtAfinacion.Text != "" && txtAfinacion.Text != null)
            {
                string[] afinacion = txtAfinacion.Text.Split(' ');
                if (afinacion.Length == 6)
                {
                    AfinacionSelected = afinacion;
                }
                else
                {
                    MessageBox.Show("La afinación debe tener 6 notas separadas por un espacio.");
                    return;
                }
            }
            else
            {
                switch (afinacionSelected)
                {
                    case 0:
                        AfinacionSelected = new string[] { "E", "A", "D", "G", "B", "E" };
                        break;
                    case 1:
                        AfinacionSelected = new string[] { "D#", "G#", "C#", "F#", "A#", "D#" };
                        break;
                    case 2:
                        AfinacionSelected = new string[] { "D", "G", "C", "F", "A", "D" };
                        break;
                    case 3:
                        AfinacionSelected = new string[] { "C#", "F#", "B", "E", "G#", "C#" };
                        break;
                    case 4:
                        AfinacionSelected = new string[] { "C", "F", "A#", "D#", "G", "C" };
                        break;
                    case 5:
                        AfinacionSelected = new string[] { "E", "A", "D", "G", "B", "E" };
                        break;
                }
            }
            
            foreach (var audioTrack in AudioTracks)
            {
                if (audioTrackSelected.Equals(audioTrack.Name))
                {
                    DialogResult = DialogResult.OK;
                    AudioTrackSelected = audioTrack.Name;
                    InstrumentoSelected = instrumentoSelected;
                    //AfinacionSelected = afinacionSelected;
                    Close();
                    return;
                }
            }
        }
    }
}
