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
        public MachineControl(MachineConfig machine)
        {
            InitializeComponent();
            this.machine = machine;
        }

        private void MachineControl_Load(object sender, EventArgs e)
        {

        }

        public void CreateMachineConfigBloc(Panel panel)
        {

        }
    }
}
