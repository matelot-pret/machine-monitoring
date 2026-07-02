namespace configApp
{
    public partial class configForm : Form
    {
        PanelManager panelManager;

        public configForm()
        {
            InitializeComponent();
            panelManager = new PanelManager(panel_manage_machine, panel_manage_config);
        }

        private void button_manage_machine_Click(object sender, EventArgs e)
        {
            panelManager.Show(panel_manage_machine);
        }

        private void button_manage_notification_Click(object sender, EventArgs e)
        {
            panelManager.Show(panel_manage_config);
        }
    }
}
