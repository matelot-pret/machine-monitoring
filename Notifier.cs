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

        public event EventHandler? MailFailed;

        public Notifier(SMTPConfig smtp)
        {
            this.smtp = smtp;
        }

        public void SubscribeTo(List<MachineConfig> machines)
        {
            foreach(MachineConfig machine in machines)
            {
                machine.StateChanged += OnMachineStateChanged;
            }
        }

        private void OnMachineStateChanged(object? sender, StateChangedEvent args)
        {

            if(sender is MachineConfig machine && ShouldSendMail(args.Old, args.NewOne))
            {
                SendMail(machine);
            }
        }

        private static bool ShouldSendMail(CommunicationState old, CommunicationState newOne)
        {
            return (old != CommunicationState.NonInitiated && newOne != CommunicationState.NonInitiated) 
                && old != newOne;
        }

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
