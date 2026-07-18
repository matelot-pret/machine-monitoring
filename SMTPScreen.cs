using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace configApp
{
    public partial class SMTPScreen : UserControl
    {
        private Config config;

        public event EventHandler? SmtpModified;
        public SMTPScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Config config)
        {
            this.config = config;

            textBoxSmtp.Text = config.Smtp.Host;
            textBoxPort.Text = config.Smtp.NumPort.ToString();
            textBoxSenderMail.Text = config.Smtp.SenderMail;
            textBoxPassword.Text = config.Smtp.Passwd;
            textBoxReceiverMail.Text = config.Smtp.ReceiverMail;
            checkBoxSSL.Checked = config.Smtp.IsSSLOn;

            textBoxSmtp.TextChanged += (s, e) => {
                bool valid = SMTPConfig.IsHostValid(textBoxSmtp.Text);
                textBoxSmtp.BackColor = valid ? Color.White : Color.LightPink;
            };

            textBoxPort.TextChanged += (s, e) =>
            {
                bool valid = SMTPConfig.IsPortValid(textBoxPort.Text);
                textBoxPort.BackColor = valid ? Color.White : Color.LightPink;
            };

            textBoxSenderMail.TextChanged += (s, e) =>
            {
                bool valid = SMTPConfig.IsMailValid(textBoxSenderMail.Text);
                textBoxSenderMail.BackColor = valid ? Color.White : Color.LightPink;
            };

            textBoxReceiverMail.TextChanged += (s, e) =>
            {
                bool valid = SMTPConfig.IsMailValid(textBoxReceiverMail.Text);
                textBoxReceiverMail.BackColor = valid ? Color.White : Color.LightPink;
            };

            textBoxPassword.TextChanged += (s, e) =>
            {
                bool valid = SMTPConfig.IsPasswdValid(textBoxPassword.Text);
                textBoxPassword.BackColor = valid ? Color.White : Color.LightPink;
            };
        }

        public void ClearFields()
        {
            textBoxSmtp.Clear();
            textBoxPort.Clear();
            textBoxSenderMail.Clear();
            textBoxPassword.Clear();
            textBoxReceiverMail.Clear();
            checkBoxSSL.Checked = true;
        }

    }
}
