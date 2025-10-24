namespace Topic_9_11___GUI_assignment_2
{
    partial class FormTemperatureGauge
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
            this.imgTempGuy = new System.Windows.Forms.PictureBox();
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMiddle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblTempGuyStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTempGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTempGuy
            // 
            this.imgTempGuy.BackColor = System.Drawing.Color.Transparent;
            this.imgTempGuy.Image = global::Topic_9_11___GUI_assignment_2.Properties.Resources.Temperature_guy;
            this.imgTempGuy.Location = new System.Drawing.Point(527, 12);
            this.imgTempGuy.Name = "imgTempGuy";
            this.imgTempGuy.Size = new System.Drawing.Size(330, 586);
            this.imgTempGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTempGuy.TabIndex = 0;
            this.imgTempGuy.TabStop = false;
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.BackColor = System.Drawing.Color.GhostWhite;
            this.trackBarTemperature.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.trackBarTemperature.Location = new System.Drawing.Point(465, 12);
            this.trackBarTemperature.Maximum = 100;
            this.trackBarTemperature.Minimum = -100;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemperature.Size = new System.Drawing.Size(56, 586);
            this.trackBarTemperature.TabIndex = 1;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.ForeColor = System.Drawing.Color.Red;
            this.lblMax.Location = new System.Drawing.Point(380, 12);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(69, 26);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "100°C";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMin.Location = new System.Drawing.Point(372, 572);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(77, 26);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "-100°C";
            // 
            // lblMiddle
            // 
            this.lblMiddle.AutoSize = true;
            this.lblMiddle.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddle.ForeColor = System.Drawing.Color.Black;
            this.lblMiddle.Location = new System.Drawing.Point(412, 293);
            this.lblMiddle.Name = "lblMiddle";
            this.lblMiddle.Size = new System.Drawing.Size(47, 26);
            this.lblMiddle.TabIndex = 4;
            this.lblMiddle.Text = "0°C";
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(19, 12);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(329, 225);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Select a temperature using the slider";
            // 
            // lblTempGuyStatus
            // 
            this.lblTempGuyStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblTempGuyStatus.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempGuyStatus.Location = new System.Drawing.Point(19, 451);
            this.lblTempGuyStatus.Name = "lblTempGuyStatus";
            this.lblTempGuyStatus.Size = new System.Drawing.Size(329, 147);
            this.lblTempGuyStatus.TabIndex = 6;
            this.lblTempGuyStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FormTemperatureGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 610);
            this.Controls.Add(this.lblTempGuyStatus);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblMiddle);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.imgTempGuy);
            this.Name = "FormTemperatureGauge";
            this.Text = "Temperature Gauge";
            ((System.ComponentModel.ISupportInitialize)(this.imgTempGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgTempGuy;
        private System.Windows.Forms.TrackBar trackBarTemperature;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMiddle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblTempGuyStatus;
    }
}

