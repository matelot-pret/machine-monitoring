namespace configApp
{
    public partial class ConfigForm : Form
    {
        private readonly ScreenManager panelManager;
        private readonly ConfigAppManager appManager;
        private readonly MachineScreen machineScreen;
        private readonly SMTPScreen smtpScreen;
        private readonly bool isLoading;

        /// <summary>
        /// builds the app: creates the manager, injects the config into both screens, 
        /// wires their modified events, loads machines (guarded by isLoading),
        /// builds the ScreenManager, and refreshes visibility.
        /// </summary>
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

            labelLastChangeTime.Visible = appManager.FileConfig.Configuration.Machines.Count > 0;

            RefreshControlsVisibility();
        }

        /// <summary>
        /// show the machine screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManageMachineClick(object sender, EventArgs e)
        {
            panelManager.Show(machineScreen);
        }

        /// <summary>
        /// show the smtp screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonManageNotificationClick(object sender, EventArgs e)
        {
            panelManager.Show(smtpScreen);
        }

        /// <summary>
        /// resets the config, clears all screens and refreshs visibility
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetClick(object sender, EventArgs e)
        {
            appManager.ResetConfig();
            machineScreen.ClearMachines();
            smtpScreen.ClearFields();
            RefreshControlsVisibility();
        }

        /// <summary>
        /// saves the config to file then launches mainApp and exits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitConfigLaunchMainClick(object sender, EventArgs e)
        {
            appManager.FileConfig.SaveConfigToJsonFile();
            ConfigAppManager.ExitAndLaunchMainApp();
        }

        /// <summary>
        /// saves the config to file on window close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ConfigExists())
            {
                appManager.FileConfig.SaveConfigToJsonFile();
            }
        }

        /// <summary>
        /// on any machine/SMTP change (unless loading), 
        /// updates the timestamp, its label, the controls visibility, and reveals the timestamp label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnConfigModified(object? sender, EventArgs e)
        {
            if (isLoading)
            {
                return;
            }
            appManager.UpdateLastChangeTime();
            labelLastChangeTime.Text = appManager.LastChangeInfo();
            RefreshControlsVisibility();
        }


        /// <summary>
        /// shows/hides reset button, timestamp label (if config exists or has data) 
        /// and the exit&launch button (if the config is complete). 
        /// </summary>
        private void RefreshControlsVisibility()
        {
            bool configExists = ConfigExists();
            //don't display useless elements
            buttonReset.Visible = configExists;
            labelLastChangeTime.Visible = configExists;
            Config config = appManager.FileConfig.Configuration;
            buttonExitConfigLaunchMain.Visible = config.IsMachineConfigComplete();
        }

        /// <summary>
        /// tells whether a configuration exists in any form : a saved file, 
        /// at least one machine, or SMTP data entered on screen
        /// </summary>
        /// <returns>true if there is something worth saving or resetting</returns>
        private bool ConfigExists()
        {
            return appManager.FileConfig.IsConfigFileExists()
                || appManager.FileConfig.Configuration.Machines.Count > 0
                || smtpScreen.HasData();
        }
    }
}
