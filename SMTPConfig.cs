using System;
using System.Collections.Generic;
using System.Text;

namespace configApp
{
    public class SMTPConfig
    {
        private String smtpHost;
        private int port;
        private String password;
        private String senderMail;
        private String receiverMail;
        private bool isSSLOn;

        public SMTPConfig(){}

        public String Host
        {
            get { return smtpHost; }
            set { if (!String.IsNullOrWhiteSpace(value)) smtpHost = value; }
        }

        public int NumPort
        {
            get { return port; }
            set { if (value != 0) port = value; }
        }

        public String Passwd
        {
            get { return password; }
            set { if (password != null) password = value; }
        }

        public String SenderMail
        {
            get { return senderMail; }
            set { if (!String.IsNullOrWhiteSpace(value)) senderMail = value; }
        }

        public String ReceiverMail
        {
            get { return senderMail; }
            set { if (!String.IsNullOrWhiteSpace(value)) receiverMail = value; }
        }

        public bool IsSSLOn
        {
            get { return isSSLOn; }
            set { isSSLOn = value; }
        }


    }
}
