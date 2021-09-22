
namespace DelsysAcquisitionInterface
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Delsys_Connect_Btn = new System.Windows.Forms.Button();
            this.Delsys_UpdateSensor_Btn = new System.Windows.Forms.Button();
            this.Delsys_StartAcquisition_Btn = new System.Windows.Forms.Button();
            this.RecordingDuration_Label = new System.Windows.Forms.Label();
            this.Delsys_ViewSignal_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delsys_Connect_Btn
            // 
            this.Delsys_Connect_Btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Delsys_Connect_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delsys_Connect_Btn.Location = new System.Drawing.Point(49, 49);
            this.Delsys_Connect_Btn.Name = "Delsys_Connect_Btn";
            this.Delsys_Connect_Btn.Size = new System.Drawing.Size(472, 103);
            this.Delsys_Connect_Btn.TabIndex = 0;
            this.Delsys_Connect_Btn.Text = "Connect Delsys Base";
            this.Delsys_Connect_Btn.UseVisualStyleBackColor = true;
            this.Delsys_Connect_Btn.Click += new System.EventHandler(this.Delsys_Connect_Btn_Click);
            // 
            // Delsys_UpdateSensor_Btn
            // 
            this.Delsys_UpdateSensor_Btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Delsys_UpdateSensor_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delsys_UpdateSensor_Btn.Location = new System.Drawing.Point(637, 49);
            this.Delsys_UpdateSensor_Btn.Name = "Delsys_UpdateSensor_Btn";
            this.Delsys_UpdateSensor_Btn.Size = new System.Drawing.Size(472, 103);
            this.Delsys_UpdateSensor_Btn.TabIndex = 1;
            this.Delsys_UpdateSensor_Btn.Text = "Update Trigno Sensors";
            this.Delsys_UpdateSensor_Btn.UseVisualStyleBackColor = true;
            this.Delsys_UpdateSensor_Btn.Click += new System.EventHandler(this.Delsys_UpdateSensor_Btn_Click);
            // 
            // Delsys_StartAcquisition_Btn
            // 
            this.Delsys_StartAcquisition_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delsys_StartAcquisition_Btn.Location = new System.Drawing.Point(637, 221);
            this.Delsys_StartAcquisition_Btn.Name = "Delsys_StartAcquisition_Btn";
            this.Delsys_StartAcquisition_Btn.Size = new System.Drawing.Size(472, 103);
            this.Delsys_StartAcquisition_Btn.TabIndex = 2;
            this.Delsys_StartAcquisition_Btn.Text = "Start Acquisition";
            this.Delsys_StartAcquisition_Btn.UseVisualStyleBackColor = true;
            this.Delsys_StartAcquisition_Btn.Click += new System.EventHandler(this.Delsys_StartAcquisition_Btn_Click);
            // 
            // RecordingDuration_Label
            // 
            this.RecordingDuration_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordingDuration_Label.Location = new System.Drawing.Point(637, 388);
            this.RecordingDuration_Label.Name = "RecordingDuration_Label";
            this.RecordingDuration_Label.Size = new System.Drawing.Size(472, 81);
            this.RecordingDuration_Label.TabIndex = 3;
            this.RecordingDuration_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delsys_ViewSignal_Btn
            // 
            this.Delsys_ViewSignal_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Delsys_ViewSignal_Btn.Location = new System.Drawing.Point(637, 571);
            this.Delsys_ViewSignal_Btn.Name = "Delsys_ViewSignal_Btn";
            this.Delsys_ViewSignal_Btn.Size = new System.Drawing.Size(472, 103);
            this.Delsys_ViewSignal_Btn.TabIndex = 4;
            this.Delsys_ViewSignal_Btn.Text = "View Signals";
            this.Delsys_ViewSignal_Btn.UseVisualStyleBackColor = true;
            this.Delsys_ViewSignal_Btn.Click += new System.EventHandler(this.Delsys_ViewSignal_Btn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 749);
            this.Controls.Add(this.Delsys_ViewSignal_Btn);
            this.Controls.Add(this.RecordingDuration_Label);
            this.Controls.Add(this.Delsys_StartAcquisition_Btn);
            this.Controls.Add(this.Delsys_UpdateSensor_Btn);
            this.Controls.Add(this.Delsys_Connect_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Delsys Acquisition Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delsys_Connect_Btn;
        private System.Windows.Forms.Button Delsys_UpdateSensor_Btn;
        private System.Windows.Forms.Button Delsys_StartAcquisition_Btn;
        private System.Windows.Forms.Label RecordingDuration_Label;
        private System.Windows.Forms.Button Delsys_ViewSignal_Btn;
    }
}

