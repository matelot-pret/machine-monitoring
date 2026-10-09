using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace mainApp
{
    public class Notifier
    {
        private readonly SMTPConfig smtp;

        private const int MailTimeOut = 10000;

        /// <summary>
        /// raised when a mail could not be sent.
        /// </summary>
        public event EventHandler? MailFailed;

        /// <summary>
        /// stores the SMTP settings used to send mails
        /// </summary>
        /// <param name="smtp">the SMTP configuration</param>
        public Notifier(SMTPConfig smtp)
        {
            this.smtp = smtp;
        }

        /// <summary>
        /// subscribe to each machine's StateChanged
        /// </summary>
        /// <param name="machines">the monitored machines</param>
        public void SubscribeTo(List<MachineConfig> machines)
        {
            foreach(MachineConfig machine in machines)
            {
                machine.StateChanged += OnMachineStateChanged;
            }
        }

        /// <summary>
        /// on a state change, sends a mail if the transition warrants it. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMachineStateChanged(object? sender, StateChangedEvent args)
        {

            if(sender is MachineConfig machine && ShouldSendMail(args.Old, args.NewOne))
            {
                SendMail(machine);
            }
        }

        /// <summary>
        /// tells whether a transition warrants a mail.
        /// </summary>
        /// <param name="old">the old state</param>
        /// <param name="newOne">the new state</param>
        /// <returns>true only for Functional↔NonFunctional (neither state is NonInitiated, and they differ).</returns>
        public static bool ShouldSendMail(CommunicationState old, CommunicationState newOne)
        {
            return (old != CommunicationState.NonInitiated && newOne != CommunicationState.NonInitiated) 
                && old != newOne;
        }

        /// <summary>
        /// ends a notification mail about the machine's new state via the native SmtpClient
        /// </summary>
        /// <param name="machine"> the machine whose state changed.</param>
        /// <notes>any failure is caught and reported through MailFailed (no crash, no popup).</notes>
        public void SendMail(MachineConfig machine)
        {
            try
            {
                using (SmtpClient client = new SmtpClient(smtp.Host, smtp.NumPort))
                using (MailMessage message = new MailMessage(smtp.SenderMail, smtp.ReceiverMail))
                {
                    client.EnableSsl = smtp.IsSSLOn;
                    client.Credentials = new NetworkCredential(smtp.SenderMail, smtp.Passwd);
                    client.Timeout = MailTimeOut;

                    message.Subject = $"Machine {machine.Name} : {machine.State}";
                    message.Body = $"The machine {machine.Name} ({machine.Ipv4Address}) is now {machine.State}";

                    client.Send(message);
                }
            }
            catch (Exception)
            {
                if (MailFailed != null)
                {
                    MailFailed(this, EventArgs.Empty);
                }
            }
        }
    }
}
