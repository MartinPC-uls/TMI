using System;
using System.Windows.Forms;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using TMI_Project.Grabacion;
using TMI_Project.Analisis;

namespace TMI_Project
{
    public partial class IntefazGrabacion : Form
    {

        RecordAudio audio = null;
        Audio _audio = null;
        string Instrumento = "";
        public IntefazGrabacion()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            audio = new RecordAudio();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            audio.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            audio.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            new AnalizadorFrecuencias(ref pictureBox1, ref nombreEscala, ref comboBox2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instrumento = comboBox1.Text;
        }
    }
}
