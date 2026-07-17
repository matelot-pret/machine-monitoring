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
            panelManageConfig = new Panel();
            label44 = new Label();
            label43 = new Label();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            textBoxReceiverMail = new TextBox();
            textBoxPassword = new TextBox();
            textBoxSenderMail = new TextBox();
            checkBoxSSL = new CheckBox();
            textBoxPort = new TextBox();
            textBoxSmtp = new TextBox();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            label35 = new Label();
            label34 = new Label();
            machineScreen1 = new MachineScreen();
            labelLastChangeTime = new Label();
            buttonReset = new Button();
            buttonExitConfigLaunchMain = new Button();
            panelManageConfig.SuspendLayout();
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
            // panelManageConfig
            // 
            panelManageConfig.BorderStyle = BorderStyle.Fixed3D;
            panelManageConfig.Controls.Add(label44);
            panelManageConfig.Controls.Add(label43);
            panelManageConfig.Controls.Add(label42);
            panelManageConfig.Controls.Add(label41);
            panelManageConfig.Controls.Add(label40);
            panelManageConfig.Controls.Add(textBoxReceiverMail);
            panelManageConfig.Controls.Add(textBoxPassword);
            panelManageConfig.Controls.Add(textBoxSenderMail);
            panelManageConfig.Controls.Add(checkBoxSSL);
            panelManageConfig.Controls.Add(textBoxPort);
            panelManageConfig.Controls.Add(textBoxSmtp);
            panelManageConfig.Controls.Add(label39);
            panelManageConfig.Controls.Add(label38);
            panelManageConfig.Controls.Add(label37);
            panelManageConfig.Controls.Add(label35);
            panelManageConfig.Controls.Add(label34);
            panelManageConfig.Location = new Point(24, 117);
            panelManageConfig.Name = "panelManageConfig";
            panelManageConfig.Size = new Size(1146, 610);
            panelManageConfig.TabIndex = 1;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label44.Location = new Point(182, 114);
            label44.Name = "label44";
            label44.Size = new Size(291, 20);
            label44.TabIndex = 17;
            label44.Text = "The smtp of the host that will sent the mail";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label43.Location = new Point(182, 183);
            label43.Name = "label43";
            label43.Size = new Size(326, 20);
            label43.TabIndex = 16;
            label43.Text = "The port from which the smtp will communicate";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label42.Location = new Point(182, 317);
            label42.Name = "label42";
            label42.Size = new Size(309, 20);
            label42.TabIndex = 15;
            label42.Text = "The mail from which notifications will be sent\r\n";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label41.Location = new Point(182, 401);
            label41.Name = "label41";
            label41.Size = new Size(355, 20);
            label41.TabIndex = 14;
            label41.Text = "The password of the account linked to the smtp host";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.Location = new Point(182, 478);
            label40.Name = "label40";
            label40.Size = new Size(285, 20);
            label40.TabIndex = 13;
            label40.Text = "The mail that will receive the notifications";
            // 
            // textBoxReceiverMail
            // 
            textBoxReceiverMail.Location = new Point(349, 449);
            textBoxReceiverMail.Name = "textBoxReceiverMail";
            textBoxReceiverMail.PlaceholderText = "Enter the mail";
            textBoxReceiverMail.Size = new Size(145, 26);
            textBoxReceiverMail.TabIndex = 12;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(270, 372);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter the password";
            textBoxPassword.Size = new Size(142, 26);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxSenderMail
            // 
            textBoxSenderMail.Location = new Point(341, 288);
            textBoxSenderMail.Name = "textBoxSenderMail";
            textBoxSenderMail.PlaceholderText = "Enter the mail";
            textBoxSenderMail.Size = new Size(153, 26);
            textBoxSenderMail.TabIndex = 10;
            // 
            // checkBoxSSL
            // 
            checkBoxSSL.AutoSize = true;
            checkBoxSSL.Location = new Point(182, 239);
            checkBoxSSL.Name = "checkBoxSSL";
            checkBoxSSL.RightToLeft = RightToLeft.Yes;
            checkBoxSSL.Size = new Size(113, 22);
            checkBoxSSL.TabIndex = 8;
            checkBoxSSL.Text = "Activate SSL";
            checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(230, 154);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "Enter the port";
            textBoxPort.Size = new Size(100, 26);
            textBoxPort.TabIndex = 7;
            // 
            // textBoxSmtp
            // 
            textBoxSmtp.Location = new Point(274, 86);
            textBoxSmtp.Name = "textBoxSmtp";
            textBoxSmtp.PlaceholderText = "Enter the SMTP host";
            textBoxSmtp.Size = new Size(153, 26);
            textBoxSmtp.TabIndex = 6;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(182, 452);
            label39.Name = "label39";
            label39.Size = new Size(166, 18);
            label39.TabIndex = 5;
            label39.Text = "Receiver Mail Address :";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(182, 375);
            label38.Name = "label38";
            label38.Size = new Size(82, 18);
            label38.TabIndex = 4;
            label38.Text = "Password :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(182, 291);
            label37.Name = "label37";
            label37.Size = new Size(153, 18);
            label37.TabIndex = 3;
            label37.Text = "Sender mail address :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(182, 157);
            label35.Name = "label35";
            label35.Size = new Size(42, 18);
            label35.TabIndex = 1;
            label35.Text = "Port :";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(182, 89);
            label34.Name = "label34";
            label34.Size = new Size(88, 18);
            label34.TabIndex = 0;
            label34.Text = "SMTP Host :";
            // 
            // machineScreen1
            // 
            machineScreen1.AutoScroll = true;
            machineScreen1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            machineScreen1.BorderStyle = BorderStyle.Fixed3D;
            machineScreen1.Location = new Point(24, 117);
            machineScreen1.Margin = new Padding(3, 2, 3, 2);
            machineScreen1.Name = "machineScreen1";
            machineScreen1.Size = new Size(1146, 610);
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
            // configForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1194, 808);
            Controls.Add(buttonExitConfigLaunchMain);
            Controls.Add(buttonReset);
            Controls.Add(labelLastChangeTime);
            Controls.Add(buttonManageNotification);
            Controls.Add(buttonManageMachine);
            Controls.Add(machineScreen1);
            Controls.Add(panelManageConfig);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "configForm";
            Text = "Configuration";
            FormClosing += configForm_FormClosing;
            panelManageConfig.ResumeLayout(false);
            panelManageConfig.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonManageMachine;
        private Button buttonManageNotification;
        private Label labelLastChangeTime;
        private Button buttonReset;
        private Button buttonExitConfigLaunchMain;
        private Panel panelManageConfig;
        private Label label35;
        private Label label34;
        private CheckBox checkBoxSSL;
        private TextBox textBoxPort;
        private TextBox textBoxSmtp;
        private Label label39;
        private Label label38;
        private Label label37;
        private TextBox textBoxReceiverMail;
        private TextBox textBoxPassword;
        private TextBox textBoxSenderMail;
        private Label label40;
        private Label label42;
        private Label label41;
        private Label label43;
        private Label label44;
        private MachineScreen machineScreen1;
    }
}
