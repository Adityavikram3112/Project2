
namespace Project2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Citylabel = new System.Windows.Forms.Label();
            this.TempMaxlabel = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.TempMinlabel = new System.Windows.Forms.Label();
            this.WindSpeedlabel = new System.Windows.Forms.Label();
            this.TempMaxText = new System.Windows.Forms.TextBox();
            this.TempMinText = new System.Windows.Forms.TextBox();
            this.WindSpeedText = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Location = new System.Drawing.Point(65, 126);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(24, 13);
            this.Citylabel.TabIndex = 0;
            this.Citylabel.Text = "City";
            // 
            // TempMaxlabel
            // 
            this.TempMaxlabel.AutoSize = true;
            this.TempMaxlabel.Location = new System.Drawing.Point(36, 263);
            this.TempMaxlabel.Name = "TempMaxlabel";
            this.TempMaxlabel.Size = new System.Drawing.Size(57, 13);
            this.TempMaxlabel.TabIndex = 1;
            this.TempMaxlabel.Text = "Temp Max";
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(68, 38);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(75, 23);
            this.Startbutton.TabIndex = 2;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(149, 38);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(75, 23);
            this.Stopbutton.TabIndex = 3;
            this.Stopbutton.Text = "STOP";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // TempMinlabel
            // 
            this.TempMinlabel.AutoSize = true;
            this.TempMinlabel.Location = new System.Drawing.Point(39, 291);
            this.TempMinlabel.Name = "TempMinlabel";
            this.TempMinlabel.Size = new System.Drawing.Size(54, 13);
            this.TempMinlabel.TabIndex = 4;
            this.TempMinlabel.Text = "Temp Min";
            // 
            // WindSpeedlabel
            // 
            this.WindSpeedlabel.AutoSize = true;
            this.WindSpeedlabel.Location = new System.Drawing.Point(26, 319);
            this.WindSpeedlabel.Name = "WindSpeedlabel";
            this.WindSpeedlabel.Size = new System.Drawing.Size(67, 13);
            this.WindSpeedlabel.TabIndex = 5;
            this.WindSpeedlabel.Text = "WInd Speed";
            // 
            // TempMaxText
            // 
            this.TempMaxText.Location = new System.Drawing.Point(99, 256);
            this.TempMaxText.Name = "TempMaxText";
            this.TempMaxText.Size = new System.Drawing.Size(125, 20);
            this.TempMaxText.TabIndex = 6;
            // 
            // TempMinText
            // 
            this.TempMinText.Location = new System.Drawing.Point(99, 288);
            this.TempMinText.Name = "TempMinText";
            this.TempMinText.Size = new System.Drawing.Size(125, 20);
            this.TempMinText.TabIndex = 7;
            // 
            // WindSpeedText
            // 
            this.WindSpeedText.Location = new System.Drawing.Point(99, 316);
            this.WindSpeedText.Name = "WindSpeedText";
            this.WindSpeedText.Size = new System.Drawing.Size(125, 20);
            this.WindSpeedText.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(317, 28);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "TempMax";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "TempMin";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "WindSpeed";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "CurencyChange";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(704, 541);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(99, 119);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(125, 20);
            this.CityTextBox.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 581);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.WindSpeedText);
            this.Controls.Add(this.TempMinText);
            this.Controls.Add(this.TempMaxText);
            this.Controls.Add(this.WindSpeedlabel);
            this.Controls.Add(this.TempMinlabel);
            this.Controls.Add(this.Stopbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.TempMaxlabel);
            this.Controls.Add(this.Citylabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label TempMaxlabel;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Label TempMinlabel;
        private System.Windows.Forms.Label WindSpeedlabel;
        private System.Windows.Forms.TextBox TempMaxText;
        private System.Windows.Forms.TextBox TempMinText;
        private System.Windows.Forms.TextBox WindSpeedText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

