using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace DelsysAcquisitionInterface
{
    public partial class MainWindow : Form
    {
        private Trigno TrignoServer;

        private System.Timers.Timer AcquisitionTimer;
        private Stopwatch durationWatch = new Stopwatch();
        public delegate void SafeCallDelegateString(string text);

        private CheckBox[] SensorStatusDisplay;

        public MainWindow()
        {
            InitializeComponent();
            Delsys_UpdateSensor_Btn.Enabled = false;
            Delsys_StartAcquisition_Btn.Enabled = false;
            Delsys_ViewSignal_Btn.Enabled = false;

            int LeftEdge = this.Delsys_Connect_Btn.Location.X + 10;
            int Width = this.Delsys_Connect_Btn.Size.Width / 2;
            int Height = this.Delsys_Connect_Btn.Size.Height / 2;

            SensorStatusDisplay = new CheckBox[16];
            for (int i = 0; i < 8; i++)
            {
                SensorStatusDisplay[i] = new CheckBox();
                SensorStatusDisplay[i].Location = new Point(LeftEdge, 100 + Height * i);
                SensorStatusDisplay[i].Size = new Size(Width, Height);
                SensorStatusDisplay[i].Text = String.Format("Sensor #{0:00}", i+1);
                SensorStatusDisplay[i].Enabled = false;
                this.Controls.Add(SensorStatusDisplay[i]);
            }

            for (int i = 8; i < 16; i++)
            {
                SensorStatusDisplay[i] = new CheckBox();
                SensorStatusDisplay[i].Location = new Point(LeftEdge + Width, 100 + Height * (i-8));
                SensorStatusDisplay[i].Size = new Size(Width, Height);
                SensorStatusDisplay[i].Text = String.Format("Sensor #{0:00}", i+1);
                SensorStatusDisplay[i].Enabled = false;
                this.Controls.Add(SensorStatusDisplay[i]);
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TrignoServer != null)
            {
                if (TrignoServer.connected)
                {
                    if (TrignoServer.status)
                    {
                        AcquisitionTimer.Stop();
                        var window = MessageBox.Show(
                            "Delsys is still running, do you want to close it?",
                            "Closing Window",
                            MessageBoxButtons.YesNo);

                        if (window == DialogResult.No)
                        {
                            e.Cancel = true;
                            AcquisitionTimer.Start();
                        }
                        else
                        {
                            TrignoServer.StopAcquisition();
                        }
                    }
                }
            }
        }

        private void Delsys_Connect_Btn_Click(object sender, EventArgs e)
        {
            TrignoServer = new Trigno();
            TrignoServer.SetupServer();

            if (TrignoServer.connected)
            {
                this.Delsys_Connect_Btn.Enabled = false;
                this.Delsys_StartAcquisition_Btn.Enabled = true;
                this.Delsys_UpdateSensor_Btn.Enabled = true;
                this.Delsys_ViewSignal_Btn.Enabled = false;
                for (int i = 0; i < 16; i++)
                {
                    TrignoServer.sensorStatus[i] = SensorStatusDisplay[i].Checked;
                    SensorStatusDisplay[i].Enabled = true;
                }
            }
        }

        private void Delsys_UpdateSensor_Btn_Click(object sender, EventArgs e)
        {
            TrignoServer.UpdateSensors();
            for (int i = 0; i < 16; i++)
            {
                if (TrignoServer.connectedSensors[i] != Trigno.SensorTypes.NoSensor)
                {
                    SensorStatusDisplay[i].Text = String.Format("Sensor #{0:00} Active", i+1);
                    SensorStatusDisplay[i].Checked = true;
                }
                else
                {
                    SensorStatusDisplay[i].Text = String.Format("Sensor #{0:00}", i + 1);
                    SensorStatusDisplay[i].Checked = false;
                }
                TrignoServer.sensorStatus[i] = TrignoServer.connectedSensors[i] != Trigno.SensorTypes.NoSensor;
            }
        }

        private void Delsys_StartAcquisition_Btn_Click(object sender, EventArgs e)
        {
            if (TrignoServer != null)
            {
                if (TrignoServer.connected)
                {
                    if (!TrignoServer.status)
                    {
                        Delsys_UpdateSensor_Btn.Enabled = false;
                        Delsys_ViewSignal_Btn.Enabled = true;
                        for (int i = 0; i < 16; i++)
                        {
                            TrignoServer.sensorStatus[i] = SensorStatusDisplay[i].Checked;
                            SensorStatusDisplay[i].Enabled = false;
                        }

                        string Filename = DateTime.Now.ToString("[yyyy_MM_dd-HH_mm_ss]") + " DelsysSampling";
                        TrignoServer.storedFileName = Filename + ".mdat";

                        TrignoServer.StartAcquisition();
                        TrignoServer.StartDataWriter();

                        AcquisitionTimer = new System.Timers.Timer();
                        AcquisitionTimer.Interval = 200;
                        AcquisitionTimer.Elapsed += DisplayUpdate;
                        AcquisitionTimer.Start();

                        Delsys_StartAcquisition_Btn.Text = "Stop Acquisition";
                    }
                    else
                    {
                        AcquisitionTimer.Stop();
                        TrignoServer.StopAcquisition();
                        DisplayTextSafe("");

                        Delsys_StartAcquisition_Btn.Text = "Start Acquisition";
                        Delsys_UpdateSensor_Btn.Enabled = true;
                        Delsys_ViewSignal_Btn.Enabled = false;
                        for (int i = 0; i < 16; i++)
                        {
                            TrignoServer.sensorStatus[i] = SensorStatusDisplay[i].Checked;
                            SensorStatusDisplay[i].Enabled = true;
                        }
                    }
                }
            }
        }

        private void DisplayUpdate(object sender, EventArgs e)
        {
            DisplayTextSafe(TrignoServer.stopWatch.Elapsed.ToString("mm\\:ss"));
        }

        private void DisplayTextSafe(String text)
        {
            if (this.RecordingDuration_Label.InvokeRequired)
            {
                var d = new SafeCallDelegateString(DisplayTextSafe);
                Invoke(d, new object[] { text });
            }
            else
            {
                this.RecordingDuration_Label.Text = text;
                this.RecordingDuration_Label.BringToFront();
            }
        }

        private void Delsys_ViewSignal_Btn_Click(object sender, EventArgs e)
        {
            TrignoPreview preview = new TrignoPreview(TrignoServer);
            preview.WindowState = FormWindowState.Normal;
            preview.Show();
        }

    }
}
