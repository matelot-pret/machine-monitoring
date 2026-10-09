using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mainApp
{
    public partial class MachineBloc : UserControl
    {
        private readonly MachineConfig machine;

        /// <summary>
        /// builds the bloc for a machine: shows its name/IP, 
        /// paints the initial state, then subscribes to its StateChanged
        /// </summary>
        /// <param name="config">the machine to display(shared reference)</param>
        public MachineBloc(MachineConfig config)
        {
            InitializeComponent();
            machine = config;

            textBoxMachineName.Text = config.Name;
            textBoxMachineIpv4.Text = config.Ipv4Address;
            UpdateBlocState();

            machine.StateChanged += OnMachineStateChanged;

        }

        /// <summary>
        /// repaints the bloc when the machine's state changes; 
        /// marshals to the UI thread via Invoke since the event comes from a ping thread.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnMachineStateChanged(object? sender, StateChangedEvent args)
        {
            if (labelStateCommunication.InvokeRequired)//He will definitely speak in the ping's threads. The label is just to be precise for the later me
            {
                Invoke(new Action(UpdateBlocState));
            }
            else
            {
                UpdateBlocState();
            }
        }

        /// <summary>
        /// paints the state label from the machine's current state
        /// </summary>
        private void UpdateBlocState()
        {
            if(machine.State == CommunicationState.NonInitiated)
            {
                labelStateCommunication.Text = "Communication Not Initiate";
                labelStateCommunication.BackColor = Color.Gray;
                labelStateCommunication.ForeColor = Color.Black;
            }else if( machine.State == CommunicationState.Functional)
            {
                labelStateCommunication.Text = "Communication Functional";
                labelStateCommunication.BackColor = Color.LightGreen;
                labelStateCommunication.ForeColor = Color.Black;
            }
            else
            {
                labelStateCommunication.Text = "Communication Not Functional";
                labelStateCommunication.BackColor = Color.Red;
                labelStateCommunication.ForeColor = Color.White;
            }
        }
    }
}
