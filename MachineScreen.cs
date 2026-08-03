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

        /// <summary>
        /// builds the control 
        /// </summary>
        public MachineScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// injects the shared configuration
        /// </summary>
        /// <param name="config">The configuration to display</param>
        public void Initialize(Config config)
        {
            this.config = config;
            labelNoMachine.Visible = !config.HasOneMachine();
        }

        /// <summary>
        /// creates a machine bloc for the machine and adds it to the flow panel
        /// </summary>
        /// <param name="machine">the machine to display</param>
        private void AddMachineBloc(MachineConfig machine)
        {
            MachineBloc bloc = new MachineBloc(machine);
            tableLayoutPanel.Controls.Add(bloc);
        }

        /// <summary>
        /// creates one bloc per machine in the config
        /// </summary>
        public void DisplayMonitoredMachine()
        {
            foreach (MachineConfig machine in config.Machines)
            {
                AddMachineBloc(machine);
            }
        }
    }
}
