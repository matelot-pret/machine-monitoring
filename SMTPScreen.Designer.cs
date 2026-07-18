namespace configApp
{
    partial class SMTPScreen
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
            SuspendLayout();
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label44.Location = new Point(303, 87);
            label44.Name = "label44";
            label44.Size = new Size(291, 20);
            label44.TabIndex = 33;
            label44.Text = "The smtp of the host that will sent the mail";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label43.Location = new Point(303, 170);
            label43.Name = "label43";
            label43.Size = new Size(326, 20);
            label43.TabIndex = 32;
            label43.Text = "The port from which the smtp will communicate";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label42.Location = new Point(303, 331);
            label42.Name = "label42";
            label42.Size = new Size(309, 20);
            label42.TabIndex = 31;
            label42.Text = "The mail from which notifications will be sent\r\n";
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label41.Location = new Point(303, 432);
            label41.Name = "label41";
            label41.Size = new Size(355, 20);
            label41.TabIndex = 30;
            label41.Text = "The password of the account linked to the smtp host";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.Location = new Point(303, 524);
            label40.Name = "label40";
            label40.Size = new Size(285, 20);
            label40.TabIndex = 29;
            label40.Text = "The mail that will receive the notifications";
            // 
            // textBoxReceiverMail
            // 
            textBoxReceiverMail.Location = new Point(494, 490);
            textBoxReceiverMail.Name = "textBoxReceiverMail";
            textBoxReceiverMail.PlaceholderText = "Enter the mail";
            textBoxReceiverMail.Size = new Size(165, 26);
            textBoxReceiverMail.TabIndex = 28;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(403, 397);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter the password";
            textBoxPassword.Size = new Size(162, 26);
            textBoxPassword.TabIndex = 27;
            // 
            // textBoxSenderMail
            // 
            textBoxSenderMail.Location = new Point(484, 296);
            textBoxSenderMail.Name = "textBoxSenderMail";
            textBoxSenderMail.PlaceholderText = "Enter the mail";
            textBoxSenderMail.Size = new Size(174, 26);
            textBoxSenderMail.TabIndex = 26;
            // 
            // checkBoxSSL
            // 
            checkBoxSSL.AutoSize = true;
            checkBoxSSL.Checked = true;
            checkBoxSSL.CheckState = CheckState.Checked;
            checkBoxSSL.Location = new Point(303, 238);
            checkBoxSSL.Name = "checkBoxSSL";
            checkBoxSSL.RightToLeft = RightToLeft.Yes;
            checkBoxSSL.Size = new Size(113, 22);
            checkBoxSSL.TabIndex = 25;
            checkBoxSSL.Text = "Activate SSL";
            checkBoxSSL.UseVisualStyleBackColor = true;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(358, 135);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "Enter the port";
            textBoxPort.Size = new Size(114, 26);
            textBoxPort.TabIndex = 24;
            // 
            // textBoxSmtp
            // 
            textBoxSmtp.Location = new Point(408, 54);
            textBoxSmtp.Name = "textBoxSmtp";
            textBoxSmtp.PlaceholderText = "Enter the SMTP host";
            textBoxSmtp.Size = new Size(174, 26);
            textBoxSmtp.TabIndex = 23;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(303, 493);
            label39.Name = "label39";
            label39.Size = new Size(166, 18);
            label39.TabIndex = 22;
            label39.Text = "Receiver Mail Address :";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(303, 401);
            label38.Name = "label38";
            label38.Size = new Size(82, 18);
            label38.TabIndex = 21;
            label38.Text = "Password :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(303, 299);
            label37.Name = "label37";
            label37.Size = new Size(153, 18);
            label37.TabIndex = 20;
            label37.Text = "Sender mail address :";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(303, 138);
            label35.Name = "label35";
            label35.Size = new Size(42, 18);
            label35.TabIndex = 19;
            label35.Text = "Port :";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(303, 58);
            label34.Name = "label34";
            label34.Size = new Size(88, 18);
            label34.TabIndex = 18;
            label34.Text = "SMTP Host :";
            // 
            // SMTPScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(label44);
            Controls.Add(label43);
            Controls.Add(label42);
            Controls.Add(label41);
            Controls.Add(label40);
            Controls.Add(textBoxReceiverMail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxSenderMail);
            Controls.Add(checkBoxSSL);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxSmtp);
            Controls.Add(label39);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(label35);
            Controls.Add(label34);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SMTPScreen";
            Size = new Size(953, 610);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label44;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private TextBox textBoxReceiverMail;
        private TextBox textBoxPassword;
        private TextBox textBoxSenderMail;
        private CheckBox checkBoxSSL;
        private TextBox textBoxPort;
        private TextBox textBoxSmtp;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label35;
        private Label label34;
    }
}
