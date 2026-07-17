namespace configApp
{
    public partial class configForm : Form
    {
        private PanelManager panelManager;
        private ConfigAppManager appManager;
        private MachineScreen machineScreen;
        private SMTPScreen smtpScreen;
        private bool isLoading = false;

        public configForm()
        {
            InitializeComponent();

            appManager = new ConfigAppManager();
            machineScreen = machineScreen1;
            smtpScreen = smtpScreen1;
            machineScreen.Initialize(appManager.fileConfig.Configuration);
            machineScreen.MachineModified += OnMachineModified;
            isLoading = true;
            machineScreen.LoadMachines();
            isLoading = false;

            panelManager = new PanelManager(machineScreen, smtpScreen);

            if (appManager.fileConfig.IsConfigFileExists())
            {
                labelLastChangeTime.Text = appManager.LastChangeInfo();
            }
        }

        private void buttonManageMachineClick(object sender, EventArgs e)
        {
            panelManager.Show(machineScreen);
        }

        private void buttonManageNotificationClick(object sender, EventArgs e)
        {
            panelManager.Show(smtpScreen);
        }

        private void buttonResetClick(object sender, EventArgs e)
        {
            appManager.ResetConfig();
            machineScreen.ClearMachines();
        }

        private void buttonExitConfigLaunchMainClick(object sender, EventArgs e)
        {
            appManager.fileConfig.SaveConfigToJsonFile();
            appManager.ExitAndLaunchMainApp();
        }

        private void configForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appManager.fileConfig.SaveConfigToJsonFile();
        }

        private void OnMachineModified(object? sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            appManager.UpdateLastChangeTime();
            labelLastChangeTime.Text = appManager.LastChangeInfo();
        }

    }
}
