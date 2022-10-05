using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TMI_Project
{
    public partial class ConfigMenu : Form
    {
        private static readonly string FORMAT = ".chim";
        private static readonly int CHECKBOXES = 9;
        private bool[] CheckBoxValues = new bool[CHECKBOXES];
        private static string[] Lines;
        public ConfigMenu()
        {
            ReadConfig();
            InitializeComponent();
            SetConfig();
        }
        private void ReadConfig()
        {
            string[] lines = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "config" + FORMAT);
            Lines = lines;
            if (lines.Length == CHECKBOXES)
            {
                for (int i = 0; i < CHECKBOXES; i++)
                {
                    CheckBoxValues[i] = bool.Parse(lines[i]);
                }
            } else MessageBox.Show("Error al leer el archivo de configuración");
        }
        private void SetConfig()
        {
            if (CheckBoxValues[0]) checkBox1.Checked = true;
            if (CheckBoxValues[1]) checkBox2.Checked = true;
            if (CheckBoxValues[2]) checkBox3.Checked = true;
            if (CheckBoxValues[3]) checkBox4.Checked = true;
            if (CheckBoxValues[4]) checkBox5.Checked = true;
            if (CheckBoxValues[5]) checkBox6.Checked = true;
            if (CheckBoxValues[6]) checkBox7.Checked = true;
            if (CheckBoxValues[7]) checkBox8.Checked = true;
            if (CheckBoxValues[8]) checkBox9.Checked = true;
        }

        private void SetConfig(string[] lines)
        {
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "config" + FORMAT, lines);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[0] = checkBox1.Checked;
            Lines[0] = checkBox1.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[1] = checkBox2.Checked;
            Lines[1] = checkBox2.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[2] = checkBox3.Checked;
            Lines[2] = checkBox3.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[3] = checkBox4.Checked;
            Lines[3] = checkBox4.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[4] = checkBox5.Checked;
            Lines[4] = checkBox5.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[5] = checkBox6.Checked;
            Lines[5] = checkBox6.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[6] = checkBox7.Checked;
            Lines[6] = checkBox7.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[7] = checkBox8.Checked;
            Lines[7] = checkBox8.Checked.ToString();
            SetConfig(Lines);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues[8] = checkBox9.Checked;
            Lines[8] = checkBox9.Checked.ToString();
            SetConfig(Lines);
        }

        private void ConfigMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
