using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace configApp
{
    public partial class MachineScreen : UserControl
    {

        public event EventHandler? MachineModified;

        private Config config;
        public MachineScreen()
        {
            InitializeComponent();
        }

        public void Initialize(Config config)
        {
            this.config = config;
        }

        public void LoadMachines()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (MachineConfig machine in config.Machines)
            {
                MachineControl bloc = new MachineControl(machine);
                bloc.DeleteRequested += (s, ev) => RemoveMachine(bloc);
                bloc.Modified += (s, ev) => MachineModified?.Invoke(this, EventArgs.Empty);
                flowLayoutPanel.Controls.Add(bloc);
            }
            buttonAddMachine.Enabled = config.Machines.Count < 8;
        }

        private void buttonAddMachine_Click(object? sender, EventArgs e)
        {
            if(config.Machines.Count >= 8)
            {
                return;
            }

            MachineConfig machine = new MachineConfig();
            config.AddMachine(machine);

            MachineControl bloc = new MachineControl(machine);
            bloc.DeleteRequested += (s, ev) => RemoveMachine(bloc);
            bloc.Modified += (s, ev) => MachineModified?.Invoke(this, EventArgs.Empty);
            flowLayoutPanel.Controls.Add(bloc);

            buttonAddMachine.Enabled = config.Machines.Count < 8;
        }

        public void ClearMachines()
        {
            flowLayoutPanel.Controls.Clear();
            buttonAddMachine.Enabled = true;
        }

        private void RemoveMachine(MachineControl bloc)
        {
            config.DeleteMachine(bloc.Machine);
            flowLayoutPanel.Controls.Remove(bloc);
            bloc.Dispose();
            buttonAddMachine.Enabled = config.Machines.Count < 8;
        }

    }
}
