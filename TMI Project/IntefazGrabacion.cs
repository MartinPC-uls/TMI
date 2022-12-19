using System;
using System.Windows.Forms;
using TMI_Project.Grabacion;
using TMI_Project.Analisis;
using System.IO;
using TMI_Project.Format;
using MaterialSkin.Controls;
using System.Reflection;
using System.Media;
using WMPLib;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.InteropServices;
//using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi;
using AudioSwitcher.AudioApi.CoreAudio;
using System.Diagnostics;

namespace TMI_Project
{
    public partial class IntefazGrabacion : MaterialForm
    {
        private readonly static int MAX_TIMER = 30;
        private readonly string Timer = MAX_TIMER.ToString();
        private static bool RecordingAudioTrack;
        private static bool Looping;
        private readonly List<WindowsMediaPlayer> Players = new List<WindowsMediaPlayer>();
        private readonly List<WindowsMediaPlayer> _Players = new List<WindowsMediaPlayer>();
        private readonly List<string> AudioTracks = new List<string>();
        private List<AudioTrack> _AudioTracks = new List<AudioTrack>();
        private List<AudioTrack> __AudioTracks = new List<AudioTrack>();
        private static bool RequiresSaving = false;
        private static bool IsExternalProject = false;
        private static string FileNameOpened = "";
        private List<GroupBox> _groupBoxes;
        private CoreAudioController _coreAudioController;
        private CoreAudioDevice _coreAudioDevice;

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        [DllImport("winmm.dll")]
        public static extern int waveInMessage(IntPtr hWaveIn, int uMessage, IntPtr dwParam1, IntPtr dwParam2);

        /// <summary>
        /// Constructor de la clase InterfazGrabacion
        /// </summary>
        public IntefazGrabacion()
        {
            _coreAudioController = new CoreAudioController();
            _groupBoxes = new List<GroupBox>();

            string folderPath = AppDomain.CurrentDomain.BaseDirectory + "Project";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                FileAttributes attributes = File.GetAttributes(folderPath);
                if (!((attributes & FileAttributes.Hidden) == FileAttributes.Hidden))
                {
                    File.SetAttributes(folderPath, attributes | FileAttributes.Hidden);
                }
            }
            InitializeComponent();

            RecordingAudioTrack = false;
            Looping = false;

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;

            textBox1.Visible = false;
            groupBox1.Visible = false;

            listAllRecordingDevices();
        }

        private void CreateAudioTrackBox(AudioTrack audioTrack, bool autoRecord = false, bool autoPlay = false)
        {

            //bool isMuted = audioTrack.IsMuted;
            //audioTrack.

            //GroupBox groupBox = groupBox1;
            GroupBox groupBox = new GroupBox();
            // 
            // groupBox
            // 
            groupBox.Location = new System.Drawing.Point(3, 3);
            groupBox.Name = audioTrack.Name;
            groupBox.Size = new System.Drawing.Size(932, 100);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = audioTrack.Name;

            var player = new WindowsMediaPlayer
            {
                URL = AppDomain.CurrentDomain.BaseDirectory + "/Project/" + audioTrack.Name + ".wav"
            };
            player.controls.stop();
            _Players.Add(player);

            // Initialize sub-components
            TextBox textBox = new TextBox();
            MaterialButton materialButton = new MaterialButton();
            MaterialButton materialButton1a = new MaterialButton();
            MaterialButton btnReproducir = new MaterialButton();
            MaterialSlider volumea = new MaterialSlider();
            MaterialSwitch materialSwitch = new MaterialSwitch();


            // 
            // materialButton3
            // 
            btnReproducir.AutoSize = false;
            btnReproducir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnReproducir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnReproducir.Depth = 0;
            btnReproducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnReproducir.HighEmphasis = true;
            btnReproducir.Icon = null;
            btnReproducir.Location = new System.Drawing.Point(162, 55);
            btnReproducir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnReproducir.MouseState = MaterialSkin.MouseState.HOVER;
            btnReproducir.Name = "materialButton3";
            btnReproducir.NoAccentTextColor = System.Drawing.Color.Empty;
            btnReproducir.Size = new System.Drawing.Size(100, 36);
            btnReproducir.TabIndex = 11;
            btnReproducir.Text = "Reproducir";
            btnReproducir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnReproducir.UseAccentColor = false;
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += new EventHandler((object o, EventArgs e) =>
            {
                string file = AppDomain.CurrentDomain.BaseDirectory + "/Project/" + audioTrack.Name + ".wav";
                if (File.Exists(file))
                {
                    if (btnReproducir.Text.Equals("Reproducir"))
                    {
                        if (autoPlay)
                            player.settings.setMode("loop", true);
                        player.controls.play();
                        btnReproducir.Text = "Detener";
                    }
                    else
                    {
                        player.controls.stop();
                        btnReproducir.Text = "Reproducir";
                    }
                }
            });

            //
            // textBox
            //
            textBox.Location = new System.Drawing.Point(0, 0);
            textBox.Name = "textBox";
            textBox.Size = new System.Drawing.Size(100, 20);
            textBox.TabIndex = 12;
            textBox.KeyPress += new KeyPressEventHandler((object o, KeyPressEventArgs e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    string oldFile = AppDomain.CurrentDomain.BaseDirectory + @"Project\" + groupBox.Text + ".wav";
                    string _oldFile = AppDomain.CurrentDomain.BaseDirectory + @"Project\_" + groupBox.Text + ".wav";
                    groupBox.Text = textBox.Text;
                    groupBox.Name = textBox.Text;
                    audioTrack.Name = textBox.Text;
                    
                    string path = audioTrack.Name + ".wav";
                    string _path = "_" + audioTrack.Name + ".wav";
                    if (File.Exists(oldFile))
                    {
                        FileSystem.RenameFile(oldFile, path);
                        FileSystem.RenameFile(_oldFile, _path);
                        RequiresSaving = true;
                    }
                    textBox.Visible = false;
                }
            });
            // invisible background for textBox
            // 
            // materialButton
            // 
            materialButton.AutoSize = false;
            materialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton.Depth = 0;
            materialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            materialButton.HighEmphasis = true;
            materialButton.Icon = null;
            materialButton.Location = new System.Drawing.Point(293, 13);
            materialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButton.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton.Name = "materialButton2";
            materialButton.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButton.Size = new System.Drawing.Size(100, 36);
            materialButton.TabIndex = 10;
            materialButton.Text = "Eliminar";
            materialButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton.UseAccentColor = false;
            materialButton.UseVisualStyleBackColor = true;
            materialButton.Click += new EventHandler((object o, EventArgs e) =>
            {
                audioTracksPanel.Controls.Remove(groupBox);
                _AudioTracks.Remove(audioTrack);
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"Project\" + audioTrack.Name + ".wav");
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"Project\_" + audioTrack.Name + ".wav");
                RequiresSaving = true;
            });
            // 
            // materialButton1a
            // 
            materialButton1a.AutoSize = false;
            materialButton1a.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButton1a.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1a.Depth = 0;
            materialButton1a.HighEmphasis = true;
            materialButton1a.Icon = null;
            materialButton1a.Location = new System.Drawing.Point(293, 55);
            materialButton1a.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButton1a.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1a.Name = "materialButton1";
            materialButton1a.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButton1a.Size = new System.Drawing.Size(100, 36);
            materialButton1a.TabIndex = 9;
            materialButton1a.Text = "Re-grabar";
            materialButton1a.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1a.UseAccentColor = false;
            materialButton1a.UseVisualStyleBackColor = true;
            materialButton1a.Focus();
            materialButton1a.Click += new EventHandler((object o, EventArgs e) =>
            {
                // re-grabar function event handler
                string audiotrack = AppDomain.CurrentDomain.BaseDirectory + @"Project\" + groupBox.Name + ".wav";
                string _audiotrack = AppDomain.CurrentDomain.BaseDirectory + @"Project\_" + groupBox.Name + ".wav";
                string alias = "temp";
                if (!RecordingAudioTrack)
                {
                    File.Delete(audiotrack);
                    RecordAudio.Start();
                    RecordAudio.Start(16384, alias);
                    RecordingAudioTrack = true;
                    materialButton1a.Text = "Detener";
                    RequiresSaving = true;
                }
                else
                {
                    RecordAudio.Stop(audiotrack);
                    RecordAudio.Stop(_audiotrack, alias);
                    RecordingAudioTrack = false;
                    materialButton1a.Text = "Re-Grabar";
                    if (autoPlay)
                        btnReproducir.PerformClick();
                }
            });
            if (autoRecord)
                materialButton1a.PerformClick();
            // 
            // volumea
            // 
            volumea.Depth = 0;
            volumea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            volumea.Location = new System.Drawing.Point(12, 17);
            volumea.MouseState = MaterialSkin.MouseState.HOVER;
            volumea.Name = "volume";
            volumea.Size = new System.Drawing.Size(250, 40);
            volumea.TabIndex = 7;
            volumea.Text = "Volúmen";
            volumea.Value = audioTrack.Volume;
            volumea.onValueChanged += new MaterialSlider.ValueChanged((object o, int newValue) =>
            {
                audioTrack.Volume = newValue;
                if (!audioTrack.IsMuted)
                    player.settings.volume = audioTrack.Volume;
                RequiresSaving = true;
            });
            // 
            // materialSwitch
            // 
            materialSwitch.Checked = audioTrack.IsMuted;
            materialSwitch.AutoSize = true;
            materialSwitch.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            materialSwitch.Depth = 0;
            materialSwitch.Location = new System.Drawing.Point(3, 60);
            materialSwitch.Margin = new System.Windows.Forms.Padding(0);
            materialSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            materialSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            materialSwitch.Name = "materialSwitch1";
            materialSwitch.Ripple = true;
            materialSwitch.Size = new System.Drawing.Size(94, 37);
            materialSwitch.TabIndex = 5;
            materialSwitch.Text = "Mute";
            materialSwitch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            materialSwitch.UseVisualStyleBackColor = true;
            materialSwitch.CheckStateChanged += new System.EventHandler((object o, EventArgs e) =>
            {
                audioTrack.IsMuted = materialSwitch.Checked;
                RequiresSaving = true;
                if (!audioTrack.IsMuted)
                {
                    player.settings.volume = audioTrack.Volume;
                }
                else
                {
                    player.settings.volume = 0;
                }
            });

            if (audioTrack.IsMuted)
            {
                Console.WriteLine(audioTrack.Name + " set to muted.");
                audioTrack.Volume = 0;
                player.settings.volume = 0;
            } else
            {
                Console.WriteLine(audioTrack.Name + " set to " + audioTrack.Volume);
                player.settings.volume = audioTrack.Volume;
            }

            textBox.Visible = false;

            groupBox.DoubleClick += new EventHandler((object o, EventArgs e) =>
            {
                textBox.Visible = true;
                textBox.Focus();
            });

            groupBox.Controls.Add(textBox);
            groupBox.Controls.Add(materialButton);
            groupBox.Controls.Add(materialButton1a);
            groupBox.Controls.Add(volumea);
            groupBox.Controls.Add(materialSwitch);
            groupBox.Controls.Add(btnReproducir);

            audioTracksPanel.Controls.Add(groupBox);

            _groupBoxes.Add(groupBox);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            RecordAudio.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            RecordAudio.Stop();

            //new AnalizadorFrecuencias(ref pictureBox1, ref nombreEscala, ref comboBox2, ref comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //FormatAudio.ConvertFormat(AppDomain.CurrentDomain.BaseDirectory + "i_write_sins.wav", AppDomain.CurrentDomain.BaseDirectory + "D3.wav");
            AudioTrack[] audioTracks = new AudioTrack[audioTracksPanel.Controls.Count];
            //FormatAudio.ConvertFormat();

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

        /// <summary>
        /// Metodo que se encarga de abrir un archivo .him
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asd2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Proyecto HIM|*.him",
                Title = "Abrir proyecto"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                FormatAudio.DecompressFile(fileName);
                _AudioTracks = FormatAudio.ExtractAudioTracks(Path.GetFileNameWithoutExtension(fileName) + ".dhim");
                AddAudioTracks(_AudioTracks);
                File.Delete(Path.GetFileNameWithoutExtension(fileName) + ".dhim");
                IsExternalProject = true;
                FileNameOpened = fileName;
            }
        }

        private void AddAudioTracks(List<AudioTrack> audioTracks)
        {
            //DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Project");
            foreach (var audioTrack in audioTracks)
            {
                string name = audioTrack.Name;
                if (name[0] != '_')
                    CreateAudioTrackBox(audioTrack);
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (!Looping)
            {
                DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Project");
                foreach (var file in d.GetFiles("*.wav"))
                {
                    if (file.Name[0].Equals("_"))
                        continue;
                    else
                    {
                        var player = new WindowsMediaPlayer
                        {
                            URL = AppDomain.CurrentDomain.BaseDirectory + "/Project/" + file.Name
                        };
                        Players.Add(player);
                        player.settings.setMode("loop", true);
                    }
                }
                Looping = true;
                materialButton4.Text = "Detener";
            }
            else
            {
                foreach (var player in Players)
                {
                    player.controls.stop();
                }
                Players.Clear();
                Looping = false;
                materialButton4.Text = "Loop";
            }
        }

        private void asd2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        // Play button event
        private void materialButton3_Click(object sender, EventArgs e)
        {
            string audiotrack = AppDomain.CurrentDomain.BaseDirectory + "/Project/" + groupBox1.Name + ".wav";
            SoundPlayer sp = new SoundPlayer(audiotrack);
            sp.Play();
        }

        // re-grabar button event
        private void materialButton1_Click(object sender, EventArgs e)
        {
            string audiotrack = AppDomain.CurrentDomain.BaseDirectory + "/Project/" + groupBox1.Name + ".wav";
            if (!RecordingAudioTrack)
            {
                File.Delete(audiotrack);
                RecordAudio.Start();
                RecordingAudioTrack = true;
                materialButton1.Text = "Detener";
            } else
            {
                RecordAudio.Stop(audiotrack);
                RecordingAudioTrack = false;
                materialButton1.Text = "Re-Grabar";
            }
            
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            audioTracksPanel.Controls.Remove(groupBox1);
        }

        private void volume_onValueChanged(object sender, int newValue)
        {
            
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            AudioTrack audioTrack = new AudioTrack(null, "AudioTrack");
            _AudioTracks.Add(audioTrack);
            CreateAudioTrackBox(audioTrack, true, true);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                groupBox1.Text = textBox1.Text;
                groupBox1.Name = textBox1.Text;
                textBox1.Visible = false;
            }
        }
        private void groupBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Focus();
        }

        private void asd3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsExternalProject)
            {
                FormatAudio.ConvertFormat(FileNameOpened, _AudioTracks.ToArray());
                RequiresSaving = false;
            }
        }

        private void GuardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Proyecto HIM|*.him",
                Title = "Guardar proyecto"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                FormatAudio.ConvertFormat(fileName, _AudioTracks.ToArray());
                foreach (var audioTrack in __AudioTracks)
                {
                    Console.WriteLine(audioTrack.Name);
                }
                RequiresSaving = false;
            }
        }
        private void DeleteAllFiles()
        {
            DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory + "/Project");
            foreach (var file in d.GetFiles("*.wav"))
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "/Project/" + file.Name);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }

        private void agregarPistaExternaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivo WAVE|*.wav",
                Title = "Agregar pista externa"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                AudioTrack audioTrack = new AudioTrack(null, Path.GetFileName(Path.GetFileNameWithoutExtension(fileName)));
                File.Copy(fileName, AppDomain.CurrentDomain.BaseDirectory + "/Project/" + audioTrack.Name + ".wav");
                // TODO CreateAudioTrackBox(audioTrack);
            }*/
        }

        private void generadorEscalaMusicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string audioTrackSelected = "";
            string instrumentoSelected = "";
            string[] afinacionSelected = new string[6];
            ElegirAudioTrack elegirAudioTrack = new ElegirAudioTrack(_AudioTracks, audioTrackSelected, instrumentoSelected, afinacionSelected);
            elegirAudioTrack.ShowDialog();
            audioTrackSelected = elegirAudioTrack.AudioTrackSelected;
            instrumentoSelected = elegirAudioTrack.InstrumentoSelected;
            afinacionSelected = elegirAudioTrack.AfinacionSelected;

            if (audioTrackSelected == null || audioTrackSelected == "")
            {
                Console.WriteLine("No se seleccionó ninguna pista");
            }
            else
            {
                Console.WriteLine("Pista seleccionada: " + audioTrackSelected);
                new AnalizadorFrecuencias(audioTrackSelected, afinacionSelected, instrumentoSelected);
            }
        }

        private void improvisaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConfigMenu().ShowDialog();
        }

        private void IntefazGrabacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RequiresSaving)
            {
                const string message = "¿Desea guardar los cambios realizados?";
                const string caption = "Guardar";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);



                if (result == DialogResult.Yes)
                {
                    GuardarComo();
                    DeleteAllFiles();
                }
                else if(result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }else if(result == DialogResult.No)
                {
                    DeleteAllFiles();
                }
            }
            
        }

        private void mixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string target = AppDomain.CurrentDomain.BaseDirectory + "/Project/i_write_sins.wav";
            string output = AppDomain.CurrentDomain.BaseDirectory + "/outputMixed.wav";
            Mixer mixer = new Mixer(target, output);
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "/Project");
            mixer.Merge(files);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string audioTrackSelected = "";
            string instrumentoSelected = "";
            string[] afinacionSelected = new string[6];
            new ElegirAudioTrack(_AudioTracks, audioTrackSelected, instrumentoSelected, afinacionSelected).ShowDialog();
            /*string[] scale = { "C", "C#", "D#", "F", "F#", "G#", "A#" };
            string[] tuning = { "E", "A", "D", "G", "B", "E" };
            new MostradorEscalaMusical(scale, tuning).ShowDialog();*/
        }

        private void asdToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (RequiresSaving)
            {
                const string message = "Antes de iniciar un nuevo proyecto, ¿desea guardar los cambios realizados?";
                const string caption = "Guardar";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNoCancel,
                                             MessageBoxIcon.Question);



                if (result == DialogResult.Yes)
                {
                    GuardarComo();
                    ResetProject();
                } else if (result == DialogResult.No)
                {
                    ResetProject();
                }
            }
        }

        private void ResetProject()
        {
            DeleteAllFiles();
            _AudioTracks = new List<AudioTrack>();
            __AudioTracks = new List<AudioTrack>();
            foreach (var groupBox in _groupBoxes)
            {
                groupBox.Dispose();
            }
            _groupBoxes = new List<GroupBox>();
            new IntefazGrabacion();
        }

        private void cambiarDispositivoDeGrabacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = RecordAudio.waveInGetNumDevs();
            Console.WriteLine("Devices: " + n);

            
        }

        private void listAllRecordingDevices()
        {
            IEnumerable<CoreAudioDevice> recordingDevices = _coreAudioController.GetDevices(DeviceType.Capture, DeviceState.Active);

            foreach (CoreAudioDevice device in recordingDevices)
            {
                _coreAudioDevice = device;
                ToolStripMenuItem item = new ToolStripMenuItem(device.FullName);
                // write a function that says hello world when click
                item.Click += (sender, e) => {
                    ChangeRecordingDevice(device);
                    foreach (ToolStripMenuItem child in cambiarDispositivoDeGrabaciónToolStripMenuItem.DropDownItems)
                    {
                        child.Checked = false;
                    }
                    item.Checked = true;
                };
                cambiarDispositivoDeGrabaciónToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void ChangeRecordingDevice(CoreAudioDevice device)
        {
            device.SetAsDefault();
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {

        }

        private void hola1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ASD");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open manual.pdf
            string path = AppDomain.CurrentDomain.BaseDirectory + "/manual.pdf";
            Process.Start(path);
        }
    }
}
