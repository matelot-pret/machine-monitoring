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

        private Config config = null!;//to tell to the compilator to don't check the nullable. It is implies that i must never forget the Initialize() method 
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
            MachineControl bloc = new MachineControl(machine);
            bloc.DeleteRequested += (sender, args) => RemoveMachine(bloc);
            bloc.Modified += (sender, args) => MachineModified?.Invoke(this, EventArgs.Empty);
            flowLayoutPanel.Controls.Add(bloc);
        }

        public void LoadMachines()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (MachineConfig machine in config.Machines)
            {
                AddMachineBloc(machine);
            }
            buttonAddMachine.Enabled = config.Machines.Count < 8;
        }

        private void buttonAddMachine_Click(object? sender, EventArgs e)
        {
            if (config.Machines.Count >= 8)
            {
                return;
            }

            MachineConfig machine = new MachineConfig();
            config.AddMachineConfig(machine);

            AddMachineBloc(machine);

            buttonAddMachine.Enabled = config.Machines.Count < 8;
            MachineModified?.Invoke(this, EventArgs.Empty);
        }

        public void ClearMachines()
        {
            flowLayoutPanel.Controls.Clear();
            buttonAddMachine.Enabled = true;
        }

        private void RemoveMachine(MachineControl bloc)
        {
            config.DeleteMachineConfig(bloc.Machine);
            flowLayoutPanel.Controls.Remove(bloc);
            bloc.Dispose();
            buttonAddMachine.Enabled = config.Machines.Count < 8;
            MachineModified?.Invoke(this, EventArgs.Empty);//executes all abonned methods
        }
    }
}
