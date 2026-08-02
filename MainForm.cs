namespace mainApp
{
    public partial class MainForm : Form
    {
        private MainAppManager appManager;
        private MachineScreen machineScreen;
        private Notifier notifier;

        /// <summary>
        /// wires the whole app: builds the manager, injects+populates the screen, 
        /// creates and subscribes the notifier, sets label visibility and always-on-top, 
        /// then starts the pings last.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            appManager = new MainAppManager();
            Config config = appManager.Config;

            machineScreen = machineScreen1;
            machineScreen.Initialize(config);
            machineScreen.DisplayMonitoredMachine();

            notifier = new Notifier(config.Smtp);
            notifier.MailFailed += OnMailFailed;
            notifier.SubscribeTo(config.Machines);

            labelNoMachine.Visible = config.HasOneMachine();
            labelNotificationSettingsInfo.Visible = !config.Smtp.IsSMTPConfigValid();
            checkBoxAlwaysOnTop.Checked = true;
            labelMailFailed.Visible = false;
            TopMost = true;

            appManager.StartPings();
        }

        /// <summary>
        /// reveals the "mail failed" label; marshals to the UI thread via 
        /// BeginInvoke (the failure comes from a ping thread).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnMailFailed(object? sender, EventArgs e)
        {
            BeginInvoke(new Action(() => labelMailFailed.Visible = true));
        }

        /// <summary>
        /// stops the ping threads before the window closes.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            appManager.StopPing();
            base.OnFormClosing(e);
        }

        /// <summary>
        /// mirroes the "always on top" checkbox into the form's TopMost
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxAlwaysOnTop.Checked;
        }

        /// <summary>
        /// launches configApp and exits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLaunchConfig_Click(object sender, EventArgs e)
        {
            appManager.LaunchConfigApp();
        }

        /// <summary>
        /// exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitMainApp_Click(object sender, EventArgs e)
        {
            appManager.ExitApp();
        }
    }
}
