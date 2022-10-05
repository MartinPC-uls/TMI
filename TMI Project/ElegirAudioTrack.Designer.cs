namespace TMI_Project
{
    partial class ElegirAudioTrack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeterminarEscala = new System.Windows.Forms.Button();
            this.audioTrackCB = new System.Windows.Forms.ComboBox();
            this.diagramaInstrumentoCB = new System.Windows.Forms.ComboBox();
            this.lblAudioTrack = new System.Windows.Forms.Label();
            this.lblDiagramaInstrumento = new System.Windows.Forms.Label();
            this.afinacionCB = new System.Windows.Forms.ComboBox();
            this.lblAfinacion = new System.Windows.Forms.Label();
            this.txtAfinacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeterminarEscala
            // 
            this.btnDeterminarEscala.Location = new System.Drawing.Point(12, 98);
            this.btnDeterminarEscala.Name = "btnDeterminarEscala";
            this.btnDeterminarEscala.Size = new System.Drawing.Size(227, 23);
            this.btnDeterminarEscala.TabIndex = 0;
            this.btnDeterminarEscala.Text = "Determinar Escala Musical";
            this.btnDeterminarEscala.UseVisualStyleBackColor = true;
            this.btnDeterminarEscala.Click += new System.EventHandler(this.button1_Click);
            // 
            // audioTrackCB
            // 
            this.audioTrackCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.audioTrackCB.FormattingEnabled = true;
            this.audioTrackCB.Location = new System.Drawing.Point(12, 29);
            this.audioTrackCB.Name = "audioTrackCB";
            this.audioTrackCB.Size = new System.Drawing.Size(121, 21);
            this.audioTrackCB.TabIndex = 6;
            // 
            // diagramaInstrumentoCB
            // 
            this.diagramaInstrumentoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diagramaInstrumentoCB.FormattingEnabled = true;
            this.diagramaInstrumentoCB.Items.AddRange(new object[] {
            "Guitarra",
            "Piano"});
            this.diagramaInstrumentoCB.Location = new System.Drawing.Point(155, 29);
            this.diagramaInstrumentoCB.Name = "diagramaInstrumentoCB";
            this.diagramaInstrumentoCB.Size = new System.Drawing.Size(121, 21);
            this.diagramaInstrumentoCB.TabIndex = 7;
            // 
            // lblAudioTrack
            // 
            this.lblAudioTrack.AutoSize = true;
            this.lblAudioTrack.Location = new System.Drawing.Point(9, 9);
            this.lblAudioTrack.Name = "lblAudioTrack";
            this.lblAudioTrack.Size = new System.Drawing.Size(77, 13);
            this.lblAudioTrack.TabIndex = 8;
            this.lblAudioTrack.Text = "Pista de audio:";
            // 
            // lblDiagramaInstrumento
            // 
            this.lblDiagramaInstrumento.AutoSize = true;
            this.lblDiagramaInstrumento.Location = new System.Drawing.Point(152, 9);
            this.lblDiagramaInstrumento.Name = "lblDiagramaInstrumento";
            this.lblDiagramaInstrumento.Size = new System.Drawing.Size(127, 13);
            this.lblDiagramaInstrumento.TabIndex = 9;
            this.lblDiagramaInstrumento.Text = "Diagrama de instrumento:";
            // 
            // afinacionCB
            // 
            this.afinacionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.afinacionCB.FormattingEnabled = true;
            this.afinacionCB.Items.AddRange(new object[] {
            "D# G# C# F# A# D#",
            "D G C F A D ",
            "C# F# B E G# C#",
            "C F A# D# G C",
            "E A D G B E"});
            this.afinacionCB.Location = new System.Drawing.Point(298, 29);
            this.afinacionCB.Name = "afinacionCB";
            this.afinacionCB.Size = new System.Drawing.Size(121, 21);
            this.afinacionCB.TabIndex = 10;
            // 
            // lblAfinacion
            // 
            this.lblAfinacion.AutoSize = true;
            this.lblAfinacion.Location = new System.Drawing.Point(295, 9);
            this.lblAfinacion.Name = "lblAfinacion";
            this.lblAfinacion.Size = new System.Drawing.Size(54, 13);
            this.lblAfinacion.TabIndex = 11;
            this.lblAfinacion.Text = "Afinación:";
            // 
            // txtAfinacion
            // 
            this.txtAfinacion.Location = new System.Drawing.Point(298, 72);
            this.txtAfinacion.Name = "txtAfinacion";
            this.txtAfinacion.Size = new System.Drawing.Size(121, 20);
            this.txtAfinacion.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ó";
            // 
            // ElegirAudioTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAfinacion);
            this.Controls.Add(this.lblAfinacion);
            this.Controls.Add(this.afinacionCB);
            this.Controls.Add(this.lblDiagramaInstrumento);
            this.Controls.Add(this.lblAudioTrack);
            this.Controls.Add(this.diagramaInstrumentoCB);
            this.Controls.Add(this.audioTrackCB);
            this.Controls.Add(this.btnDeterminarEscala);
            this.Name = "ElegirAudioTrack";
            this.Text = "ElegirAudioTrack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeterminarEscala;
        private System.Windows.Forms.ComboBox audioTrackCB;
        private System.Windows.Forms.ComboBox diagramaInstrumentoCB;
        private System.Windows.Forms.Label lblAudioTrack;
        private System.Windows.Forms.Label lblDiagramaInstrumento;
        private System.Windows.Forms.ComboBox afinacionCB;
        private System.Windows.Forms.Label lblAfinacion;
        private System.Windows.Forms.TextBox txtAfinacion;
        private System.Windows.Forms.Label label1;
    }
}