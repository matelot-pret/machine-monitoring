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

        /// <summary>builds an SMTP block with empty string fields (non-null).</summary>
        public SMTPConfig(){
            //to shut up the compilator
            smtpHost = String.Empty;
            password = String.Empty;
            senderMail = String.Empty;
            receiverMail = String.Empty;
        }
        /// <summary>
        /// get/set the host
        /// </summary>
        public String Host
        {
            get { return smtpHost; }
            set { smtpHost = value; }
        }

        /// <summary>
        /// get/set the port number
        /// </summary>
        public int NumPort
        {
            get { return port; }
            set { port = value; }
        }

        /// <summary>
        /// get/set the password
        /// </summary>
        public String Passwd
        {
            get { return password; }
            set { password = value; }
        }

        /// <summary>
        /// get/set the sender's mail address
        /// </summary>
        public String SenderMail
        {
            get { return senderMail; }
            set { senderMail = value; }
        }

        /// <summary>
        /// get/set the receiver's mail
        /// </summary>
        public String ReceiverMail
        {
            get { return receiverMail; }
            set { receiverMail = value; }
        }

        /// <summary>
        /// get/set if ssl is on or not
        /// </summary>
        public bool IsSSLOn
        {
            get { return isSSLOn; }
            set { isSSLOn = value; }
        }
        /// <summary>tells whether the host is non-empty</summary>
        /// <param name="candidate"> the string to check</param>
        /// <returns>true if not null or whitespace</returns>
        public static bool IsHostValid(string candidate)
        {
            return !String.IsNullOrWhiteSpace(candidate);
        }

        /// <summary> parses a textual port then validates its range. </summary>
        /// <param name="candidate" > the string to checks</param>
        /// <returns> true if it parses to an int in 1..65535.</returns>
        public static bool IsPortValid(string candidate)
        {
            return int.TryParse(candidate, out int parsed) && IsPortValid(parsed);
        }

        /// <summary>tells whether a port number is in the legal range</summary>
        /// <param name="candidate"> the number to checks</param>
        /// <returns>true if 1 <= candidate <= 65535 false otherwise</returns>
        public static bool IsPortValid(int candidate)
        {
            return candidate >= 1 && candidate <= 65535;
        }

        /// <summary> tells whether a string is a syntactically valid e-mail address. </summary>
        /// <param name="candidate"> the string to checks</param>
        /// <returns>true is the mail is syntactically valid</returns>
        public static bool IsMailValid(string candidate)
        {
            return MailAddress.TryCreate(candidate, out _);
        }

        /// <summary>tells whether a password is non-empty</summary>
        /// <param name="candidate"> the string to checks</param>
        /// <returns>true if not null/whitespace</returns>
        public static bool IsPasswdValid(string candidate)
        {
            //No need to check the length or characters; the password is provided by the SMTP client.
            return !String.IsNullOrWhiteSpace(candidate);
        }

        /// <summary> tells whether the whole SMTP block is usable.</summary>
        /// <returns>true if host, port, both mails and password are all valid.</returns>
        public bool IsSMTPConfigValid()
        {
            return IsHostValid(smtpHost) && IsPortValid(port)
                && IsMailValid(senderMail) && IsMailValid(receiverMail)
                && IsPasswdValid(Passwd);
        }

    }
}
