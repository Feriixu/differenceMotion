namespace differenceMotion
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.comboBoxModes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxDeviceSettings = new System.Windows.Forms.GroupBox();
            this.groupBoxVideoSettings = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarSensitivity = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxDeviceSettings.SuspendLayout();
            this.groupBoxVideoSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensitivity)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(248, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(6, 35);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(190, 21);
            this.comboBoxDevices.TabIndex = 1;
            // 
            // comboBoxModes
            // 
            this.comboBoxModes.FormattingEnabled = true;
            this.comboBoxModes.Location = new System.Drawing.Point(6, 75);
            this.comboBoxModes.Name = "comboBoxModes";
            this.comboBoxModes.Size = new System.Drawing.Size(190, 21);
            this.comboBoxModes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mode";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(6, 103);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(190, 46);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxDeviceSettings
            // 
            this.groupBoxDeviceSettings.Controls.Add(this.label1);
            this.groupBoxDeviceSettings.Controls.Add(this.buttonStart);
            this.groupBoxDeviceSettings.Controls.Add(this.comboBoxDevices);
            this.groupBoxDeviceSettings.Controls.Add(this.label2);
            this.groupBoxDeviceSettings.Controls.Add(this.comboBoxModes);
            this.groupBoxDeviceSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDeviceSettings.Name = "groupBoxDeviceSettings";
            this.groupBoxDeviceSettings.Size = new System.Drawing.Size(201, 155);
            this.groupBoxDeviceSettings.TabIndex = 4;
            this.groupBoxDeviceSettings.TabStop = false;
            // 
            // groupBoxVideoSettings
            // 
            this.groupBoxVideoSettings.Controls.Add(this.label3);
            this.groupBoxVideoSettings.Controls.Add(this.trackBarSensitivity);
            this.groupBoxVideoSettings.Location = new System.Drawing.Point(13, 174);
            this.groupBoxVideoSettings.Name = "groupBoxVideoSettings";
            this.groupBoxVideoSettings.Size = new System.Drawing.Size(200, 89);
            this.groupBoxVideoSettings.TabIndex = 5;
            this.groupBoxVideoSettings.TabStop = false;
            this.groupBoxVideoSettings.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sensitivity";
            // 
            // trackBarSensitivity
            // 
            this.trackBarSensitivity.LargeChange = 10;
            this.trackBarSensitivity.Location = new System.Drawing.Point(5, 36);
            this.trackBarSensitivity.Maximum = 100;
            this.trackBarSensitivity.Name = "trackBarSensitivity";
            this.trackBarSensitivity.Size = new System.Drawing.Size(187, 45);
            this.trackBarSensitivity.TabIndex = 0;
            this.trackBarSensitivity.Value = 10;
            this.trackBarSensitivity.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 378);
            this.Controls.Add(this.groupBoxVideoSettings);
            this.Controls.Add(this.groupBoxDeviceSettings);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxDeviceSettings.ResumeLayout(false);
            this.groupBoxDeviceSettings.PerformLayout();
            this.groupBoxVideoSettings.ResumeLayout(false);
            this.groupBoxVideoSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensitivity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.ComboBox comboBoxModes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxDeviceSettings;
        private System.Windows.Forms.GroupBox groupBoxVideoSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarSensitivity;
    }
}

