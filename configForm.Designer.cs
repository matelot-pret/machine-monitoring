namespace configApp
{
    partial class configForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonManageMachine = new Button();
            buttonManageNotification = new Button();
            machineScreen1 = new MachineScreen();
            labelLastChangeTime = new Label();
            buttonReset = new Button();
            buttonExitConfigLaunchMain = new Button();
            smtpScreen1 = new SMTPScreen();
            SuspendLayout();
            // 
            // buttonManageMachine
            // 
            buttonManageMachine.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonManageMachine.Location = new Point(273, 25);
            buttonManageMachine.Margin = new Padding(3, 4, 3, 4);
            buttonManageMachine.Name = "buttonManageMachine";
            buttonManageMachine.Size = new Size(153, 44);
            buttonManageMachine.TabIndex = 0;
            buttonManageMachine.Text = "Manage Machine(s) Configuration";
            buttonManageMachine.UseVisualStyleBackColor = true;
            buttonManageMachine.Click += buttonManageMachineClick;
            // 
            // buttonManageNotification
            // 
            buttonManageNotification.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonManageNotification.Location = new Point(741, 25);
            buttonManageNotification.Margin = new Padding(3, 4, 3, 4);
            buttonManageNotification.Name = "buttonManageNotification";
            buttonManageNotification.Size = new Size(159, 44);
            buttonManageNotification.TabIndex = 2;
            buttonManageNotification.Text = "Manage Notification configuration";
            buttonManageNotification.UseVisualStyleBackColor = true;
            buttonManageNotification.Click += buttonManageNotificationClick;
            // 
            // machineScreen1
            // 
            machineScreen1.AutoScroll = true;
            machineScreen1.AutoSize = true;
            machineScreen1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            machineScreen1.BorderStyle = BorderStyle.Fixed3D;
            machineScreen1.Location = new Point(24, 117);
            machineScreen1.Margin = new Padding(3, 2, 3, 2);
            machineScreen1.Name = "machineScreen1";
            machineScreen1.Size = new Size(953, 91);
            machineScreen1.TabIndex = 8;
            // 
            // labelLastChangeTime
            // 
            labelLastChangeTime.AutoSize = true;
            labelLastChangeTime.Location = new Point(741, 80);
            labelLastChangeTime.Name = "labelLastChangeTime";
            labelLastChangeTime.Size = new Size(0, 18);
            labelLastChangeTime.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(298, 757);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(160, 37);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset configuration\r\n";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonResetClick;
            // 
            // buttonExitConfigLaunchMain
            // 
            buttonExitConfigLaunchMain.Location = new Point(741, 752);
            buttonExitConfigLaunchMain.Name = "buttonExitConfigLaunchMain";
            buttonExitConfigLaunchMain.Size = new Size(177, 47);
            buttonExitConfigLaunchMain.TabIndex = 7;
            buttonExitConfigLaunchMain.Text = "Exit configuration and launch monitoring\r\n";
            buttonExitConfigLaunchMain.UseVisualStyleBackColor = true;
            buttonExitConfigLaunchMain.Click += buttonExitConfigLaunchMainClick;
            // 
            // smtpScreen1
            // 
            smtpScreen1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smtpScreen1.Location = new Point(24, 117);
            smtpScreen1.Name = "smtpScreen1";
            smtpScreen1.Size = new Size(1146, 610);
            smtpScreen1.TabIndex = 9;
            // 
            // configForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1194, 808);
            Controls.Add(smtpScreen1);
            Controls.Add(buttonExitConfigLaunchMain);
            Controls.Add(buttonReset);
            Controls.Add(labelLastChangeTime);
            Controls.Add(buttonManageNotification);
            Controls.Add(buttonManageMachine);
            Controls.Add(machineScreen1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "configForm";
            Text = "Configuration";
            FormClosing += configForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonManageMachine;
        private Button buttonManageNotification;
        private Label labelLastChangeTime;
        private Button buttonReset;
        private Button buttonExitConfigLaunchMain;
        private MachineScreen machineScreen1;
        private SMTPScreen smtpScreen1;
    }
}
