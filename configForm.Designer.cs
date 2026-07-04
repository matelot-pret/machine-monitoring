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
            button_manage_machine = new Button();
            button_manage_notification = new Button();
            label1 = new Label();
            panel_manage_config = new Panel();
            label44 = new Label();
            label43 = new Label();
            label42 = new Label();
            label41 = new Label();
            label40 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            checkBox_SSL = new CheckBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label39 = new Label();
            label38 = new Label();
            label37 = new Label();
            label35 = new Label();
            label34 = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            buttonAddMachine = new Button();
            label_last_change_time = new Label();
            button_reset = new Button();
            button_exit_config_launch_main = new Button();
            panel_manage_config.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button_manage_machine
            // 
            button_manage_machine.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manage_machine.Location = new Point(275, 13);
            button_manage_machine.Margin = new Padding(3, 4, 3, 4);
            button_manage_machine.Name = "button_manage_machine";
            button_manage_machine.Size = new Size(153, 44);
            button_manage_machine.TabIndex = 0;
            button_manage_machine.Text = "Manage Machine(s) Configuration";
            button_manage_machine.UseVisualStyleBackColor = true;
            button_manage_machine.Click += button_manage_machine_Click;
            // 
            // button_manage_notification
            // 
            button_manage_notification.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manage_notification.Location = new Point(741, 13);
            button_manage_notification.Margin = new Padding(3, 4, 3, 4);
            button_manage_notification.Name = "button_manage_notification";
            button_manage_notification.Size = new Size(159, 44);
            button_manage_notification.TabIndex = 2;
            button_manage_notification.Text = "Manage Notification configuration";
            button_manage_notification.UseVisualStyleBackColor = true;
            button_manage_notification.Click += button_manage_notification_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(475, 20);
            label1.TabIndex = 0;
            label1.Text = "Machine to monitor. The maximum number of machine to monitor is 8\r\n";
            // 
            // panel_manage_config
            // 
            panel_manage_config.BorderStyle = BorderStyle.Fixed3D;
            panel_manage_config.Controls.Add(label44);
            panel_manage_config.Controls.Add(label43);
            panel_manage_config.Controls.Add(label42);
            panel_manage_config.Controls.Add(label41);
            panel_manage_config.Controls.Add(label40);
            panel_manage_config.Controls.Add(textBox5);
            panel_manage_config.Controls.Add(textBox4);
            panel_manage_config.Controls.Add(textBox3);
            panel_manage_config.Controls.Add(checkBox_SSL);
            panel_manage_config.Controls.Add(textBox2);
            panel_manage_config.Controls.Add(textBox1);
            panel_manage_config.Controls.Add(label39);
            panel_manage_config.Controls.Add(label38);
            panel_manage_config.Controls.Add(label37);
            panel_manage_config.Controls.Add(label35);
            panel_manage_config.Controls.Add(label34);
            panel_manage_config.Location = new Point(14, 134);
            panel_manage_config.Name = "panel_manage_config";
            panel_manage_config.Size = new Size(1163, 597);
            panel_manage_config.TabIndex = 1;
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
            // textBox5
            // 
            textBox5.Location = new Point(349, 449);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter the mail";
            textBox5.Size = new Size(145, 26);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 372);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Enter the password";
            textBox4.Size = new Size(142, 26);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(341, 288);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Enter the mail";
            textBox3.Size = new Size(153, 26);
            textBox3.TabIndex = 10;
            // 
            // checkBox_SSL
            // 
            checkBox_SSL.AutoSize = true;
            checkBox_SSL.Location = new Point(182, 239);
            checkBox_SSL.Name = "checkBox_SSL";
            checkBox_SSL.RightToLeft = RightToLeft.Yes;
            checkBox_SSL.Size = new Size(113, 22);
            checkBox_SSL.TabIndex = 8;
            checkBox_SSL.Text = "Activate SSL";
            checkBox_SSL.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 154);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter the port";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 86);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the SMTP host";
            textBox1.Size = new Size(153, 26);
            textBox1.TabIndex = 6;
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
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(panel1);
            flowLayoutPanel.Location = new Point(12, 134);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1165, 597);
            flowLayoutPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonAddMachine);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1155, 79);
            panel1.TabIndex = 18;
            // 
            // buttonAddMachine
            // 
            buttonAddMachine.Location = new Point(724, 12);
            buttonAddMachine.Name = "buttonAddMachine";
            buttonAddMachine.Size = new Size(129, 47);
            buttonAddMachine.TabIndex = 0;
            buttonAddMachine.Text = "+ add a machine configuration";
            buttonAddMachine.UseVisualStyleBackColor = true;
            buttonAddMachine.Click += buttonAddMachine_Click;
            // 
            // label_last_change_time
            // 
            label_last_change_time.AutoSize = true;
            label_last_change_time.Location = new Point(741, 72);
            label_last_change_time.Name = "label_last_change_time";
            label_last_change_time.Size = new Size(45, 18);
            label_last_change_time.TabIndex = 3;
            label_last_change_time.Text = "Label";
            // 
            // button_reset
            // 
            button_reset.Location = new Point(298, 757);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(160, 37);
            button_reset.TabIndex = 4;
            button_reset.Text = "Reset configuration\r\n";
            button_reset.UseVisualStyleBackColor = true;
            button_reset.Click += button_reset_Click;
            // 
            // button_exit_config_launch_main
            // 
            button_exit_config_launch_main.Location = new Point(741, 752);
            button_exit_config_launch_main.Name = "button_exit_config_launch_main";
            button_exit_config_launch_main.Size = new Size(177, 47);
            button_exit_config_launch_main.TabIndex = 7;
            button_exit_config_launch_main.Text = "Exit configuration and launch monitoring\r\n";
            button_exit_config_launch_main.UseVisualStyleBackColor = true;
            button_exit_config_launch_main.Click += button_exit_config_launch_main_Click;
            // 
            // configForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1194, 831);
            Controls.Add(flowLayoutPanel);
            Controls.Add(panel_manage_config);
            Controls.Add(button_exit_config_launch_main);
            Controls.Add(button_reset);
            Controls.Add(label_last_change_time);
            Controls.Add(button_manage_notification);
            Controls.Add(button_manage_machine);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "configForm";
            Text = "Configuration";
            FormClosing += configForm_FormClosing;
            panel_manage_config.ResumeLayout(false);
            panel_manage_config.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_manage_machine;
        private Button button_manage_notification;
        private Label label_last_change_time;
        private Label label1;
        private Button button_reset;
        private Button button_exit_config_launch_main;
        private Panel panel_manage_config;
        private Label label35;
        private Label label34;
        private CheckBox checkBox_SSL;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label39;
        private Label label38;
        private Label label37;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label40;
        private Label label42;
        private Label label41;
        private Label label43;
        private Label label44;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonAddMachine;
        private Panel panel1;
    }
}
