using System;
using System.Windows.Forms;
using TMI_Project.Grabacion;
using TMI_Project.Analisis;
using System.IO;

namespace TMI_Project
{
    public partial class IntefazGrabacion : Form
    {
        readonly RecordAudio Audio = null;
        private readonly static int MAX_TIMER = 30;
        private readonly string Timer = MAX_TIMER.ToString();

        /// <summary>
        /// Constructor de la clase InterfazGrabacion
        /// </summary>
        public IntefazGrabacion()
        {
            InitializeComponent();
            lblCountdown.Text = Timer;
            btnStop.Enabled = false;
            btnStart.Enabled = false;
            btnGuardar.Enabled = false;
            Audio = new RecordAudio();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblCountdown.Text = Timer;
            Audio.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            btnGuardar.Enabled = false;
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Audio.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            btnGuardar.Enabled = true;
            new AnalizadorFrecuencias(ref pictureBox1, ref nombreEscala, ref comboBox2, ref comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
                btnStart.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo WAVE|*.wav",
                Title = "Guardar audio"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + "temp.wav", saveFileDialog.InitialDirectory + fileName, true);
            }

        }

        private void IntefazGrabacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "temp.wav");
            } catch (Exception)
            {
                // Do nothing.
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblCountdown.Text == "0")
            {
                btnStop.PerformClick();
            }
            else
            {
                lblCountdown.Text = (int.Parse(lblCountdown.Text) - 1).ToString();
            }
        }
    }
}
