namespace mainApp
{
    partial class MachineBloc
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
            labelStateCommunication = new Label();
            labelMachineName = new Label();
            labelMachineIpv4 = new Label();
            textBoxMachineName = new TextBox();
            textBoxMachineIpv4 = new TextBox();
            SuspendLayout();
            // 
            // labelStateCommunication
            // 
            labelStateCommunication.AutoSize = true;
            labelStateCommunication.Location = new Point(55, 19);
            labelStateCommunication.Name = "labelStateCommunication";
            labelStateCommunication.Size = new Size(161, 18);
            labelStateCommunication.TabIndex = 0;
            labelStateCommunication.Text = "Communication Initiate";
            // 
            // labelMachineName
            // 
            labelMachineName.AutoSize = true;
            labelMachineName.Location = new Point(29, 74);
            labelMachineName.Name = "labelMachineName";
            labelMachineName.Size = new Size(55, 18);
            labelMachineName.TabIndex = 1;
            labelMachineName.Text = "Name :";
            // 
            // labelMachineIpv4
            // 
            labelMachineIpv4.AutoSize = true;
            labelMachineIpv4.Location = new Point(29, 130);
            labelMachineIpv4.Name = "labelMachineIpv4";
            labelMachineIpv4.Size = new Size(100, 18);
            labelMachineIpv4.TabIndex = 2;
            labelMachineIpv4.Text = "Ipv4Address :";
            // 
            // textBoxMachineName
            // 
            textBoxMachineName.Location = new Point(90, 71);
            textBoxMachineName.Margin = new Padding(3, 4, 3, 4);
            textBoxMachineName.Name = "textBoxMachineName";
            textBoxMachineName.ReadOnly = true;
            textBoxMachineName.Size = new Size(114, 26);
            textBoxMachineName.TabIndex = 3;
            // 
            // textBoxMachineIpv4
            // 
            textBoxMachineIpv4.Location = new Point(135, 127);
            textBoxMachineIpv4.Margin = new Padding(3, 4, 3, 4);
            textBoxMachineIpv4.Name = "textBoxMachineIpv4";
            textBoxMachineIpv4.ReadOnly = true;
            textBoxMachineIpv4.Size = new Size(133, 26);
            textBoxMachineIpv4.TabIndex = 4;
            // 
            // MachineBloc
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxMachineIpv4);
            Controls.Add(textBoxMachineName);
            Controls.Add(labelMachineIpv4);
            Controls.Add(labelMachineName);
            Controls.Add(labelStateCommunication);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MachineBloc";
            Size = new Size(294, 196);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStateCommunication;
        private Label labelMachineName;
        private Label labelMachineIpv4;
        private TextBox textBoxMachineName;
        private TextBox textBoxMachineIpv4;
    }
}
