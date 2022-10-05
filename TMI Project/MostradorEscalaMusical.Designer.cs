using System.Windows.Forms;

namespace TMI_Project
{
    partial class MostradorEscalaMusical
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        PictureBox[,] pbNotes = new PictureBox[6, 13];
        private Label[,] lblNotes = new Label[6, 13];


        private System.Windows.Forms.PictureBox pictureBox1;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            for (int i = 0; i < pbNotes.GetLength(0); i++)
            {
                for (int j = 0; j < pbNotes.GetLength(1); j++)
                {
                    pbNotes[i, j] = new PictureBox();
                    lblNotes[i, j] = new Label();
                }
            }
            for (int i = 0; i < pbNotes.GetLength(0); i++)
            {
                for (int j = 0; j < pbNotes.GetLength(1); j++)
                {
                    ((System.ComponentModel.ISupportInitialize)(this.pbNotes[i, j])).BeginInit();
                }
            }
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TMI_Project.Properties.Resources.Diagrama_Guitarra;
            this.pictureBox1.Location = new System.Drawing.Point(38, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pb1_1
            // 
            this.pbNotes[0, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 1].Location = new System.Drawing.Point(72, 101);
            this.pbNotes[0, 1].Name = "pb1_1";
            this.pbNotes[0, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 1].TabIndex = 0;
            this.pbNotes[0, 1].TabStop = false;
            // 
            // lbl1_1
            // 
            this.lblNotes[0, 1].AutoSize = true;
            this.lblNotes[0, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 1].Location = new System.Drawing.Point(76, 109);
            this.lblNotes[0, 1].Name = "lbl1_1";
            this.lblNotes[0, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 1].TabIndex = 79;
            this.lblNotes[0, 1].Text = "F#";
            // 
            // lbl2_1
            // 
            this.lblNotes[1, 1].AutoSize = true;
            this.lblNotes[1, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 1].Location = new System.Drawing.Point(76, 146);
            this.lblNotes[1, 1].Name = "lbl2_1";
            this.lblNotes[1, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 1].TabIndex = 81;
            this.lblNotes[1, 1].Text = "F#";
            // 
            // pb2_1
            // 
            this.pbNotes[1, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 1].Location = new System.Drawing.Point(72, 138);
            this.pbNotes[1, 1].Name = "pb2_1";
            this.pbNotes[1, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 1].TabIndex = 80;
            this.pbNotes[1, 1].TabStop = false;
            // 
            // lbl3_1
            // 
            this.lblNotes[2, 1].AutoSize = true;
            this.lblNotes[2, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 1].Location = new System.Drawing.Point(76, 181);
            this.lblNotes[2, 1].Name = "lbl3_1";
            this.lblNotes[2, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 1].TabIndex = 83;
            this.lblNotes[2, 1].Text = "F#";
            // 
            // pb3_1
            // 
            this.pbNotes[2, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 1].Location = new System.Drawing.Point(72, 173);
            this.pbNotes[2, 1].Name = "pb3_1";
            this.pbNotes[2, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 1].TabIndex = 82;
            this.pbNotes[2, 1].TabStop = false;
            // 
            // lbl4_1
            // 
            this.lblNotes[3, 1].AutoSize = true;
            this.lblNotes[3, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 1].Location = new System.Drawing.Point(76, 217);
            this.lblNotes[3, 1].Name = "lbl4_1";
            this.lblNotes[3, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 1].TabIndex = 85;
            this.lblNotes[3, 1].Text = "F#";
            // 
            // pb4_1
            // 
            this.pbNotes[3, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 1].Location = new System.Drawing.Point(72, 209);
            this.pbNotes[3, 1].Name = "pb4_1";
            this.pbNotes[3, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 1].TabIndex = 84;
            this.pbNotes[3, 1].TabStop = false;
            // 
            // lbl5_1
            // 
            this.lblNotes[4, 1].AutoSize = true;
            this.lblNotes[4, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 1].Location = new System.Drawing.Point(76, 252);
            this.lblNotes[4, 1].Name = "lbl5_1";
            this.lblNotes[4, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 1].TabIndex = 87;
            this.lblNotes[4, 1].Text = "F#";
            // 
            // pb5_1
            // 
            this.pbNotes[4, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 1].Location = new System.Drawing.Point(72, 244);
            this.pbNotes[4, 1].Name = "pb5_1";
            this.pbNotes[4, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 1].TabIndex = 86;
            this.pbNotes[4, 1].TabStop = false;
            // 
            // lbl6_1
            // 
            this.lblNotes[5, 1].AutoSize = true;
            this.lblNotes[5, 1].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 1].Location = new System.Drawing.Point(76, 285);
            this.lblNotes[5, 1].Name = "lbl6_1";
            this.lblNotes[5, 1].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 1].TabIndex = 89;
            this.lblNotes[5, 1].Text = "F#";
            // 
            // pb6_1
            // 
            this.pbNotes[5, 1].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 1].Location = new System.Drawing.Point(72, 277);
            this.pbNotes[5, 1].Name = "pb6_1";
            this.pbNotes[5, 1].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 1].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 1].TabIndex = 88;
            this.pbNotes[5, 1].TabStop = false;
            // 
            // lbl6_2
            // 
            this.lblNotes[5, 2].AutoSize = true;
            this.lblNotes[5, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 2].Location = new System.Drawing.Point(161, 285);
            this.lblNotes[5, 2].Name = "lbl6_2";
            this.lblNotes[5, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 2].TabIndex = 101;
            this.lblNotes[5, 2].Text = "F#";
            // 
            // pb6_2
            // 
            this.pbNotes[5, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 2].Location = new System.Drawing.Point(157, 277);
            this.pbNotes[5, 2].Name = "pb6_2";
            this.pbNotes[5, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 2].TabIndex = 100;
            this.pbNotes[5, 2].TabStop = false;
            // 
            // lbl5_2
            // 
            this.lblNotes[4, 2].AutoSize = true;
            this.lblNotes[4, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 2].Location = new System.Drawing.Point(161, 252);
            this.lblNotes[4, 2].Name = "lbl5_2";
            this.lblNotes[4, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 2].TabIndex = 99;
            this.lblNotes[4, 2].Text = "F#";
            // 
            // pb5_2
            // 
            this.pbNotes[4, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 2].Location = new System.Drawing.Point(157, 244);
            this.pbNotes[4, 2].Name = "pb5_2";
            this.pbNotes[4, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 2].TabIndex = 98;
            this.pbNotes[4, 2].TabStop = false;
            // 
            // lbl4_2
            // 
            this.lblNotes[3, 2].AutoSize = true;
            this.lblNotes[3, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 2].Location = new System.Drawing.Point(161, 217);
            this.lblNotes[3, 2].Name = "lbl4_2";
            this.lblNotes[3, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 2].TabIndex = 97;
            this.lblNotes[3, 2].Text = "F#";
            // 
            // pb4_2
            // 
            this.pbNotes[3, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 2].Location = new System.Drawing.Point(157, 209);
            this.pbNotes[3, 2].Name = "pb4_2";
            this.pbNotes[3, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 2].TabIndex = 96;
            this.pbNotes[3, 2].TabStop = false;
            // 
            // lbl3_2
            // 
            this.lblNotes[2, 2].AutoSize = true;
            this.lblNotes[2, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 2].Location = new System.Drawing.Point(161, 181);
            this.lblNotes[2, 2].Name = "lbl3_2";
            this.lblNotes[2, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 2].TabIndex = 95;
            this.lblNotes[2, 2].Text = "F#";
            // 
            // pb3_2
            // 
            this.pbNotes[2, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 2].Location = new System.Drawing.Point(157, 173);
            this.pbNotes[2, 2].Name = "pb3_2";
            this.pbNotes[2, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 2].TabIndex = 94;
            this.pbNotes[2, 2].TabStop = false;
            // 
            // lbl2_2
            // 
            this.lblNotes[1, 2].AutoSize = true;
            this.lblNotes[1, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 2].Location = new System.Drawing.Point(161, 146);
            this.lblNotes[1, 2].Name = "lbl2_2";
            this.lblNotes[1, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 2].TabIndex = 93;
            this.lblNotes[1, 2].Text = "F#";
            // 
            // pb2_2
            // 
            this.pbNotes[1, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 2].Location = new System.Drawing.Point(157, 138);
            this.pbNotes[1, 2].Name = "pb2_2";
            this.pbNotes[1, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 2].TabIndex = 92;
            this.pbNotes[1, 2].TabStop = false;
            // 
            // lbl1_2
            // 
            this.lblNotes[0, 2].AutoSize = true;
            this.lblNotes[0, 2].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 2].Location = new System.Drawing.Point(161, 109);
            this.lblNotes[0, 2].Name = "lbl1_2";
            this.lblNotes[0, 2].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 2].TabIndex = 91;
            this.lblNotes[0, 2].Text = "F#";
            // 
            // pb1_2
            // 
            this.pbNotes[0, 2].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 2].Location = new System.Drawing.Point(157, 101);
            this.pbNotes[0, 2].Name = "pb1_2";
            this.pbNotes[0, 2].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 2].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 2].TabIndex = 90;
            this.pbNotes[0, 2].TabStop = false;
            // 
            // lbl6_3
            // 
            this.lblNotes[5, 3].AutoSize = true;
            this.lblNotes[5, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 3].Location = new System.Drawing.Point(243, 285);
            this.lblNotes[5, 3].Name = "lbl6_3";
            this.lblNotes[5, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 3].TabIndex = 113;
            this.lblNotes[5, 3].Text = "F#";
            // 
            // pb6_3
            // 
            this.pbNotes[5, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 3].Location = new System.Drawing.Point(239, 277);
            this.pbNotes[5, 3].Name = "pb6_3";
            this.pbNotes[5, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 3].TabIndex = 112;
            this.pbNotes[5, 3].TabStop = false;
            // 
            // lbl5_3
            // 
            this.lblNotes[4, 3].AutoSize = true;
            this.lblNotes[4, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 3].Location = new System.Drawing.Point(243, 252);
            this.lblNotes[4, 3].Name = "lbl5_3";
            this.lblNotes[4, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 3].TabIndex = 111;
            this.lblNotes[4, 3].Text = "F#";
            // 
            // pb5_3
            // 
            this.pbNotes[4, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 3].Location = new System.Drawing.Point(239, 244);
            this.pbNotes[4, 3].Name = "pb5_3";
            this.pbNotes[4, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 3].TabIndex = 110;
            this.pbNotes[4, 3].TabStop = false;
            // 
            // lbl4_3
            // 
            this.lblNotes[3, 3].AutoSize = true;
            this.lblNotes[3, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 3].Location = new System.Drawing.Point(243, 217);
            this.lblNotes[3, 3].Name = "lbl4_3";
            this.lblNotes[3, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 3].TabIndex = 109;
            this.lblNotes[3, 3].Text = "F#";
            // 
            // pb4_3
            // 
            this.pbNotes[3, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 3].Location = new System.Drawing.Point(239, 209);
            this.pbNotes[3, 3].Name = "pb4_3";
            this.pbNotes[3, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 3].TabIndex = 108;
            this.pbNotes[3, 3].TabStop = false;
            // 
            // lbl3_3
            // 
            this.lblNotes[2, 3].AutoSize = true;
            this.lblNotes[2, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 3].Location = new System.Drawing.Point(243, 181);
            this.lblNotes[2, 3].Name = "lbl3_3";
            this.lblNotes[2, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 3].TabIndex = 107;
            this.lblNotes[2, 3].Text = "F#";
            // 
            // pb3_3
            // 
            this.pbNotes[2, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 3].Location = new System.Drawing.Point(239, 173);
            this.pbNotes[2, 3].Name = "pb3_3";
            this.pbNotes[2, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 3].TabIndex = 106;
            this.pbNotes[2, 3].TabStop = false;
            // 
            // lbl2_3
            // 
            this.lblNotes[1, 3].AutoSize = true;
            this.lblNotes[1, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 3].Location = new System.Drawing.Point(243, 146);
            this.lblNotes[1, 3].Name = "lbl2_3";
            this.lblNotes[1, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 3].TabIndex = 105;
            this.lblNotes[1, 3].Text = "F#";
            // 
            // pb2_3
            // 
            this.pbNotes[1, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 3].Location = new System.Drawing.Point(239, 138);
            this.pbNotes[1, 3].Name = "pb2_3";
            this.pbNotes[1, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 3].TabIndex = 104;
            this.pbNotes[1, 3].TabStop = false;
            // 
            // lbl1_3
            // 
            this.lblNotes[0, 3].AutoSize = true;
            this.lblNotes[0, 3].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 3].Location = new System.Drawing.Point(243, 109);
            this.lblNotes[0, 3].Name = "lbl1_3";
            this.lblNotes[0, 3].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 3].TabIndex = 103;
            this.lblNotes[0, 3].Text = "F#";
            // 
            // pb1_3
            // 
            this.pbNotes[0, 3].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 3].Location = new System.Drawing.Point(239, 101);
            this.pbNotes[0, 3].Name = "pb1_3";
            this.pbNotes[0, 3].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 3].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 3].TabIndex = 102;
            this.pbNotes[0, 3].TabStop = false;
            // 
            // lbl6_4
            // 
            this.lblNotes[5, 4].AutoSize = true;
            this.lblNotes[5, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 4].Location = new System.Drawing.Point(320, 285);
            this.lblNotes[5, 4].Name = "lbl6_4";
            this.lblNotes[5, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 4].TabIndex = 125;
            this.lblNotes[5, 4].Text = "F#";
            // 
            // pb6_4
            // 
            this.pbNotes[5, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 4].Location = new System.Drawing.Point(316, 277);
            this.pbNotes[5, 4].Name = "pb6_4";
            this.pbNotes[5, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 4].TabIndex = 124;
            this.pbNotes[5, 4].TabStop = false;
            // 
            // lbl5_4
            // 
            this.lblNotes[4, 4].AutoSize = true;
            this.lblNotes[4, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 4].Location = new System.Drawing.Point(320, 252);
            this.lblNotes[4, 4].Name = "lbl5_4";
            this.lblNotes[4, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 4].TabIndex = 123;
            this.lblNotes[4, 4].Text = "F#";
            // 
            // pb5_4
            // 
            this.pbNotes[4, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 4].Location = new System.Drawing.Point(316, 244);
            this.pbNotes[4, 4].Name = "pb5_4";
            this.pbNotes[4, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 4].TabIndex = 122;
            this.pbNotes[4, 4].TabStop = false;
            // 
            // lbl4_4
            // 
            this.lblNotes[3, 4].AutoSize = true;
            this.lblNotes[3, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 4].Location = new System.Drawing.Point(320, 217);
            this.lblNotes[3, 4].Name = "lbl4_4";
            this.lblNotes[3, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 4].TabIndex = 121;
            this.lblNotes[3, 4].Text = "F#";
            // 
            // pb4_4
            // 
            this.pbNotes[3, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 4].Location = new System.Drawing.Point(316, 209);
            this.pbNotes[3, 4].Name = "pb4_4";
            this.pbNotes[3, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 4].TabIndex = 120;
            this.pbNotes[3, 4].TabStop = false;
            // 
            // lbl3_4
            // 
            this.lblNotes[2, 4].AutoSize = true;
            this.lblNotes[2, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 4].Location = new System.Drawing.Point(320, 181);
            this.lblNotes[2, 4].Name = "lbl3_4";
            this.lblNotes[2, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 4].TabIndex = 119;
            this.lblNotes[2, 4].Text = "F#";
            // 
            // pb3_4
            // 
            this.pbNotes[2, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 4].Location = new System.Drawing.Point(316, 173);
            this.pbNotes[2, 4].Name = "pb3_4";
            this.pbNotes[2, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 4].TabIndex = 118;
            this.pbNotes[2, 4].TabStop = false;
            // 
            // lbl2_4
            // 
            this.lblNotes[1, 4].AutoSize = true;
            this.lblNotes[1, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 4].Location = new System.Drawing.Point(320, 146);
            this.lblNotes[1, 4].Name = "lbl2_4";
            this.lblNotes[1, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 4].TabIndex = 117;
            this.lblNotes[1, 4].Text = "F#";
            // 
            // pb2_4
            // 
            this.pbNotes[1, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 4].Location = new System.Drawing.Point(316, 138);
            this.pbNotes[1, 4].Name = "pb2_4";
            this.pbNotes[1, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 4].TabIndex = 116;
            this.pbNotes[1, 4].TabStop = false;
            // 
            // lbl1_4
            // 
            this.lblNotes[0, 4].AutoSize = true;
            this.lblNotes[0, 4].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 4].Location = new System.Drawing.Point(320, 109);
            this.lblNotes[0, 4].Name = "lbl1_4";
            this.lblNotes[0, 4].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 4].TabIndex = 115;
            this.lblNotes[0, 4].Text = "F#";
            // 
            // pb1_4
            // 
            this.pbNotes[0, 4].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 4].Location = new System.Drawing.Point(316, 101);
            this.pbNotes[0, 4].Name = "pb1_4";
            this.pbNotes[0, 4].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 4].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 4].TabIndex = 114;
            this.pbNotes[0, 4].TabStop = false;
            // 
            // lbl6_5
            // 
            this.lblNotes[5, 5].AutoSize = true;
            this.lblNotes[5, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 5].Location = new System.Drawing.Point(399, 285);
            this.lblNotes[5, 5].Name = "lbl6_5";
            this.lblNotes[5, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 5].TabIndex = 137;
            this.lblNotes[5, 5].Text = "F#";
            // 
            // pb6_5
            // 
            this.pbNotes[5, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 5].Location = new System.Drawing.Point(395, 277);
            this.pbNotes[5, 5].Name = "pb6_5";
            this.pbNotes[5, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 5].TabIndex = 136;
            this.pbNotes[5, 5].TabStop = false;
            // 
            // lbl5_5
            // 
            this.lblNotes[4, 5].AutoSize = true;
            this.lblNotes[4, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 5].Location = new System.Drawing.Point(399, 252);
            this.lblNotes[4, 5].Name = "lbl5_5";
            this.lblNotes[4, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 5].TabIndex = 135;
            this.lblNotes[4, 5].Text = "F#";
            // 
            // pb5_5
            // 
            this.pbNotes[4, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 5].Location = new System.Drawing.Point(395, 244);
            this.pbNotes[4, 5].Name = "pb5_5";
            this.pbNotes[4, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 5].TabIndex = 134;
            this.pbNotes[4, 5].TabStop = false;
            // 
            // lbl4_5
            // 
            this.lblNotes[3, 5].AutoSize = true;
            this.lblNotes[3, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 5].Location = new System.Drawing.Point(399, 217);
            this.lblNotes[3, 5].Name = "lbl4_5";
            this.lblNotes[3, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 5].TabIndex = 133;
            this.lblNotes[3, 5].Text = "F#";
            // 
            // pb4_5
            // 
            this.pbNotes[3, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 5].Location = new System.Drawing.Point(395, 209);
            this.pbNotes[3, 5].Name = "pb4_5";
            this.pbNotes[3, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 5].TabIndex = 132;
            this.pbNotes[3, 5].TabStop = false;
            // 
            // lbl3_5
            // 
            this.lblNotes[2, 5].AutoSize = true;
            this.lblNotes[2, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 5].Location = new System.Drawing.Point(399, 181);
            this.lblNotes[2, 5].Name = "lbl3_5";
            this.lblNotes[2, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 5].TabIndex = 131;
            this.lblNotes[2, 5].Text = "F#";
            // 
            // pb3_5
            // 
            this.pbNotes[2, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 5].Location = new System.Drawing.Point(395, 173);
            this.pbNotes[2, 5].Name = "pb3_5";
            this.pbNotes[2, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 5].TabIndex = 130;
            this.pbNotes[2, 5].TabStop = false;
            // 
            // lbl2_5
            // 
            this.lblNotes[1, 5].AutoSize = true;
            this.lblNotes[1, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 5].Location = new System.Drawing.Point(399, 146);
            this.lblNotes[1, 5].Name = "lbl2_5";
            this.lblNotes[1, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 5].TabIndex = 129;
            this.lblNotes[1, 5].Text = "F#";
            // 
            // pb2_5
            // 
            this.pbNotes[1, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 5].Location = new System.Drawing.Point(395, 138);
            this.pbNotes[1, 5].Name = "pb2_5";
            this.pbNotes[1, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 5].TabIndex = 128;
            this.pbNotes[1, 5].TabStop = false;
            // 
            // lbl1_5
            // 
            this.lblNotes[0, 5].AutoSize = true;
            this.lblNotes[0, 5].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 5].Location = new System.Drawing.Point(399, 109);
            this.lblNotes[0, 5].Name = "lbl1_5";
            this.lblNotes[0, 5].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 5].TabIndex = 127;
            this.lblNotes[0, 5].Text = "F#";
            // 
            // pb1_5
            // 
            this.pbNotes[0, 5].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 5].Location = new System.Drawing.Point(395, 101);
            this.pbNotes[0, 5].Name = "pb1_5";
            this.pbNotes[0, 5].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 5].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 5].TabIndex = 126;
            this.pbNotes[0, 5].TabStop = false;
            // 
            // lbl6_6
            // 
            this.lblNotes[5, 6].AutoSize = true;
            this.lblNotes[5, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 6].Location = new System.Drawing.Point(471, 285);
            this.lblNotes[5, 6].Name = "lbl6_6";
            this.lblNotes[5, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 6].TabIndex = 149;
            this.lblNotes[5, 6].Text = "F#";
            // 
            // pb6_6
            // 
            this.pbNotes[5, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 6].Location = new System.Drawing.Point(467, 277);
            this.pbNotes[5, 6].Name = "pb6_6";
            this.pbNotes[5, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 6].TabIndex = 148;
            this.pbNotes[5, 6].TabStop = false;
            // 
            // lbl5_6
            // 
            this.lblNotes[4, 6].AutoSize = true;
            this.lblNotes[4, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 6].Location = new System.Drawing.Point(471, 252);
            this.lblNotes[4, 6].Name = "lbl5_6";
            this.lblNotes[4, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 6].TabIndex = 147;
            this.lblNotes[4, 6].Text = "F#";
            // 
            // pb5_6
            // 
            this.pbNotes[4, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 6].Location = new System.Drawing.Point(467, 244);
            this.pbNotes[4, 6].Name = "pb5_6";
            this.pbNotes[4, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 6].TabIndex = 146;
            this.pbNotes[4, 6].TabStop = false;
            // 
            // lbl4_6
            // 
            this.lblNotes[3, 6].AutoSize = true;
            this.lblNotes[3, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 6].Location = new System.Drawing.Point(471, 217);
            this.lblNotes[3, 6].Name = "lbl4_6";
            this.lblNotes[3, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 6].TabIndex = 145;
            this.lblNotes[3, 6].Text = "F#";
            // 
            // pb4_6
            // 
            this.pbNotes[3, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 6].Location = new System.Drawing.Point(467, 209);
            this.pbNotes[3, 6].Name = "pb4_6";
            this.pbNotes[3, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 6].TabIndex = 144;
            this.pbNotes[3, 6].TabStop = false;
            // 
            // lbl3_6
            // 
            this.lblNotes[2, 6].AutoSize = true;
            this.lblNotes[2, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 6].Location = new System.Drawing.Point(471, 181);
            this.lblNotes[2, 6].Name = "lbl3_6";
            this.lblNotes[2, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 6].TabIndex = 143;
            this.lblNotes[2, 6].Text = "F#";
            // 
            // pb3_6
            // 
            this.pbNotes[2, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 6].Location = new System.Drawing.Point(467, 173);
            this.pbNotes[2, 6].Name = "pb3_6";
            this.pbNotes[2, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 6].TabIndex = 142;
            this.pbNotes[2, 6].TabStop = false;
            // 
            // lbl2_6
            // 
            this.lblNotes[1, 6].AutoSize = true;
            this.lblNotes[1, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 6].Location = new System.Drawing.Point(471, 146);
            this.lblNotes[1, 6].Name = "lbl2_6";
            this.lblNotes[1, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 6].TabIndex = 141;
            this.lblNotes[1, 6].Text = "F#";
            // 
            // pb2_6
            // 
            this.pbNotes[1, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 6].Location = new System.Drawing.Point(467, 138);
            this.pbNotes[1, 6].Name = "pb2_6";
            this.pbNotes[1, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 6].TabIndex = 140;
            this.pbNotes[1, 6].TabStop = false;
            // 
            // lbl1_6
            // 
            this.lblNotes[0, 6].AutoSize = true;
            this.lblNotes[0, 6].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 6].Location = new System.Drawing.Point(471, 109);
            this.lblNotes[0, 6].Name = "lbl1_6";
            this.lblNotes[0, 6].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 6].TabIndex = 139;
            this.lblNotes[0, 6].Text = "F#";
            // 
            // pb1_6
            // 
            this.pbNotes[0, 6].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 6].Location = new System.Drawing.Point(467, 101);
            this.pbNotes[0, 6].Name = "pb1_6";
            this.pbNotes[0, 6].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 6].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 6].TabIndex = 138;
            this.pbNotes[0, 6].TabStop = false;
            // 
            // lbl6_7
            // 
            this.lblNotes[5, 7].AutoSize = true;
            this.lblNotes[5, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 7].Location = new System.Drawing.Point(542, 285);
            this.lblNotes[5, 7].Name = "lbl6_7";
            this.lblNotes[5, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 7].TabIndex = 161;
            this.lblNotes[5, 7].Text = "F#";
            // 
            // pb6_7
            // 
            this.pbNotes[5, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 7].Location = new System.Drawing.Point(538, 277);
            this.pbNotes[5, 7].Name = "pb6_7";
            this.pbNotes[5, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 7].TabIndex = 160;
            this.pbNotes[5, 7].TabStop = false;
            // 
            // lbl5_7
            // 
            this.lblNotes[4, 7].AutoSize = true;
            this.lblNotes[4, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 7].Location = new System.Drawing.Point(542, 252);
            this.lblNotes[4, 7].Name = "lbl5_7";
            this.lblNotes[4, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 7].TabIndex = 159;
            this.lblNotes[4, 7].Text = "F#";
            // 
            // pb5_7
            // 
            this.pbNotes[4, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 7].Location = new System.Drawing.Point(538, 244);
            this.pbNotes[4, 7].Name = "pb5_7";
            this.pbNotes[4, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 7].TabIndex = 158;
            this.pbNotes[4, 7].TabStop = false;
            // 
            // lbl4_7
            // 
            this.lblNotes[3, 7].AutoSize = true;
            this.lblNotes[3, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 7].Location = new System.Drawing.Point(542, 217);
            this.lblNotes[3, 7].Name = "lbl4_7";
            this.lblNotes[3, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 7].TabIndex = 157;
            this.lblNotes[3, 7].Text = "F#";
            // 
            // pb4_7
            // 
            this.pbNotes[3, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 7].Location = new System.Drawing.Point(538, 209);
            this.pbNotes[3, 7].Name = "pb4_7";
            this.pbNotes[3, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 7].TabIndex = 156;
            this.pbNotes[3, 7].TabStop = false;
            // 
            // lbl3_7
            // 
            this.lblNotes[2, 7].AutoSize = true;
            this.lblNotes[2, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 7].Location = new System.Drawing.Point(542, 181);
            this.lblNotes[2, 7].Name = "lbl3_7";
            this.lblNotes[2, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 7].TabIndex = 155;
            this.lblNotes[2, 7].Text = "F#";
            // 
            // pb3_7
            // 
            this.pbNotes[2, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 7].Location = new System.Drawing.Point(538, 173);
            this.pbNotes[2, 7].Name = "pb3_7";
            this.pbNotes[2, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 7].TabIndex = 154;
            this.pbNotes[2, 7].TabStop = false;
            // 
            // lbl2_7
            // 
            this.lblNotes[1, 7].AutoSize = true;
            this.lblNotes[1, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 7].Location = new System.Drawing.Point(542, 146);
            this.lblNotes[1, 7].Name = "lbl2_7";
            this.lblNotes[1, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 7].TabIndex = 153;
            this.lblNotes[1, 7].Text = "F#";
            // 
            // pb2_7
            // 
            this.pbNotes[1, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 7].Location = new System.Drawing.Point(538, 138);
            this.pbNotes[1, 7].Name = "pb2_7";
            this.pbNotes[1, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 7].TabIndex = 152;
            this.pbNotes[1, 7].TabStop = false;
            // 
            // lbl1_7
            // 
            this.lblNotes[0, 7].AutoSize = true;
            this.lblNotes[0, 7].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 7].Location = new System.Drawing.Point(542, 109);
            this.lblNotes[0, 7].Name = "lbl1_7";
            this.lblNotes[0, 7].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 7].TabIndex = 151;
            this.lblNotes[0, 7].Text = "F#";
            // 
            // pb1_7
            // 
            this.pbNotes[0, 7].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 7].Location = new System.Drawing.Point(538, 101);
            this.pbNotes[0, 7].Name = "pb1_7";
            this.pbNotes[0, 7].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 7].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 7].TabIndex = 150;
            this.pbNotes[0, 7].TabStop = false;
            // 
            // lbl6_8
            // 
            this.lblNotes[5, 8].AutoSize = true;
            this.lblNotes[5, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 8].Location = new System.Drawing.Point(615, 285);
            this.lblNotes[5, 8].Name = "lbl6_8";
            this.lblNotes[5, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 8].TabIndex = 173;
            this.lblNotes[5, 8].Text = "F#";
            // 
            // pb6_8
            // 
            this.pbNotes[5, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 8].Location = new System.Drawing.Point(611, 277);
            this.pbNotes[5, 8].Name = "pb6_8";
            this.pbNotes[5, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 8].TabIndex = 172;
            this.pbNotes[5, 8].TabStop = false;
            // 
            // lbl5_8
            // 
            this.lblNotes[4, 8].AutoSize = true;
            this.lblNotes[4, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 8].Location = new System.Drawing.Point(615, 252);
            this.lblNotes[4, 8].Name = "lbl5_8";
            this.lblNotes[4, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 8].TabIndex = 171;
            this.lblNotes[4, 8].Text = "F#";
            // 
            // pb5_8
            // 
            this.pbNotes[4, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 8].Location = new System.Drawing.Point(611, 244);
            this.pbNotes[4, 8].Name = "pb5_8";
            this.pbNotes[4, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 8].TabIndex = 170;
            this.pbNotes[4, 8].TabStop = false;
            // 
            // lbl4_8
            // 
            this.lblNotes[3, 8].AutoSize = true;
            this.lblNotes[3, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 8].Location = new System.Drawing.Point(615, 217);
            this.lblNotes[3, 8].Name = "lbl4_8";
            this.lblNotes[3, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 8].TabIndex = 169;
            this.lblNotes[3, 8].Text = "F#";
            // 
            // pb4_8
            // 
            this.pbNotes[3, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 8].Location = new System.Drawing.Point(611, 209);
            this.pbNotes[3, 8].Name = "pb4_8";
            this.pbNotes[3, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 8].TabIndex = 168;
            this.pbNotes[3, 8].TabStop = false;
            // 
            // lbl3_8
            // 
            this.lblNotes[2, 8].AutoSize = true;
            this.lblNotes[2, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 8].Location = new System.Drawing.Point(615, 181);
            this.lblNotes[2, 8].Name = "lbl3_8";
            this.lblNotes[2, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 8].TabIndex = 167;
            this.lblNotes[2, 8].Text = "F#";
            // 
            // pb3_8
            // 
            this.pbNotes[2, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 8].Location = new System.Drawing.Point(611, 173);
            this.pbNotes[2, 8].Name = "pb3_8";
            this.pbNotes[2, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 8].TabIndex = 166;
            this.pbNotes[2, 8].TabStop = false;
            // 
            // lbl2_8
            // 
            this.lblNotes[1, 8].AutoSize = true;
            this.lblNotes[1, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 8].Location = new System.Drawing.Point(615, 146);
            this.lblNotes[1, 8].Name = "lbl2_8";
            this.lblNotes[1, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 8].TabIndex = 165;
            this.lblNotes[1, 8].Text = "F#";
            // 
            // pb2_8
            // 
            this.pbNotes[1, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 8].Location = new System.Drawing.Point(611, 138);
            this.pbNotes[1, 8].Name = "pb2_8";
            this.pbNotes[1, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 8].TabIndex = 164;
            this.pbNotes[1, 8].TabStop = false;
            // 
            // lbl1_8
            // 
            this.lblNotes[0, 8].AutoSize = true;
            this.lblNotes[0, 8].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 8].Location = new System.Drawing.Point(615, 109);
            this.lblNotes[0, 8].Name = "lbl1_8";
            this.lblNotes[0, 8].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 8].TabIndex = 163;
            this.lblNotes[0, 8].Text = "F#";
            // 
            // pb1_8
            // 
            this.pbNotes[0, 8].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 8].Location = new System.Drawing.Point(611, 101);
            this.pbNotes[0, 8].Name = "pb1_8";
            this.pbNotes[0, 8].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 8].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 8].TabIndex = 162;
            this.pbNotes[0, 8].TabStop = false;
            // 
            // lbl6_9
            // 
            this.lblNotes[5, 9].AutoSize = true;
            this.lblNotes[5, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 9].Location = new System.Drawing.Point(681, 285);
            this.lblNotes[5, 9].Name = "lbl6_9";
            this.lblNotes[5, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 9].TabIndex = 185;
            this.lblNotes[5, 9].Text = "F#";
            // 
            // pb6_9
            // 
            this.pbNotes[5, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 9].Location = new System.Drawing.Point(677, 277);
            this.pbNotes[5, 9].Name = "pb6_9";
            this.pbNotes[5, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 9].TabIndex = 184;
            this.pbNotes[5, 9].TabStop = false;
            // 
            // lbl5_9
            // 
            this.lblNotes[4, 9].AutoSize = true;
            this.lblNotes[4, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 9].Location = new System.Drawing.Point(681, 252);
            this.lblNotes[4, 9].Name = "lbl5_9";
            this.lblNotes[4, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 9].TabIndex = 183;
            this.lblNotes[4, 9].Text = "F#";
            // 
            // pb5_9
            // 
            this.pbNotes[4, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 9].Location = new System.Drawing.Point(677, 244);
            this.pbNotes[4, 9].Name = "pb5_9";
            this.pbNotes[4, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 9].TabIndex = 182;
            this.pbNotes[4, 9].TabStop = false;
            // 
            // lbl4_9
            // 
            this.lblNotes[3, 9].AutoSize = true;
            this.lblNotes[3, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 9].Location = new System.Drawing.Point(681, 217);
            this.lblNotes[3, 9].Name = "lbl4_9";
            this.lblNotes[3, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 9].TabIndex = 181;
            this.lblNotes[3, 9].Text = "F#";
            // 
            // pb4_9
            // 
            this.pbNotes[3, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 9].Location = new System.Drawing.Point(677, 209);
            this.pbNotes[3, 9].Name = "pb4_9";
            this.pbNotes[3, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 9].TabIndex = 180;
            this.pbNotes[3, 9].TabStop = false;
            // 
            // lbl3_9
            // 
            this.lblNotes[2, 9].AutoSize = true;
            this.lblNotes[2, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 9].Location = new System.Drawing.Point(681, 181);
            this.lblNotes[2, 9].Name = "lbl3_9";
            this.lblNotes[2, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 9].TabIndex = 179;
            this.lblNotes[2, 9].Text = "F#";
            // 
            // pb3_9
            // 
            this.pbNotes[2, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 9].Location = new System.Drawing.Point(677, 173);
            this.pbNotes[2, 9].Name = "pb3_9";
            this.pbNotes[2, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 9].TabIndex = 178;
            this.pbNotes[2, 9].TabStop = false;
            // 
            // lbl2_9
            // 
            this.lblNotes[1, 9].AutoSize = true;
            this.lblNotes[1, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 9].Location = new System.Drawing.Point(681, 146);
            this.lblNotes[1, 9].Name = "lbl2_9";
            this.lblNotes[1, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 9].TabIndex = 177;
            this.lblNotes[1, 9].Text = "F#";
            // 
            // pb2_9
            // 
            this.pbNotes[1, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 9].Location = new System.Drawing.Point(677, 138);
            this.pbNotes[1, 9].Name = "pb2_9";
            this.pbNotes[1, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 9].TabIndex = 176;
            this.pbNotes[1, 9].TabStop = false;
            // 
            // lbl1_9
            // 
            this.lblNotes[0, 9].AutoSize = true;
            this.lblNotes[0, 9].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 9].Location = new System.Drawing.Point(681, 109);
            this.lblNotes[0, 9].Name = "lbl1_9";
            this.lblNotes[0, 9].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 9].TabIndex = 175;
            this.lblNotes[0, 9].Text = "F#";
            // 
            // pb1_9
            // 
            this.pbNotes[0, 9].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 9].Location = new System.Drawing.Point(677, 101);
            this.pbNotes[0, 9].Name = "pb1_9";
            this.pbNotes[0, 9].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 9].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 9].TabIndex = 174;
            this.pbNotes[0, 9].TabStop = false;
            // 
            // lbl6_10
            // 
            this.lblNotes[5, 10].AutoSize = true;
            this.lblNotes[5, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 10].Location = new System.Drawing.Point(750, 285);
            this.lblNotes[5, 10].Name = "lbl6_10";
            this.lblNotes[5, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 10].TabIndex = 197;
            this.lblNotes[5, 10].Text = "F#";
            // 
            // pb6_10
            // 
            this.pbNotes[5, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 10].Location = new System.Drawing.Point(746, 277);
            this.pbNotes[5, 10].Name = "pb6_10";
            this.pbNotes[5, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 10].TabIndex = 196;
            this.pbNotes[5, 10].TabStop = false;
            // 
            // lbl5_10
            // 
            this.lblNotes[4, 10].AutoSize = true;
            this.lblNotes[4, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 10].Location = new System.Drawing.Point(750, 252);
            this.lblNotes[4, 10].Name = "lbl5_10";
            this.lblNotes[4, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 10].TabIndex = 195;
            this.lblNotes[4, 10].Text = "F#";
            // 
            // pb5_10
            // 
            this.pbNotes[4, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 10].Location = new System.Drawing.Point(746, 244);
            this.pbNotes[4, 10].Name = "pb5_10";
            this.pbNotes[4, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 10].TabIndex = 194;
            this.pbNotes[4, 10].TabStop = false;
            // 
            // lbl4_10
            // 
            this.lblNotes[3, 10].AutoSize = true;
            this.lblNotes[3, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 10].Location = new System.Drawing.Point(750, 217);
            this.lblNotes[3, 10].Name = "lbl4_10";
            this.lblNotes[3, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 10].TabIndex = 193;
            this.lblNotes[3, 10].Text = "F#";
            // 
            // pb4_10
            // 
            this.pbNotes[3, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 10].Location = new System.Drawing.Point(746, 209);
            this.pbNotes[3, 10].Name = "pb4_10";
            this.pbNotes[3, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 10].TabIndex = 192;
            this.pbNotes[3, 10].TabStop = false;
            // 
            // lbl3_10
            // 
            this.lblNotes[2, 10].AutoSize = true;
            this.lblNotes[2, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 10].Location = new System.Drawing.Point(750, 181);
            this.lblNotes[2, 10].Name = "lbl3_10";
            this.lblNotes[2, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 10].TabIndex = 191;
            this.lblNotes[2, 10].Text = "F#";
            // 
            // pb3_10
            // 
            this.pbNotes[2, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 10].Location = new System.Drawing.Point(746, 173);
            this.pbNotes[2, 10].Name = "pb3_10";
            this.pbNotes[2, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 10].TabIndex = 190;
            this.pbNotes[2, 10].TabStop = false;
            // 
            // lbl2_10
            // 
            this.lblNotes[1, 10].AutoSize = true;
            this.lblNotes[1, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 10].Location = new System.Drawing.Point(750, 146);
            this.lblNotes[1, 10].Name = "lbl2_10";
            this.lblNotes[1, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 10].TabIndex = 189;
            this.lblNotes[1, 10].Text = "F#";
            // 
            // pb2_10
            // 
            this.pbNotes[1, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 10].Location = new System.Drawing.Point(746, 138);
            this.pbNotes[1, 10].Name = "pb2_10";
            this.pbNotes[1, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 10].TabIndex = 188;
            this.pbNotes[1, 10].TabStop = false;
            // 
            // lbl1_10
            // 
            this.lblNotes[0, 10].AutoSize = true;
            this.lblNotes[0, 10].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 10].Location = new System.Drawing.Point(750, 109);
            this.lblNotes[0, 10].Name = "lbl1_10";
            this.lblNotes[0, 10].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 10].TabIndex = 187;
            this.lblNotes[0, 10].Text = "F#";
            // 
            // pb1_10
            // 
            this.pbNotes[0, 10].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 10].Location = new System.Drawing.Point(746, 101);
            this.pbNotes[0, 10].Name = "pb1_10";
            this.pbNotes[0, 10].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 10].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 10].TabIndex = 186;
            this.pbNotes[0, 10].TabStop = false;
            // 
            // lbl6_11
            // 
            this.lblNotes[5, 11].AutoSize = true;
            this.lblNotes[5, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 11].Location = new System.Drawing.Point(814, 285);
            this.lblNotes[5, 11].Name = "lbl6_11";
            this.lblNotes[5, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 11].TabIndex = 209;
            this.lblNotes[5, 11].Text = "F#";
            // 
            // pb6_11
            // 
            this.pbNotes[5, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 11].Location = new System.Drawing.Point(810, 277);
            this.pbNotes[5, 11].Name = "pb6_11";
            this.pbNotes[5, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 11].TabIndex = 208;
            this.pbNotes[5, 11].TabStop = false;
            // 
            // lbl5_11
            // 
            this.lblNotes[4, 11].AutoSize = true;
            this.lblNotes[4, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 11].Location = new System.Drawing.Point(814, 252);
            this.lblNotes[4, 11].Name = "lbl5_11";
            this.lblNotes[4, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 11].TabIndex = 207;
            this.lblNotes[4, 11].Text = "F#";
            // 
            // pb5_11
            // 
            this.pbNotes[4, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 11].Location = new System.Drawing.Point(810, 244);
            this.pbNotes[4, 11].Name = "pb5_11";
            this.pbNotes[4, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 11].TabIndex = 206;
            this.pbNotes[4, 11].TabStop = false;
            // 
            // lbl4_11
            // 
            this.lblNotes[3, 11].AutoSize = true;
            this.lblNotes[3, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 11].Location = new System.Drawing.Point(814, 217);
            this.lblNotes[3, 11].Name = "lbl4_11";
            this.lblNotes[3, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 11].TabIndex = 205;
            this.lblNotes[3, 11].Text = "F#";
            // 
            // pb4_11
            // 
            this.pbNotes[3, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 11].Location = new System.Drawing.Point(810, 209);
            this.pbNotes[3, 11].Name = "pb4_11";
            this.pbNotes[3, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 11].TabIndex = 204;
            this.pbNotes[3, 11].TabStop = false;
            // 
            // lbl3_11
            // 
            this.lblNotes[2, 11].AutoSize = true;
            this.lblNotes[2, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 11].Location = new System.Drawing.Point(814, 181);
            this.lblNotes[2, 11].Name = "lbl3_11";
            this.lblNotes[2, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 11].TabIndex = 203;
            this.lblNotes[2, 11].Text = "F#";
            // 
            // pb3_11
            // 
            this.pbNotes[2, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 11].Location = new System.Drawing.Point(810, 173);
            this.pbNotes[2, 11].Name = "pb3_11";
            this.pbNotes[2, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 11].TabIndex = 202;
            this.pbNotes[2, 11].TabStop = false;
            // 
            // lbl2_11
            // 
            this.lblNotes[1, 11].AutoSize = true;
            this.lblNotes[1, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 11].Location = new System.Drawing.Point(814, 146);
            this.lblNotes[1, 11].Name = "lbl2_11";
            this.lblNotes[1, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 11].TabIndex = 201;
            this.lblNotes[1, 11].Text = "F#";
            // 
            // pb2_11
            // 
            this.pbNotes[1, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 11].Location = new System.Drawing.Point(810, 138);
            this.pbNotes[1, 11].Name = "pb2_11";
            this.pbNotes[1, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 11].TabIndex = 200;
            this.pbNotes[1, 11].TabStop = false;
            // 
            // lbl1_11
            // 
            this.lblNotes[0, 11].AutoSize = true;
            this.lblNotes[0, 11].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 11].Location = new System.Drawing.Point(814, 109);
            this.lblNotes[0, 11].Name = "lbl1_11";
            this.lblNotes[0, 11].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 11].TabIndex = 199;
            this.lblNotes[0, 11].Text = "F#";
            // 
            // pb1_11
            // 
            this.pbNotes[0, 11].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 11].Location = new System.Drawing.Point(810, 101);
            this.pbNotes[0, 11].Name = "pb1_11";
            this.pbNotes[0, 11].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 11].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 11].TabIndex = 198;
            this.pbNotes[0, 11].TabStop = false;
            // 
            // lbl6_12
            // 
            this.lblNotes[5, 12].AutoSize = true;
            this.lblNotes[5, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 12].Location = new System.Drawing.Point(880, 285);
            this.lblNotes[5, 12].Name = "lbl6_12";
            this.lblNotes[5, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 12].TabIndex = 221;
            this.lblNotes[5, 12].Text = "F#";
            // 
            // pb6_12
            // 
            this.pbNotes[5, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 12].Location = new System.Drawing.Point(876, 277);
            this.pbNotes[5, 12].Name = "pb6_12";
            this.pbNotes[5, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 12].TabIndex = 220;
            this.pbNotes[5, 12].TabStop = false;
            // 
            // lbl5_12
            // 
            this.lblNotes[4, 12].AutoSize = true;
            this.lblNotes[4, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 12].Location = new System.Drawing.Point(880, 252);
            this.lblNotes[4, 12].Name = "lbl5_12";
            this.lblNotes[4, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 12].TabIndex = 219;
            this.lblNotes[4, 12].Text = "F#";
            // 
            // pb5_12
            // 
            this.pbNotes[4, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 12].Location = new System.Drawing.Point(876, 244);
            this.pbNotes[4, 12].Name = "pb5_12";
            this.pbNotes[4, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 12].TabIndex = 218;
            this.pbNotes[4, 12].TabStop = false;
            // 
            // lbl4_12
            // 
            this.lblNotes[3, 12].AutoSize = true;
            this.lblNotes[3, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 12].Location = new System.Drawing.Point(880, 217);
            this.lblNotes[3, 12].Name = "lbl4_12";
            this.lblNotes[3, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 12].TabIndex = 217;
            this.lblNotes[3, 12].Text = "F#";
            // 
            // pb4_12
            // 
            this.pbNotes[3, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 12].Location = new System.Drawing.Point(876, 209);
            this.pbNotes[3, 12].Name = "pb4_12";
            this.pbNotes[3, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 12].TabIndex = 216;
            this.pbNotes[3, 12].TabStop = false;
            // 
            // lbl3_12
            // 
            this.lblNotes[2, 12].AutoSize = true;
            this.lblNotes[2, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 12].Location = new System.Drawing.Point(880, 181);
            this.lblNotes[2, 12].Name = "lbl3_12";
            this.lblNotes[2, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 12].TabIndex = 215;
            this.lblNotes[2, 12].Text = "F#";
            // 
            // pb3_12
            // 
            this.pbNotes[2, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 12].Location = new System.Drawing.Point(876, 173);
            this.pbNotes[2, 12].Name = "pb3_12";
            this.pbNotes[2, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 12].TabIndex = 214;
            this.pbNotes[2, 12].TabStop = false;
            // 
            // lbl2_12
            // 
            this.lblNotes[1, 12].AutoSize = true;
            this.lblNotes[1, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 12].Location = new System.Drawing.Point(880, 146);
            this.lblNotes[1, 12].Name = "lbl2_12";
            this.lblNotes[1, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 12].TabIndex = 213;
            this.lblNotes[1, 12].Text = "F#";
            // 
            // pb2_12
            // 
            this.pbNotes[1, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 12].Location = new System.Drawing.Point(876, 138);
            this.pbNotes[1, 12].Name = "pb2_12";
            this.pbNotes[1, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 12].TabIndex = 212;
            this.pbNotes[1, 12].TabStop = false;
            // 
            // lbl1_12
            // 
            this.lblNotes[0, 12].AutoSize = true;
            this.lblNotes[0, 12].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 12].Location = new System.Drawing.Point(880, 109);
            this.lblNotes[0, 12].Name = "lbl1_12";
            this.lblNotes[0, 12].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 12].TabIndex = 211;
            this.lblNotes[0, 12].Text = "F#";
            // 
            // pb1_12
            // 
            this.pbNotes[0, 12].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 12].Location = new System.Drawing.Point(876, 101);
            this.pbNotes[0, 12].Name = "pb1_12";
            this.pbNotes[0, 12].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 12].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 12].TabIndex = 210;
            this.pbNotes[0, 12].TabStop = false;
            // 
            // lbl6_0
            // 
            this.lblNotes[5, 0].AutoSize = true;
            this.lblNotes[5, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[5, 0].Location = new System.Drawing.Point(21, 285);
            this.lblNotes[5, 0].Name = "lbl6_0";
            this.lblNotes[5, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[5, 0].TabIndex = 233;
            this.lblNotes[5, 0].Text = "F#";
            // 
            // pb6_0
            // 
            this.pbNotes[5, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[5, 0].Location = new System.Drawing.Point(17, 277);
            this.pbNotes[5, 0].Name = "pb6_0";
            this.pbNotes[5, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[5, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[5, 0].TabIndex = 232;
            this.pbNotes[5, 0].TabStop = false;
            // 
            // lbl5_0
            // 
            this.lblNotes[4, 0].AutoSize = true;
            this.lblNotes[4, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[4, 0].Location = new System.Drawing.Point(21, 252);
            this.lblNotes[4, 0].Name = "lbl5_0";
            this.lblNotes[4, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[4, 0].TabIndex = 231;
            this.lblNotes[4, 0].Text = "F#";
            // 
            // pb5_0
            // 
            this.pbNotes[4, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[4, 0].Location = new System.Drawing.Point(17, 244);
            this.pbNotes[4, 0].Name = "pb5_0";
            this.pbNotes[4, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[4, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[4, 0].TabIndex = 230;
            this.pbNotes[4, 0].TabStop = false;
            // 
            // lbl4_0
            // 
            this.lblNotes[3, 0].AutoSize = true;
            this.lblNotes[3, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[3, 0].Location = new System.Drawing.Point(21, 217);
            this.lblNotes[3, 0].Name = "lbl4_0";
            this.lblNotes[3, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[3, 0].TabIndex = 229;
            this.lblNotes[3, 0].Text = "F#";
            // 
            // pb4_0
            // 
            this.pbNotes[3, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[3, 0].Location = new System.Drawing.Point(17, 209);
            this.pbNotes[3, 0].Name = "pb4_0";
            this.pbNotes[3, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[3, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[3, 0].TabIndex = 228;
            this.pbNotes[3, 0].TabStop = false;
            // 
            // lbl3_0
            // 
            this.lblNotes[2, 0].AutoSize = true;
            this.lblNotes[2, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[2, 0].Location = new System.Drawing.Point(21, 181);
            this.lblNotes[2, 0].Name = "lbl3_0";
            this.lblNotes[2, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[2, 0].TabIndex = 227;
            this.lblNotes[2, 0].Text = "F#";
            // 
            // pb3_0
            // 
            this.pbNotes[2, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[2, 0].Location = new System.Drawing.Point(17, 173);
            this.pbNotes[2, 0].Name = "pb3_0";
            this.pbNotes[2, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[2, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[2, 0].TabIndex = 226;
            this.pbNotes[2, 0].TabStop = false;
            // 
            // lbl2_0
            // 
            this.lblNotes[1, 0].AutoSize = true;
            this.lblNotes[1, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[1, 0].Location = new System.Drawing.Point(21, 146);
            this.lblNotes[1, 0].Name = "lbl2_0";
            this.lblNotes[1, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[1, 0].TabIndex = 225;
            this.lblNotes[1, 0].Text = "F#";
            // 
            // pb2_0
            // 
            this.pbNotes[1, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[1, 0].Location = new System.Drawing.Point(17, 138);
            this.pbNotes[1, 0].Name = "pb2_0";
            this.pbNotes[1, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[1, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[1, 0].TabIndex = 224;
            this.pbNotes[1, 0].TabStop = false;
            // 
            // lbl1_0
            // 
            this.lblNotes[0, 0].AutoSize = true;
            this.lblNotes[0, 0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(170)))), ((int)(((byte)(205)))));
            this.lblNotes[0, 0].Location = new System.Drawing.Point(21, 109);
            this.lblNotes[0, 0].Name = "lbl1_0";
            this.lblNotes[0, 0].Size = new System.Drawing.Size(20, 13);
            this.lblNotes[0, 0].TabIndex = 223;
            this.lblNotes[0, 0].Text = "F#";
            // 
            // pb1_0
            // 
            this.pbNotes[0, 0].Image = global::TMI_Project.Properties.Resources.Circle__2_;
            this.pbNotes[0, 0].Location = new System.Drawing.Point(17, 101);
            this.pbNotes[0, 0].Name = "pb1_0";
            this.pbNotes[0, 0].Size = new System.Drawing.Size(29, 29);
            this.pbNotes[0, 0].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNotes[0, 0].TabIndex = 222;
            this.pbNotes[0, 0].TabStop = false;
            // 
            // MostradorEscalaMusical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 450);
            for (int i = 0; i < lblNotes.GetLength(0); i++)
            {
                for (int j = 0; j < lblNotes.GetLength(1); j++)
                {
                    this.Controls.Add(this.lblNotes[i, j]);
                    this.Controls.Add(this.pbNotes[i, j]);
                }
            }

            this.Controls.Add(this.pictureBox1);
            this.Name = "MostradorEscalaMusical";
            this.Text = "MostradorEscalaMusical";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 1])).EndInit();
            // String 1
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[0, 12])).EndInit();
            // String 2
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[1, 12])).EndInit();
            // String 3
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[2, 12])).EndInit();
            // String 4
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[3, 12])).EndInit();
            // String 5
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[4, 12])).EndInit();
            // String 6
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 0])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 1])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 2])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 3])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 4])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 5])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 6])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 7])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 8])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 10])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 11])).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotes[5, 12])).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        
    }
}