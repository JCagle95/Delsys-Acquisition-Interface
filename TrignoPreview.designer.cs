namespace DelsysAcquisitionInterface
{
    partial class TrignoPreview
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SensorSelection = new System.Windows.Forms.ComboBox();
            this.AmplitudeControl = new System.Windows.Forms.VScrollBar();
            this.ChangeTime_10 = new System.Windows.Forms.Button();
            this.ChangeTime_5 = new System.Windows.Forms.Button();
            this.ChangeTime_2 = new System.Windows.Forms.Button();
            this.ChangeTime_1 = new System.Windows.Forms.Button();
            this.SelectSensorType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // DataChart
            // 
            this.DataChart.BackColor = System.Drawing.Color.Transparent;
            this.DataChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DataChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.DataChart.BorderlineWidth = 5;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Interval = 0.5D;
            chartArea3.AxisY.MajorGrid.Interval = 0.5D;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Maximum = 0.5D;
            chartArea3.AxisY.Minimum = -0.5D;
            chartArea3.AxisY.Title = "Amplitude";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chartArea3.Name = "DataChartConfiguration";
            this.DataChart.ChartAreas.Add(chartArea3);
            this.DataChart.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DataChart.Location = new System.Drawing.Point(12, 12);
            this.DataChart.Name = "DataChart";
            this.DataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "DataChartConfiguration";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Font = new System.Drawing.Font("Ubuntu Condensed", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Name = "EMGSeries";
            this.DataChart.Series.Add(series3);
            this.DataChart.Size = new System.Drawing.Size(1839, 598);
            this.DataChart.TabIndex = 0;
            this.DataChart.Text = "Delsys Chart";
            title3.Font = new System.Drawing.Font("Meiryo UI", 15F);
            title3.Name = "Title1";
            title3.Text = "Delsys Visualization";
            this.DataChart.Titles.Add(title3);
            // 
            // SensorSelection
            // 
            this.SensorSelection.Font = new System.Drawing.Font("Ubuntu Mono", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SensorSelection.FormattingEnabled = true;
            this.SensorSelection.Location = new System.Drawing.Point(1530, 42);
            this.SensorSelection.Name = "SensorSelection";
            this.SensorSelection.Size = new System.Drawing.Size(255, 48);
            this.SensorSelection.TabIndex = 1;
            this.SensorSelection.SelectedIndexChanged += new System.EventHandler(this.SensorSelection_SelectedIndexChanged);
            // 
            // AmplitudeControl
            // 
            this.AmplitudeControl.LargeChange = 1;
            this.AmplitudeControl.Location = new System.Drawing.Point(1870, 30);
            this.AmplitudeControl.Maximum = 10;
            this.AmplitudeControl.Name = "AmplitudeControl";
            this.AmplitudeControl.Size = new System.Drawing.Size(20, 650);
            this.AmplitudeControl.TabIndex = 2;
            this.AmplitudeControl.ValueChanged += new System.EventHandler(this.AmplitudeControl_ValueChanged);
            // 
            // ChangeTime_10
            // 
            this.ChangeTime_10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeTime_10.Location = new System.Drawing.Point(13, 641);
            this.ChangeTime_10.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTime_10.Name = "ChangeTime_10";
            this.ChangeTime_10.Size = new System.Drawing.Size(390, 73);
            this.ChangeTime_10.TabIndex = 21;
            this.ChangeTime_10.Text = "10 Seconds";
            this.ChangeTime_10.UseVisualStyleBackColor = true;
            this.ChangeTime_10.Click += new System.EventHandler(this.ChangeTime_10_Click);
            // 
            // ChangeTime_5
            // 
            this.ChangeTime_5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeTime_5.Location = new System.Drawing.Point(499, 641);
            this.ChangeTime_5.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTime_5.Name = "ChangeTime_5";
            this.ChangeTime_5.Size = new System.Drawing.Size(390, 73);
            this.ChangeTime_5.TabIndex = 22;
            this.ChangeTime_5.Text = "5 Seconds";
            this.ChangeTime_5.UseVisualStyleBackColor = true;
            this.ChangeTime_5.Click += new System.EventHandler(this.ChangeTime_5_Click);
            // 
            // ChangeTime_2
            // 
            this.ChangeTime_2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeTime_2.Location = new System.Drawing.Point(991, 641);
            this.ChangeTime_2.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTime_2.Name = "ChangeTime_2";
            this.ChangeTime_2.Size = new System.Drawing.Size(390, 73);
            this.ChangeTime_2.TabIndex = 23;
            this.ChangeTime_2.Text = "2 Seconds";
            this.ChangeTime_2.UseVisualStyleBackColor = true;
            this.ChangeTime_2.Click += new System.EventHandler(this.ChangeTime_2_Click);
            // 
            // ChangeTime_1
            // 
            this.ChangeTime_1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.ChangeTime_1.Location = new System.Drawing.Point(1473, 641);
            this.ChangeTime_1.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTime_1.Name = "ChangeTime_1";
            this.ChangeTime_1.Size = new System.Drawing.Size(390, 73);
            this.ChangeTime_1.TabIndex = 24;
            this.ChangeTime_1.Text = "1 Seconds";
            this.ChangeTime_1.UseVisualStyleBackColor = true;
            this.ChangeTime_1.Click += new System.EventHandler(this.ChangeTime_1_Click);
            // 
            // SelectSensorType
            // 
            this.SelectSensorType.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSensorType.FormattingEnabled = true;
            this.SelectSensorType.Items.AddRange(new object[] {
            "EMG (Filtered)",
            "Accelerometer"});
            this.SelectSensorType.Location = new System.Drawing.Point(63, 42);
            this.SelectSensorType.Name = "SelectSensorType";
            this.SelectSensorType.Size = new System.Drawing.Size(391, 40);
            this.SelectSensorType.TabIndex = 25;
            this.SelectSensorType.SelectedIndexChanged += new System.EventHandler(this.SelectSensorType_SelectedIndexChanged);
            // 
            // TrignoPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1991, 743);
            this.Controls.Add(this.SelectSensorType);
            this.Controls.Add(this.ChangeTime_1);
            this.Controls.Add(this.ChangeTime_2);
            this.Controls.Add(this.ChangeTime_5);
            this.Controls.Add(this.ChangeTime_10);
            this.Controls.Add(this.AmplitudeControl);
            this.Controls.Add(this.SensorSelection);
            this.Controls.Add(this.DataChart);
            this.Name = "TrignoPreview";
            this.Text = "TrignoPreview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrignoPreview_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private System.Windows.Forms.ComboBox SensorSelection;
        private System.Windows.Forms.VScrollBar AmplitudeControl;
        private System.Windows.Forms.Button ChangeTime_10;
        private System.Windows.Forms.Button ChangeTime_5;
        private System.Windows.Forms.Button ChangeTime_2;
        private System.Windows.Forms.Button ChangeTime_1;
        private System.Windows.Forms.ComboBox SelectSensorType;
    }
}