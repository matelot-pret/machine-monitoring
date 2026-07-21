namespace mainApp
{
    partial class MachineScreen
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
            panel1 = new Panel();
            checkBoxAlwaysOnTop = new CheckBox();
            labelNotificationSettingsInfo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonLaunchConfig = new Button();
            buttonExitMainApp = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxAlwaysOnTop);
            panel1.Controls.Add(labelNotificationSettingsInfo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 92);
            panel1.TabIndex = 0;
            // 
            // checkBoxAlwaysOnTop
            // 
            checkBoxAlwaysOnTop.AutoSize = true;
            checkBoxAlwaysOnTop.Location = new Point(71, 42);
            checkBoxAlwaysOnTop.Margin = new Padding(3, 4, 3, 4);
            checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            checkBoxAlwaysOnTop.RightToLeft = RightToLeft.Yes;
            checkBoxAlwaysOnTop.Size = new Size(115, 22);
            checkBoxAlwaysOnTop.TabIndex = 2;
            checkBoxAlwaysOnTop.Text = "AlwaysOnTop";
            checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // labelNotificationSettingsInfo
            // 
            labelNotificationSettingsInfo.AutoSize = true;
            labelNotificationSettingsInfo.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNotificationSettingsInfo.Location = new Point(361, 12);
            labelNotificationSettingsInfo.Name = "labelNotificationSettingsInfo";
            labelNotificationSettingsInfo.Size = new Size(269, 23);
            labelNotificationSettingsInfo.TabIndex = 3;
            labelNotificationSettingsInfo.Text = "Incomplet Notification Settings";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(50, 100);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(896, 552);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonLaunchConfig
            // 
            buttonLaunchConfig.Location = new Point(176, 663);
            buttonLaunchConfig.Margin = new Padding(3, 4, 3, 4);
            buttonLaunchConfig.Name = "buttonLaunchConfig";
            buttonLaunchConfig.Size = new Size(120, 45);
            buttonLaunchConfig.TabIndex = 4;
            buttonLaunchConfig.Text = "Open Configuration";
            buttonLaunchConfig.UseVisualStyleBackColor = true;
            // 
            // buttonExitMainApp
            // 
            buttonExitMainApp.Location = new Point(721, 663);
            buttonExitMainApp.Margin = new Padding(3, 4, 3, 4);
            buttonExitMainApp.Name = "buttonExitMainApp";
            buttonExitMainApp.Size = new Size(97, 45);
            buttonExitMainApp.TabIndex = 5;
            buttonExitMainApp.Text = "Exit Monitoring";
            buttonExitMainApp.UseVisualStyleBackColor = true;
            // 
            // MachineScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonExitMainApp);
            Controls.Add(buttonLaunchConfig);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MachineScreen";
            Size = new Size(1003, 769);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox checkBoxAlwaysOnTop;
        private Label labelNotificationSettingsInfo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonLaunchConfig;
        private Button buttonExitMainApp;
    }
}
