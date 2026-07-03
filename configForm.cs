namespace configApp
{
    public partial class configForm : Form
    {
        PanelManager panelManager;
        ConfigAppManager appManager;

        public configForm()
        {
            InitializeComponent();
            panelManager = new PanelManager(panel_manage_machine, panel_manage_config);
            appManager = new ConfigAppManager();
        }

        private void button_manage_machine_Click(object sender, EventArgs e)
        {
            if (appManager.fileConfig.IsConfigFileExists())
            {
                MessageBox.Show(appManager.fileConfig.pathFile);
            }
            panelManager.Show(panel_manage_machine);
        }

        private void button_manage_notification_Click(object sender, EventArgs e)
        {
            panelManager.Show(panel_manage_config);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            appManager.fileConfig.DeleteConfigFile();
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
    }
}
