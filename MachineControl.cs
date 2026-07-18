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
        private FieldBinder binder;

        public event EventHandler? Modified;
        public event EventHandler? DeleteRequested;
        public MachineControl(MachineConfig config)
        {
            InitializeComponent();
            machine = config;
            binder = new FieldBinder();
            binder.FieldChanged += (sender, args) => RefreshValidityLabel();

            textBoxMachineName.Text = machine.Name;
            textBoxMachineIpv4.Text = machine.Ipv4Address;
            if(machine.PingRequestInterval >= numericUpDownMachineInterval.Minimum 
                && machine.PingRequestInterval <= numericUpDownMachineInterval.Maximum)
            {
                numericUpDownMachineInterval.Value = machine.PingRequestInterval;
            }

            numericUpDownMachineInterval.ValueChanged += OnIntervalChanged;

            buttonDelete.Click += (sender, args) => DeleteRequested?.Invoke(this, EventArgs.Empty);

            binder.FieldStored += (sender, args) => Modified?.Invoke(this, EventArgs.Empty);
            binder.Bind(textBoxMachineName, MachineConfig.IsNameValid, val => machine.Name = val);
            binder.Bind(textBoxMachineIpv4, MachineConfig.IsIpv4AddressValid, val => machine.Ipv4Address = val);

            // Handlers are wired after the prefill, so the label was never painted : do it once here.
            RefreshValidityLabel();
        }
        public MachineConfig Machine
        {
            get { return machine; }
        }

        private void OnIntervalChanged(object? sender, EventArgs e)
        {
            machine.PingRequestInterval = (int)numericUpDownMachineInterval.Value;
            Modified?.Invoke(this, EventArgs.Empty);
            RefreshValidityLabel();
        }

        private bool IsMachineValid()
        {
            return MachineConfig.IsNameValid(textBoxMachineName.Text)
                && MachineConfig.IsIpv4AddressValid(textBoxMachineIpv4.Text)
                && MachineConfig.IsPingRequestIntervalValid((int)numericUpDownMachineInterval.Value);
        }

        private void RefreshValidityLabel()
        {
            bool valid = IsMachineValid();
            if (valid)
            {
                labelIsValid.BackColor = Color.MediumSeaGreen;
                labelIsValid.Text = "Valid Machine";
            }
            else
            {
                labelIsValid.BackColor = Color.IndianRed;
                labelIsValid.Text = " Invalid Machine";
            }
        }

    }
}
