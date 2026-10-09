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
        private Config config = null!;
        private FieldBinder binder = null!;
        //null! to tell to the compilator that it is initialized outside the constructor before use. It is implies that i must never forget the Initialize() method 

        public event EventHandler? SmtpModified;

        /// <summary>
        /// builds the control(config injected via Initialize)
        /// </summary>
        public SMTPScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// injects the shared config, prefills the six controls, then binds them
        /// </summary>
        /// <param name="config">the configuration whose SMTP block is edited.</param>
        public void Initialize(Config config)
        {
            this.config = config;//can accept any config, usefull for test
            binder = new FieldBinder();

            textBoxSmtp.Text = config.Smtp.Host;
            textBoxPort.Text = config.Smtp.NumPort == 0 ? "" : config.Smtp.NumPort.ToString();
            textBoxSenderMail.Text = config.Smtp.SenderMail;
            textBoxPassword.Text = config.Smtp.Passwd;
            textBoxReceiverMail.Text = config.Smtp.ReceiverMail;
            checkBoxSSL.Checked = config.Smtp.IsSSLOn;

            binder.FieldStored += (sender, args) => SmtpModified?.Invoke(this, EventArgs.Empty);
            binder.Bind(textBoxSmtp, SMTPConfig.IsHostValid, hostValue => config.Smtp.Host = hostValue);
            binder.Bind(textBoxPort, SMTPConfig.IsPortValid, portValue => { int.TryParse(portValue, out int port); config.Smtp.NumPort = port; });
            binder.Bind(textBoxSenderMail, SMTPConfig.IsMailValid, mail => config.Smtp.SenderMail = mail);
            binder.Bind(textBoxPassword, SMTPConfig.IsPasswdValid, password => config.Smtp.Passwd = password);
            binder.Bind(textBoxReceiverMail, SMTPConfig.IsMailValid, mail => config.Smtp.ReceiverMail = mail);

            checkBoxSSL.CheckedChanged += OnSslChanged;
        }
        
        /// <summary>
        /// empties the five textboxes and unchecks the SSL box
        /// </summary>
        public void ClearFields()
        {
            textBoxSmtp.Clear();
            textBoxPort.Clear();
            textBoxSenderMail.Clear();
            textBoxPassword.Clear();
            textBoxReceiverMail.Clear();
            checkBoxSSL.Checked = false;
        }

        /// <summary>
        /// mirrors the SSL checkbox into the config and raises SmtpModified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSslChanged(object? sender, EventArgs e)
        {
            config.Smtp.IsSSLOn = checkBoxSSL.Checked;
            SmtpModified?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// tells whether the user has entered any SMTP data
        /// </summary>
        /// <returns>true if any textbox is non-empty or SSL is checked</returns>
        /// <note> reads the controls (screen-side), not the stored config.</note>
        public bool HasData()
        {
            return !String.IsNullOrEmpty(textBoxSmtp.Text) || !String.IsNullOrEmpty(textBoxPort.Text)
                || !String.IsNullOrEmpty(textBoxSenderMail.Text) || !String.IsNullOrEmpty(textBoxReceiverMail.Text)
                || !String.IsNullOrEmpty(textBoxPassword.Text) || checkBoxSSL.Checked;
        }

    }
}
