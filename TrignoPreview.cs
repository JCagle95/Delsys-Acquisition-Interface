using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DelsysAcquisitionInterface
{
    public partial class TrignoPreview : Form
    {
        private System.Windows.Forms.Timer RefreshTimer;
        public Trigno trignoServer;
        public Thread displayThread = null;

        public List<int> IDs = new List<int>();
        public int id = 0;
        public int TimeLength = 2;
        public int FS = 1111;
        public float[] visualizedData;
        public int sensorType = 0;

        public delegate void SafeUpdatePreview(float[] data);

        public double[] AmplitudeRangeArray = new double[] { 0.0000001, 0.000001, 0.00001, 0.0001, 0.001, 0.01, 0.1, 1, 2, 5, 10, 20, 30 };

        public TrignoPreview(Trigno server)
        {
            InitializeComponent();
            trignoServer = server;
            SelectSensorType.SelectedIndex = 0;
            AmplitudeControl.Maximum = AmplitudeRangeArray.Length-1;

            //double amplitudeLimit = Math.Pow(10.0, (AmplitudeControl.Maximum - (double)AmplitudeControl.Value + AmplitudeControl.Minimum) / 100.0);
            double amplitudeLimit = AmplitudeRangeArray[AmplitudeControl.Value];
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Interval = amplitudeLimit / 2;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.MajorGrid.Interval = amplitudeLimit / 2;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.MajorTickMark.Enabled = false;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Maximum = amplitudeLimit;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Minimum = -amplitudeLimit;

            int i = 0;
            foreach (bool item in trignoServer.sensorStatus)
            {
                if (item)
                {
                    this.SensorSelection.Items.Add(String.Format("Sensor {0:00}", i + 1));
                    IDs.Add(i);
                }
                i++;
            }
            id = IDs[0];
            this.SensorSelection.SelectedIndex = 0;

            // Initialize Display Thread
            RefreshTimer = new System.Windows.Forms.Timer();
            RefreshTimer.Interval = 100;
            RefreshTimer.Tick += new EventHandler(RefreshDisplay);
            RefreshTimer.Start();
        }
        
        public void UpdateData(float[] data)
        {
            if (this.DataChart.InvokeRequired)
            {
                var d = new SafeUpdatePreview(UpdateData);
                Invoke(d, new object[] { data });
            }
            else
            {
                DataChart.Series["EMGSeries"].Points.DataBindY(visualizedData);
            }
        }

        private void RefreshDisplay(object sender, EventArgs e)
        {
            if (sensorType == 0)
            {
                if (trignoServer != null) visualizedData = trignoServer.PreviewData(id, FS * TimeLength);
            }
            else
            {
                if (trignoServer != null) visualizedData = trignoServer.PreviewIMUData(id, FS * TimeLength);
            }
            UpdateData(visualizedData);
        }

        private void TrignoPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            RefreshTimer.Stop();
        }

        private void SensorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = IDs[this.SensorSelection.SelectedIndex];
        }

        private void AmplitudeControl_ValueChanged(object sender, EventArgs e)
        {
            //double amplitudeLimit = Math.Pow(10.0, (AmplitudeControl.Maximum - (double)AmplitudeControl.Value + AmplitudeControl.Minimum) /100.0);
            double amplitudeLimit = AmplitudeRangeArray[AmplitudeControl.Value];
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Interval = amplitudeLimit / 2;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.MajorGrid.Interval = amplitudeLimit / 2;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.MajorTickMark.Enabled = false;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Maximum = amplitudeLimit;
            DataChart.ChartAreas["DataChartConfiguration"].AxisY.Minimum = -amplitudeLimit;
        }

        private void ChangeTime_10_Click(object sender, EventArgs e)
        {
            TimeLength = 10;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 2 * FS;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 2, "2 seconds", 1, LabelMarkStyle.LineSideMark));
        }

        private void ChangeTime_5_Click(object sender, EventArgs e)
        {
            TimeLength = 5;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 1 * FS;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 1, "1 second", 1, LabelMarkStyle.LineSideMark));
        }

        private void ChangeTime_2_Click(object sender, EventArgs e)
        {
            TimeLength = 2;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 1 * FS;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 1, "1 second", 1, LabelMarkStyle.LineSideMark));

        }

        private void ChangeTime_1_Click(object sender, EventArgs e)
        {
            TimeLength = 1;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 0.2 * FS;
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
            DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 0.2, "200 milliseconds", 1, LabelMarkStyle.LineSideMark));

        }

        private void SelectSensorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectSensorType.SelectedIndex == 0)
            {
                if (RefreshTimer != null) RefreshTimer.Stop();
                sensorType = 0;
                FS = 1111;
                TimeLength = 1;
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 0.2 * FS;
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 0.2, "200 milliseconds", 1, LabelMarkStyle.LineSideMark));
                if (RefreshTimer != null) RefreshTimer.Start();
            }
            else
            {
                if (RefreshTimer != null) RefreshTimer.Stop();
                sensorType = 1;
                FS = 156;
                TimeLength = 1;
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.MajorGrid.Interval = 0.2 * FS;
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Clear();
                DataChart.ChartAreas["DataChartConfiguration"].AxisX.CustomLabels.Add(new CustomLabel(0, FS * 0.2, "200 milliseconds", 1, LabelMarkStyle.LineSideMark));
                if (RefreshTimer != null) RefreshTimer.Start();
            }
        }
    }
}
