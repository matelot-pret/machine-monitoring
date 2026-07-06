namespace configApp
{
    partial class MachineScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            buttonAddMachine = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(3, 69);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(1165, 531);
            flowLayoutPanel.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(581, 30);
            label1.Name = "label1";
            label1.Size = new Size(475, 20);
            label1.TabIndex = 0;
            label1.Text = "Machine to monitor. The maximum number of machine to monitor is 8\r\n";
            // 
            // buttonAddMachine
            // 
            buttonAddMachine.Location = new Point(17, 16);
            buttonAddMachine.Name = "buttonAddMachine";
            buttonAddMachine.Size = new Size(129, 47);
            buttonAddMachine.TabIndex = 0;
            buttonAddMachine.Text = "+ add a machine configuration";
            buttonAddMachine.UseVisualStyleBackColor = true;
            buttonAddMachine.Click += buttonAddMachine_Click;
            // 
            // MachineScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(buttonAddMachine);
            Name = "MachineScreen";
            Size = new Size(1171, 603);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonAddMachine;
        private Label label1;
    }
}
