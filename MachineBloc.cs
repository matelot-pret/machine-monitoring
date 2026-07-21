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

        public MachineBloc(MachineConfig config)
        {
            InitializeComponent();
            machine = config;

            textBoxMachineName.Text = config.Name;
            textBoxMachineIpv4.Text = config.Ipv4Address;
            UpdateBlocState();

            machine.StateChanged += OnMachineStateChanged;

        }

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
