
namespace TMI_Project
{
    partial class IntefazGrabacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntefazGrabacion));
            this.nombreEscala = new System.Windows.Forms.Label();
            this.audioTracksPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.volume = new MaterialSkin.Controls.MaterialSlider();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asd2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asd3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPistaExternaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd2ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.generadorEscalaMusicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.luzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asd2ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.españolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inglésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.improvisaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioTracksPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreEscala
            // 
            this.nombreEscala.AutoSize = true;
            this.nombreEscala.Location = new System.Drawing.Point(364, 382);
            this.nombreEscala.Name = "nombreEscala";
            this.nombreEscala.Size = new System.Drawing.Size(0, 13);
            this.nombreEscala.TabIndex = 9;
            // 
            // audioTracksPanel
            // 
            this.audioTracksPanel.Controls.Add(this.groupBox1);
            this.audioTracksPanel.Location = new System.Drawing.Point(0, 243);
            this.audioTracksPanel.Name = "audioTracksPanel";
            this.audioTracksPanel.Size = new System.Drawing.Size(935, 387);
            this.audioTracksPanel.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.materialButton3);
            this.groupBox1.Controls.Add(this.materialButton2);
            this.groupBox1.Controls.Add(this.materialButton1);
            this.groupBox1.Controls.Add(this.volume);
            this.groupBox1.Controls.Add(this.materialSwitch1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sample";
            this.groupBox1.DoubleClick += new System.EventHandler(this.groupBox1_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(162, 55);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(100, 36);
            this.materialButton3.TabIndex = 11;
            this.materialButton3.Text = "Reproducir";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(293, 13);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(100, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Eliminar";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(293, 55);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(100, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Re-grabar";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // volume
            // 
            this.volume.Depth = 0;
            this.volume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.volume.Location = new System.Drawing.Point(12, 17);
            this.volume.MouseState = MaterialSkin.MouseState.HOVER;
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(250, 40);
            this.volume.TabIndex = 7;
            this.volume.Text = "Volúmen";
            this.volume.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.volume_onValueChanged);
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(3, 60);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(94, 37);
            this.materialSwitch1.TabIndex = 5;
            this.materialSwitch1.Text = "Mute";
            this.materialSwitch1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.materialSwitch1.UseVisualStyleBackColor = true;
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem1,
            this.asd2ToolStripMenuItem1,
            this.asd3ToolStripMenuItem1,
            this.guardarComoToolStripMenuItem,
            this.agregarPistaExternaToolStripMenuItem});
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.asdToolStripMenuItem.Text = "Archivo";
            // 
            // asdToolStripMenuItem1
            // 
            this.asdToolStripMenuItem1.Name = "asdToolStripMenuItem1";
            this.asdToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.asdToolStripMenuItem1.Text = "Nuevo (NYI)";
            this.asdToolStripMenuItem1.Click += new System.EventHandler(this.asdToolStripMenuItem1_Click);
            // 
            // asd2ToolStripMenuItem1
            // 
            this.asd2ToolStripMenuItem1.Name = "asd2ToolStripMenuItem1";
            this.asd2ToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.asd2ToolStripMenuItem1.Text = "Abrir";
            this.asd2ToolStripMenuItem1.Click += new System.EventHandler(this.asd2ToolStripMenuItem1_Click);
            // 
            // asd3ToolStripMenuItem1
            // 
            this.asd3ToolStripMenuItem1.Name = "asd3ToolStripMenuItem1";
            this.asd3ToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.asd3ToolStripMenuItem1.Text = "Guardar (NYI)";
            this.asd3ToolStripMenuItem1.Click += new System.EventHandler(this.asd3ToolStripMenuItem1_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // agregarPistaExternaToolStripMenuItem
            // 
            this.agregarPistaExternaToolStripMenuItem.Name = "agregarPistaExternaToolStripMenuItem";
            this.agregarPistaExternaToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.agregarPistaExternaToolStripMenuItem.Text = "Agregar pista externa (NYI)";
            this.agregarPistaExternaToolStripMenuItem.Click += new System.EventHandler(this.agregarPistaExternaToolStripMenuItem_Click);
            // 
            // asd2ToolStripMenuItem
            // 
            this.asd2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asd1ToolStripMenuItem,
            this.asd2ToolStripMenuItem2,
            this.generadorEscalaMusicalToolStripMenuItem,
            this.mixToolStripMenuItem});
            this.asd2ToolStripMenuItem.Name = "asd2ToolStripMenuItem";
            this.asd2ToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.asd2ToolStripMenuItem.Text = "Herramientas";
            // 
            // asd1ToolStripMenuItem
            // 
            this.asd1ToolStripMenuItem.Name = "asd1ToolStripMenuItem";
            this.asd1ToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.asd1ToolStripMenuItem.Text = "Temporizador (NYI)";
            // 
            // asd2ToolStripMenuItem2
            // 
            this.asd2ToolStripMenuItem2.Name = "asd2ToolStripMenuItem2";
            this.asd2ToolStripMenuItem2.Size = new System.Drawing.Size(238, 22);
            this.asd2ToolStripMenuItem2.Text = "Loop (NYI)";
            this.asd2ToolStripMenuItem2.Click += new System.EventHandler(this.asd2ToolStripMenuItem2_Click);
            // 
            // generadorEscalaMusicalToolStripMenuItem
            // 
            this.generadorEscalaMusicalToolStripMenuItem.Name = "generadorEscalaMusicalToolStripMenuItem";
            this.generadorEscalaMusicalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.generadorEscalaMusicalToolStripMenuItem.Text = "Generador escala musical (NYI)";
            this.generadorEscalaMusicalToolStripMenuItem.Click += new System.EventHandler(this.generadorEscalaMusicalToolStripMenuItem_Click);
            // 
            // mixToolStripMenuItem
            // 
            this.mixToolStripMenuItem.Name = "mixToolStripMenuItem";
            this.mixToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.mixToolStripMenuItem.Text = "Mix (NYI)";
            this.mixToolStripMenuItem.Click += new System.EventHandler(this.mixToolStripMenuItem_Click);
            // 
            // asd3ToolStripMenuItem
            // 
            this.asd3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asd1ToolStripMenuItem1,
            this.asd2ToolStripMenuItem3,
            this.improvisaciónToolStripMenuItem,
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem});
            this.asd3ToolStripMenuItem.Name = "asd3ToolStripMenuItem";
            this.asd3ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.asd3ToolStripMenuItem.Text = "Configuración";
            // 
            // asd1ToolStripMenuItem1
            // 
            this.asd1ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luzToolStripMenuItem,
            this.oscuroToolStripMenuItem});
            this.asd1ToolStripMenuItem1.Name = "asd1ToolStripMenuItem1";
            this.asd1ToolStripMenuItem1.Size = new System.Drawing.Size(251, 22);
            this.asd1ToolStripMenuItem1.Text = "Fondo (NYI)";
            // 
            // luzToolStripMenuItem
            // 
            this.luzToolStripMenuItem.Name = "luzToolStripMenuItem";
            this.luzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.luzToolStripMenuItem.Text = "Luz";
            // 
            // oscuroToolStripMenuItem
            // 
            this.oscuroToolStripMenuItem.Name = "oscuroToolStripMenuItem";
            this.oscuroToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.oscuroToolStripMenuItem.Text = "Oscuro";
            // 
            // asd2ToolStripMenuItem3
            // 
            this.asd2ToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.españolToolStripMenuItem,
            this.inglésToolStripMenuItem});
            this.asd2ToolStripMenuItem3.Name = "asd2ToolStripMenuItem3";
            this.asd2ToolStripMenuItem3.Size = new System.Drawing.Size(251, 22);
            this.asd2ToolStripMenuItem3.Text = "Idiomas (NYI)";
            // 
            // españolToolStripMenuItem
            // 
            this.españolToolStripMenuItem.Name = "españolToolStripMenuItem";
            this.españolToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.españolToolStripMenuItem.Text = "Español";
            // 
            // inglésToolStripMenuItem
            // 
            this.inglésToolStripMenuItem.Name = "inglésToolStripMenuItem";
            this.inglésToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.inglésToolStripMenuItem.Text = "Inglés";
            // 
            // improvisaciónToolStripMenuItem
            // 
            this.improvisaciónToolStripMenuItem.Name = "improvisaciónToolStripMenuItem";
            this.improvisaciónToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.improvisaciónToolStripMenuItem.Text = "Improvisación";
            this.improvisaciónToolStripMenuItem.Click += new System.EventHandler(this.improvisaciónToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario (NYI)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdToolStripMenuItem,
            this.asd2ToolStripMenuItem,
            this.asd3ToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(831, 201);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(104, 36);
            this.materialButton4.TabIndex = 14;
            this.materialButton4.Text = "LOOP";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(749, 201);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(74, 36);
            this.materialButton5.TabIndex = 15;
            this.materialButton5.Text = "Añadir";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.materialButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 139);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cambiarDispositivoDeGrabaciónToolStripMenuItem
            // 
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem.Name = "cambiarDispositivoDeGrabaciónToolStripMenuItem";
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem.Text = "Cambiar dispositivo de grabación";
            this.cambiarDispositivoDeGrabaciónToolStripMenuItem.Click += new System.EventHandler(this.cambiarDispositivoDeGrabacionToolStripMenuItem_Click);
            // 
            // IntefazGrabacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 850);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.materialButton5);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.audioTracksPanel);
            this.Controls.Add(this.nombreEscala);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IntefazGrabacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HIM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IntefazGrabacion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IntefazGrabacion_FormClosed);
            this.audioTracksPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombreEscala;
        private System.Windows.Forms.FlowLayoutPanel audioTracksPanel;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asd2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asd3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asd2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asd1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asd2ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem asd3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asd1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem luzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asd2ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem españolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inglésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialSlider volume;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem agregarPistaExternaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generadorEscalaMusicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem improvisaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mixToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cambiarDispositivoDeGrabaciónToolStripMenuItem;
    }
}

