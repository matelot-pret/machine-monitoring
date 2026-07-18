using System;
using System.Collections.Generic;
using System.Net.Mail;
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
            set { smtpHost = value; }
        }

        public int NumPort
        {
            get { return port; }
            set { port = value; }
        }

        public String Passwd
        {
            get { return password; }
            set { password = value; }
        }

        public String SenderMail
        {
            get { return senderMail; }
            set { senderMail = value; }
        }

        public String ReceiverMail
        {
            get { return receiverMail; }
            set { receiverMail = value; }
        }

        public bool IsSSLOn
        {
            get { return isSSLOn; }
            set { isSSLOn = value; }
        }

        public static bool IsHostValid(string candidate)
        {
            return !String.IsNullOrWhiteSpace(candidate);
        }

        public static bool IsPortValid(string candidate)
        {
            return int.TryParse(candidate, out int parsed) && IsPortValid(parsed);
        }

        public static bool IsPortValid(int candidate)
        {
            return candidate >= 1 && candidate <= 65535;
        }

        public static bool IsMailValid(string candidate)
        {
            return MailAddress.TryCreate(candidate, out _);
        }

        public static bool IsPasswdValid(string candidate)
        {
            //TODO : sofisticate
            return !String.IsNullOrWhiteSpace(candidate);
        }

        public bool IsValid()
        {
            return IsHostValid(smtpHost) && IsPortValid(port)
                && IsMailValid(senderMail) && IsMailValid(receiverMail)
                && IsPasswdValid(Passwd);
        }

    }
}
