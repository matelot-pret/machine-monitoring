using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace configApp
{
    public partial class MachineControl : UserControl
    {
        private MachineConfig machine;

        public event EventHandler? Modified;
        public event EventHandler? DeleteRequested;
        public MachineControl(MachineConfig config)
        {
            InitializeComponent();
            machine = config;

            textBoxMachineName.Text = machine.Name;
            textBoxMachineIpv4.Text = machine.Ipv4Address;
            if(machine.PingRequestInterval >= numericUpDownMachineInterval.Minimum 
                && machine.PingRequestInterval <= numericUpDownMachineInterval.Maximum)
            {
                numericUpDownMachineInterval.Value = machine.PingRequestInterval;
            }

            textBoxMachineName.Leave += OnNameLeave;
            textBoxMachineIpv4.Leave += OnIpLeave;
            numericUpDownMachineInterval.ValueChanged += OnIntervalChanged;

            buttonDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);

            textBoxMachineIpv4.TextChanged += (s, e) =>
            {
                bool valid = machine.IsIpv4AddressValid(textBoxMachineIpv4.Text);
                textBoxMachineIpv4.BackColor = valid ? Color.White : Color.LightPink;
            };

            textBoxMachineName.TextChanged += (s, e) =>
            {
                bool valid = machine.IsNameValid(textBoxMachineName.Text);
                textBoxMachineName.BackColor = valid ? Color.White : Color.LightPink;
            };
        }
        public MachineConfig Machine
        {
            get { return machine; }
        }

        private void OnIpLeave(object? sender, EventArgs e)
        {
            machine.Ipv4Address = textBoxMachineIpv4.Text;
            Modified?.Invoke(this, EventArgs.Empty);
        }

        private void OnNameLeave(object? sender, EventArgs e)
        {
            machine.Name = textBoxMachineName.Text;
            Modified?.Invoke(this, EventArgs.Empty);
        }

        private void OnIntervalChanged(object? sender, EventArgs e)
        {
            machine.PingRequestInterval = (int)numericUpDownMachineInterval.Value;
            Modified?.Invoke(this, EventArgs.Empty);
        }

    }
}
