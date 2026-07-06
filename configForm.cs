namespace configApp
{
    public partial class configForm : Form
    {
        private PanelManager panelManager;
        private ConfigAppManager appManager;
        private MachineScreen machineScreen;
        private bool isLoading = false;

        public configForm()
        {
            InitializeComponent();

            appManager = new ConfigAppManager();
            machineScreen = machineScreen1;
            machineScreen.Initialize(appManager.fileConfig.Configuration);
            machineScreen.MachineModified += OnMachineModified;
            isLoading = true;
            machineScreen.LoadMachines();
            isLoading = false;

            panelManager = new PanelManager(machineScreen, panel_manage_config);

            if (appManager.fileConfig.IsConfigFileExists())
            {
                labelLastChangeTime.Text = appManager.LastChangeInfo();
            }
        }

        private void button_manage_machine_Click(object sender, EventArgs e)
        {
            panelManager.Show(machineScreen);
        }

        private void button_manage_notification_Click(object sender, EventArgs e)
        {
            panelManager.Show(panel_manage_config);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            appManager.ResetConfig();
            machineScreen.ClearMachines();
        }

        private void button_exit_config_launch_main_Click(object sender, EventArgs e)
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
