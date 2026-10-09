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
            labelMailFailed = new Label();
            checkBoxAlwaysOnTop = new CheckBox();
            buttonExitMainApp = new Button();
            buttonLaunchConfig = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelNotificationSettingsInfo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // machineScreen1
            // 
            machineScreen1.AutoSize = true;
            machineScreen1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            machineScreen1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineScreen1.Location = new Point(3, 49);
            machineScreen1.Margin = new Padding(3, 4, 3, 4);
            machineScreen1.Name = "machineScreen1";
            machineScreen1.Size = new Size(769, 96);
            machineScreen1.TabIndex = 0;
            // 
            // labelMailFailed
            // 
            labelMailFailed.AutoSize = true;
            labelMailFailed.BackColor = Color.IndianRed;
            labelMailFailed.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMailFailed.ForeColor = SystemColors.Control;
            labelMailFailed.Location = new Point(295, 15);
            labelMailFailed.Margin = new Padding(50, 15, 3, 0);
            labelMailFailed.Name = "labelMailFailed";
            labelMailFailed.Size = new Size(192, 23);
            labelMailFailed.TabIndex = 3;
            labelMailFailed.Text = "Failed to Send a mail.";
            // 
            // checkBoxAlwaysOnTop
            // 
            checkBoxAlwaysOnTop.AutoSize = true;
            checkBoxAlwaysOnTop.Checked = true;
            checkBoxAlwaysOnTop.CheckState = CheckState.Checked;
            checkBoxAlwaysOnTop.Location = new Point(3, 13);
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
            buttonExitMainApp.Location = new Point(560, 15);
            buttonExitMainApp.Margin = new Padding(70, 15, 0, 0);
            buttonExitMainApp.Name = "buttonExitMainApp";
            buttonExitMainApp.Size = new Size(97, 45);
            buttonExitMainApp.TabIndex = 6;
            buttonExitMainApp.Text = "Exit Monitoring";
            buttonExitMainApp.UseVisualStyleBackColor = true;
            buttonExitMainApp.Click += buttonExitMainApp_Click;
            // 
            // buttonLaunchConfig
            // 
            buttonLaunchConfig.Location = new Point(90, 15);
            buttonLaunchConfig.Margin = new Padding(90, 15, 3, 4);
            buttonLaunchConfig.Name = "buttonLaunchConfig";
            buttonLaunchConfig.Size = new Size(120, 45);
            buttonLaunchConfig.TabIndex = 7;
            buttonLaunchConfig.Text = "Open Configuration";
            buttonLaunchConfig.UseVisualStyleBackColor = true;
            buttonLaunchConfig.Click += buttonLaunchConfig_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(machineScreen1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(840, 233);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(labelNotificationSettingsInfo);
            panel1.Controls.Add(checkBoxAlwaysOnTop);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 39);
            panel1.TabIndex = 9;
            // 
            // labelNotificationSettingsInfo
            // 
            labelNotificationSettingsInfo.AutoSize = true;
            labelNotificationSettingsInfo.BackColor = Color.Red;
            labelNotificationSettingsInfo.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNotificationSettingsInfo.ForeColor = SystemColors.Control;
            labelNotificationSettingsInfo.Location = new Point(219, 13);
            labelNotificationSettingsInfo.Name = "labelNotificationSettingsInfo";
            labelNotificationSettingsInfo.Size = new Size(269, 23);
            labelNotificationSettingsInfo.TabIndex = 4;
            labelNotificationSettingsInfo.Text = "Incomplet Notification Settings";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(buttonLaunchConfig, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonExitMainApp, 2, 0);
            tableLayoutPanel2.Controls.Add(labelMailFailed, 1, 0);
            tableLayoutPanel2.Location = new Point(95, 159);
            tableLayoutPanel2.Margin = new Padding(95, 10, 10, 10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(735, 64);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1233, 908);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Monitoring App";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MachineScreen machineScreen1;
        private Label labelMailFailed;
        private CheckBox checkBoxAlwaysOnTop;
        private Button buttonExitMainApp;
        private Button buttonLaunchConfig;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label labelNotificationSettingsInfo;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
