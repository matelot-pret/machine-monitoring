namespace configApp
{
    partial class MachineControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            textBoxMachineName = new TextBox();
            labelIP = new Label();
            textBoxMachineIpv4 = new TextBox();
            labelPingInterval = new Label();
            numericUpDownMachineInterval = new NumericUpDown();
            buttonDelete = new Button();
            labelIsValid = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMachineInterval).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 46);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 18);
            labelName.TabIndex = 1;
            labelName.Text = "Name :";
            // 
            // textBoxMachineName
            // 
            textBoxMachineName.Location = new Point(70, 43);
            textBoxMachineName.Margin = new Padding(3, 4, 3, 4);
            textBoxMachineName.Name = "textBoxMachineName";
            textBoxMachineName.PlaceholderText = "Enter the name";
            textBoxMachineName.Size = new Size(111, 26);
            textBoxMachineName.TabIndex = 2;
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIP.Location = new Point(12, 92);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(105, 18);
            labelIP.TabIndex = 3;
            labelIP.Text = "IPv4 Address :";
            // 
            // textBoxMachineIpv4
            // 
            textBoxMachineIpv4.Location = new Point(123, 89);
            textBoxMachineIpv4.Margin = new Padding(3, 4, 3, 4);
            textBoxMachineIpv4.Name = "textBoxMachineIpv4";
            textBoxMachineIpv4.PlaceholderText = "Enter the IPv4 Address";
            textBoxMachineIpv4.Size = new Size(182, 26);
            textBoxMachineIpv4.TabIndex = 4;
            // 
            // labelPingInterval
            // 
            labelPingInterval.AutoSize = true;
            labelPingInterval.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPingInterval.Location = new Point(12, 145);
            labelPingInterval.Name = "labelPingInterval";
            labelPingInterval.Size = new Size(221, 18);
            labelPingInterval.TabIndex = 5;
            labelPingInterval.Text = "Ping request interval in second :";
            // 
            // numericUpDownMachineInterval
            // 
            numericUpDownMachineInterval.Location = new Point(239, 143);
            numericUpDownMachineInterval.Margin = new Padding(3, 4, 3, 4);
            numericUpDownMachineInterval.Name = "numericUpDownMachineInterval";
            numericUpDownMachineInterval.Size = new Size(49, 26);
            numericUpDownMachineInterval.TabIndex = 6;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(96, 186);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(86, 28);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // labelIsValid
            // 
            labelIsValid.AutoSize = true;
            labelIsValid.BackColor = Color.IndianRed;
            labelIsValid.ForeColor = SystemColors.ControlLightLight;
            labelIsValid.Location = new Point(101, 13);
            labelIsValid.Name = "labelIsValid";
            labelIsValid.Size = new Size(111, 18);
            labelIsValid.TabIndex = 8;
            labelIsValid.Text = "Invalid Machine";
            // 
            // MachineControl
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelIsValid);
            Controls.Add(buttonDelete);
            Controls.Add(numericUpDownMachineInterval);
            Controls.Add(labelPingInterval);
            Controls.Add(textBoxMachineIpv4);
            Controls.Add(labelIP);
            Controls.Add(textBoxMachineName);
            Controls.Add(labelName);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MachineControl";
            Size = new Size(315, 219);
            ((System.ComponentModel.ISupportInitialize)numericUpDownMachineInterval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxMachineName;
        private Label labelIP;
        private TextBox textBoxMachineIpv4;
        private Label labelPingInterval;
        private NumericUpDown numericUpDownMachineInterval;
        private Button buttonDelete;
        private Label labelIsValid;
    }
}
