using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainApp
{
    public partial class MachineScreen : UserControl
    {
        private Config config = null!;
        public MachineScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Config config)
        {
            this.config = config;
        }

        private void AddMachineBloc(MachineConfig machine)
        {
            MachineBloc bloc = new MachineBloc(machine);
            flowLayoutPanel1.Controls.Add(bloc);
        }

        public void DisplayMonitoredMachine()
        {
            foreach(MachineConfig machine in config.Machines)
            {
                AddMachineBloc(machine);
            }
        }
    }
}
