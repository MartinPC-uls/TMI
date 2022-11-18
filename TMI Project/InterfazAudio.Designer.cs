namespace TMI_Project
{
    partial class InterfazAudio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialSlider2 = new MaterialSkin.Controls.MaterialSlider();
            this.txtBuffer = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.txtZoomX1 = new System.Windows.Forms.TextBox();
            this.txtZoomX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 2048D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = -1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(39, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(687, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(651, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart2
            // 
            chartArea2.AxisX.Maximum = 100000D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(39, 333);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(687, 300);
            this.chart2.TabIndex = 2;
            this.chart2.Text = "chart2";
            // 
            // chart4
            // 
            chartArea3.AxisX.Maximum = 2048D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.AxisY.Minimum = -1D;
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(732, 12);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(687, 300);
            this.chart4.TabIndex = 4;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            chartArea4.AxisX.Maximum = 1000D;
            chartArea4.AxisX.Minimum = 0D;
            chartArea4.AxisY.Maximum = 3000000D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(732, 333);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(687, 300);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(39, 298);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.RangeMax = 22050;
            this.materialSlider1.RangeMin = 100;
            this.materialSlider1.Size = new System.Drawing.Size(1380, 40);
            this.materialSlider1.TabIndex = 6;
            this.materialSlider1.Text = "X-size";
            this.materialSlider1.Value = 1000;
            this.materialSlider1.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSlider1_onValueChanged);
            this.materialSlider1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSlider1_KeyPress);
            // 
            // materialSlider2
            // 
            this.materialSlider2.Depth = 0;
            this.materialSlider2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider2.Location = new System.Drawing.Point(598, 639);
            this.materialSlider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider2.Name = "materialSlider2";
            this.materialSlider2.RangeMax = 65536;
            this.materialSlider2.RangeMin = 4096;
            this.materialSlider2.Size = new System.Drawing.Size(250, 40);
            this.materialSlider2.TabIndex = 7;
            this.materialSlider2.Text = "bufferSize";
            this.materialSlider2.Value = 4096;
            this.materialSlider2.ValueMax = 65536;
            this.materialSlider2.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.materialSlider2_onValueChanged);
            this.materialSlider2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialSlider2_KeyPress);
            // 
            // txtBuffer
            // 
            this.txtBuffer.Location = new System.Drawing.Point(898, 655);
            this.txtBuffer.Name = "txtBuffer";
            this.txtBuffer.Size = new System.Drawing.Size(100, 20);
            this.txtBuffer.TabIndex = 8;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(1004, 652);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(216, 652);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 10;
            this.btnZoom.Text = "zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // txtZoomX1
            // 
            this.txtZoomX1.Location = new System.Drawing.Point(126, 654);
            this.txtZoomX1.Name = "txtZoomX1";
            this.txtZoomX1.Size = new System.Drawing.Size(30, 20);
            this.txtZoomX1.TabIndex = 11;
            // 
            // txtZoomX2
            // 
            this.txtZoomX2.Location = new System.Drawing.Point(180, 654);
            this.txtZoomX2.Name = "txtZoomX2";
            this.txtZoomX2.Size = new System.Drawing.Size(30, 20);
            this.txtZoomX2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "-";
            // 
            // btnEscala
            // 
            this.btnEscala.Location = new System.Drawing.Point(351, 652);
            this.btnEscala.Name = "btnEscala";
            this.btnEscala.Size = new System.Drawing.Size(75, 23);
            this.btnEscala.TabIndex = 14;
            this.btnEscala.Text = "escala";
            this.btnEscala.UseVisualStyleBackColor = true;
            this.btnEscala.Click += new System.EventHandler(this.btnEscala_Click);
            // 
            // InterfazAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 687);
            this.Controls.Add(this.btnEscala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZoomX2);
            this.Controls.Add(this.txtZoomX1);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtBuffer);
            this.Controls.Add(this.materialSlider2);
            this.Controls.Add(this.materialSlider1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "InterfazAudio";
            this.Text = "InterfazAudio";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;
        private MaterialSkin.Controls.MaterialSlider materialSlider2;
        private System.Windows.Forms.TextBox txtBuffer;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.TextBox txtZoomX1;
        private System.Windows.Forms.TextBox txtZoomX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEscala;
    }
}