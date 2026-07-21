namespace mainApp
{
    public partial class MainForm : Form
    {
        private MainAppManager appManager;
        public MainForm()
        {
            InitializeComponent();
            appManager = new MainAppManager();
            if(appManager.Config.Machines.Count > 0)
            {
                labelNoMachine.Visible = false;
            }
        }
    }
}
