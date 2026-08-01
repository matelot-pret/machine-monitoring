namespace mainApp
{
    public partial class MainForm : Form
    {
        private MainAppManager appManager;
        private MachineScreen machineScreen;
        private Notifier notifier;
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

            labelNoMachine.Visible = config.Machines.Count == 0;
            labelNotificationSettingsInfo.Visible = !config.Smtp.IsSMTPConfigValid();
            checkBoxAlwaysOnTop.Checked = true;
            labelMailFailed.Visible = false;
            TopMost = true;

            appManager.StartPings();
        }

        private void OnMailFailed(object? sender, EventArgs e)
        {
            BeginInvoke(new Action(() => labelMailFailed.Visible = true));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            appManager.StopPing();
            base.OnFormClosing(e);
        }

        private void checkBoxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = checkBoxAlwaysOnTop.Checked;
        }

        private void buttonLaunchConfig_Click(object sender, EventArgs e)
        {
            appManager.LaunchConfigApp();
        }

        private void buttonExitMainApp_Click(object sender, EventArgs e)
        {
            appManager.ExitApp();
        }
    }
}
