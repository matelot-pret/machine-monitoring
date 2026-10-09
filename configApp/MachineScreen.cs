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
        /// <summary>
        /// Events raised on add, remove or field changed
        /// </summary>
        public event EventHandler? MachineModified;

        private Config config = null!;//to tell to the compilator to don't check the nullable. It is implies that i must never forget the Initialize() method 
        
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
        /// <param name="config">the shared configuration whose machine are edited</param>
        public void Initialize(Config config)
        {
            this.config = config;
        }

        /// <summary>
        /// single birthplace of a bloc, creates a MachineControl, wires its DeleteRequested/Modified and adds
        /// it to the flow panel
        /// </summary>
        /// <param name="machine"> The machine to display </param>
        private void AddMachineBloc(MachineConfig machine)
        {
            MachineControl bloc = new MachineControl(machine);
            bloc.DeleteRequested += (sender, args) => RemoveMachine(bloc);
            bloc.Modified += (sender, args) => MachineModified?.Invoke(this, EventArgs.Empty);
            flowLayoutPanel.Controls.Add(bloc);
        }

        /// <summary>
        /// clears the panel and creates one bloc per configured machine; enabled the add button while under 8 machines
        /// </summary>
        public void LoadMachines()
        {
            flowLayoutPanel.Controls.Clear();
            foreach (MachineConfig machine in config.Machines)
            {
                AddMachineBloc(machine);
            }
            buttonAddMachine.Enabled = config.Machines.Count < 8;
        }

        /// <summary>
        /// creates a new empty machine(max 8) adds it to the config and a bloc for it, update the add button
        /// and raises MachineModified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// empties the panel and re-enables the add button
        /// </summary>
        public void ClearMachines()
        {
            flowLayoutPanel.Controls.Clear();
            buttonAddMachine.Enabled = true;
        }

        /// <summary>
        /// removes a machine from the config and its bloc from the panel, disposes the bloc, updates the add button
        /// and raises MachineModified
        /// </summary>
        /// <param name="bloc">the bloc to remove</param>
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
