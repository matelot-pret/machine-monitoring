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
            textBox_machine_name = new TextBox();
            labelIP = new Label();
            textBox_machine_ipv4 = new TextBox();
            labelPingInterval = new Label();
            numericUpDown_machine_interval = new NumericUpDown();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_machine_interval).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 22);
            labelName.Name = "labelName";
            labelName.Size = new Size(45, 15);
            labelName.TabIndex = 1;
            labelName.Text = "Name :";
            // 
            // textBox_machine_name
            // 
            textBox_machine_name.Location = new Point(64, 19);
            textBox_machine_name.Name = "textBox_machine_name";
            textBox_machine_name.PlaceholderText = "Enter the name";
            textBox_machine_name.Size = new Size(98, 23);
            textBox_machine_name.TabIndex = 2;
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Location = new Point(13, 60);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(80, 15);
            labelIP.TabIndex = 3;
            labelIP.Text = "IPv4 Address :";
            // 
            // textBox_machine_ipv4
            // 
            textBox_machine_ipv4.Location = new Point(99, 57);
            textBox_machine_ipv4.Name = "textBox_machine_ipv4";
            textBox_machine_ipv4.PlaceholderText = "Enter the IPv4 Address";
            textBox_machine_ipv4.Size = new Size(160, 23);
            textBox_machine_ipv4.TabIndex = 4;
            // 
            // labelPingInterval
            // 
            labelPingInterval.AutoSize = true;
            labelPingInterval.Location = new Point(13, 104);
            labelPingInterval.Name = "labelPingInterval";
            labelPingInterval.Size = new Size(175, 15);
            labelPingInterval.TabIndex = 5;
            labelPingInterval.Text = "Ping request interval in second :";
            // 
            // numericUpDown_machine_interval
            // 
            numericUpDown_machine_interval.Location = new Point(194, 102);
            numericUpDown_machine_interval.Name = "numericUpDown_machine_interval";
            numericUpDown_machine_interval.Size = new Size(43, 23);
            numericUpDown_machine_interval.TabIndex = 6;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(87, 138);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // MachineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDelete);
            Controls.Add(numericUpDown_machine_interval);
            Controls.Add(labelPingInterval);
            Controls.Add(textBox_machine_ipv4);
            Controls.Add(labelIP);
            Controls.Add(textBox_machine_name);
            Controls.Add(labelName);
            Name = "MachineControl";
            Size = new Size(277, 173);
            Load += MachineControl_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_machine_interval).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBox_machine_name;
        private Label labelIP;
        private TextBox textBox_machine_ipv4;
        private Label labelPingInterval;
        private NumericUpDown numericUpDown_machine_interval;
        private Button buttonDelete;
    }
}
