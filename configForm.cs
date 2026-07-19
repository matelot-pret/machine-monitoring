namespace configApp
{
    public partial class ConfigForm : Form
    {
        private readonly ScreenManager panelManager;
        private readonly ConfigAppManager appManager;
        private readonly MachineScreen machineScreen;
        private readonly SMTPScreen smtpScreen;
        private readonly bool isLoading;

        public ConfigForm()
        {
            InitializeComponent();

            appManager = new ConfigAppManager();
            machineScreen = machineScreen1;
            smtpScreen = smtpScreen1;
            machineScreen.Initialize(appManager.FileConfig.Configuration);
            smtpScreen.Initialize(appManager.FileConfig.Configuration);
            machineScreen.MachineModified += OnConfigModified;
            smtpScreen.SmtpModified += OnConfigModified;
            isLoading = true;
            machineScreen.LoadMachines();
            isLoading = false;

            panelManager = new ScreenManager(machineScreen, smtpScreen);

            if (appManager.FileConfig.IsConfigFileExists())
            {
                labelLastChangeTime.Text = appManager.LastChangeInfo();
            }

            RefreshControlsVisibility();
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
            smtpScreen.ClearFields();
            RefreshControlsVisibility();
        }

        private void buttonExitConfigLaunchMainClick(object sender, EventArgs e)
        {
            appManager.FileConfig.SaveConfigToJsonFile();
            ConfigAppManager.ExitAndLaunchMainApp();
        }

        private void configForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            appManager.FileConfig.SaveConfigToJsonFile();
        }

        private void OnConfigModified(object? sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            appManager.UpdateLastChangeTime();
            labelLastChangeTime.Text = appManager.LastChangeInfo();
            RefreshControlsVisibility();
            labelLastChangeTime.Visible = true;
        }

        private void RefreshControlsVisibility()
        {
            Config config = appManager.FileConfig.Configuration;
            bool configExists = appManager.FileConfig.IsConfigFileExists() || config.Machines.Count > 0
                || smtpScreen.HasData();
            //don't display useless elements
            buttonReset.Visible = configExists;
            labelLastChangeTime.Visible = configExists;
            buttonExitConfigLaunchMain.Visible = config.IsMachineConfigComplete();
        }

    }
}
