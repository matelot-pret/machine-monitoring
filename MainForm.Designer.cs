namespace mainApp
{
    partial class MainForm
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
            machineScreen1 = new MachineScreen();
            labelNoMachine = new Label();
            labelMailFailed = new Label();
            labelNotificationSettingsInfo = new Label();
            checkBoxAlwaysOnTop = new CheckBox();
            buttonExitMainApp = new Button();
            buttonLaunchConfig = new Button();
            SuspendLayout();
            // 
            // machineScreen1
            // 
            machineScreen1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineScreen1.Location = new Point(38, 84);
            machineScreen1.Margin = new Padding(3, 4, 3, 4);
            machineScreen1.Name = "machineScreen1";
            machineScreen1.Size = new Size(882, 680);
            machineScreen1.TabIndex = 0;
            // 
            // labelNoMachine
            // 
            labelNoMachine.AutoSize = true;
            labelNoMachine.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoMachine.Location = new Point(93, 353);
            labelNoMachine.Margin = new Padding(4, 0, 4, 0);
            labelNoMachine.Name = "labelNoMachine";
            labelNoMachine.Size = new Size(761, 46);
            labelNoMachine.TabIndex = 2;
            labelNoMachine.Text = "There is no machine to monitore. \r\nUse \"Open Configuration\" button to launch the configuration and set Machine to monitore";
            labelNoMachine.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelMailFailed
            // 
            labelMailFailed.AutoSize = true;
            labelMailFailed.BackColor = Color.IndianRed;
            labelMailFailed.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMailFailed.ForeColor = SystemColors.Control;
            labelMailFailed.Location = new Point(341, 693);
            labelMailFailed.Name = "labelMailFailed";
            labelMailFailed.Size = new Size(192, 23);
            labelMailFailed.TabIndex = 3;
            labelMailFailed.Text = "Failed to Send a mail.";
            // 
            // labelNotificationSettingsInfo
            // 
            labelNotificationSettingsInfo.AutoSize = true;
            labelNotificationSettingsInfo.BackColor = Color.Red;
            labelNotificationSettingsInfo.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNotificationSettingsInfo.ForeColor = SystemColors.Control;
            labelNotificationSettingsInfo.Location = new Point(306, 27);
            labelNotificationSettingsInfo.Name = "labelNotificationSettingsInfo";
            labelNotificationSettingsInfo.Size = new Size(269, 23);
            labelNotificationSettingsInfo.TabIndex = 4;
            labelNotificationSettingsInfo.Text = "Incomplet Notification Settings";
            // 
            // checkBoxAlwaysOnTop
            // 
            checkBoxAlwaysOnTop.AutoSize = true;
            checkBoxAlwaysOnTop.Checked = true;
            checkBoxAlwaysOnTop.CheckState = CheckState.Checked;
            checkBoxAlwaysOnTop.Location = new Point(114, 54);
            checkBoxAlwaysOnTop.Margin = new Padding(3, 4, 3, 4);
            checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            checkBoxAlwaysOnTop.RightToLeft = RightToLeft.Yes;
            checkBoxAlwaysOnTop.Size = new Size(115, 22);
            checkBoxAlwaysOnTop.TabIndex = 5;
            checkBoxAlwaysOnTop.Text = "AlwaysOnTop";
            checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            checkBoxAlwaysOnTop.CheckedChanged += checkBoxAlwaysOnTop_CheckedChanged;
            // 
            // buttonExitMainApp
            // 
            buttonExitMainApp.Location = new Point(649, 684);
            buttonExitMainApp.Margin = new Padding(3, 4, 3, 4);
            buttonExitMainApp.Name = "buttonExitMainApp";
            buttonExitMainApp.Size = new Size(97, 45);
            buttonExitMainApp.TabIndex = 6;
            buttonExitMainApp.Text = "Exit Monitoring";
            buttonExitMainApp.UseVisualStyleBackColor = true;
            buttonExitMainApp.Click += buttonExitMainApp_Click;
            // 
            // buttonLaunchConfig
            // 
            buttonLaunchConfig.Location = new Point(131, 684);
            buttonLaunchConfig.Margin = new Padding(3, 4, 3, 4);
            buttonLaunchConfig.Name = "buttonLaunchConfig";
            buttonLaunchConfig.Size = new Size(120, 45);
            buttonLaunchConfig.TabIndex = 7;
            buttonLaunchConfig.Text = "Open Configuration";
            buttonLaunchConfig.UseVisualStyleBackColor = true;
            buttonLaunchConfig.Click += buttonLaunchConfig_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(967, 775);
            Controls.Add(buttonLaunchConfig);
            Controls.Add(buttonExitMainApp);
            Controls.Add(checkBoxAlwaysOnTop);
            Controls.Add(labelNotificationSettingsInfo);
            Controls.Add(labelMailFailed);
            Controls.Add(labelNoMachine);
            Controls.Add(machineScreen1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Monitoring App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MachineScreen machineScreen1;
        private Label labelNoMachine;
        private Label labelMailFailed;
        private Label labelNotificationSettingsInfo;
        private CheckBox checkBoxAlwaysOnTop;
        private Button buttonExitMainApp;
        private Button buttonLaunchConfig;
    }
}
