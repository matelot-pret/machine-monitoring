namespace mainApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            machineScreen1 = new MachineScreen();
            labelNoMachine = new Label();
            SuspendLayout();
            // 
            // machineScreen1
            // 
            machineScreen1.Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineScreen1.Location = new Point(78, 13);
            machineScreen1.Margin = new Padding(3, 4, 3, 4);
            machineScreen1.Name = "machineScreen1";
            machineScreen1.Size = new Size(854, 734);
            machineScreen1.TabIndex = 0;
            // 
            // labelNoMachine
            // 
            labelNoMachine.AutoSize = true;
            labelNoMachine.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoMachine.Location = new Point(150, 348);
            labelNoMachine.Margin = new Padding(4, 0, 4, 0);
            labelNoMachine.Name = "labelNoMachine";
            labelNoMachine.Size = new Size(761, 46);
            labelNoMachine.TabIndex = 2;
            labelNoMachine.Text = "There is no machine to monitore. \r\nUse \"Open Configuration\" button to launch the configuration and set Machine to monitore";
            labelNoMachine.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 830);
            Controls.Add(labelNoMachine);
            Controls.Add(machineScreen1);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MachineScreen machineScreen1;
        private Label labelNoMachine;
    }
}
