namespace mainApp
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
            tableLayoutPanel = new TableLayoutPanel();
            labelNoMachine = new Label();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent));
            tableLayoutPanel.Size = new Size(0, 0);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelNoMachine
            // 
            labelNoMachine.AutoSize = true;
            labelNoMachine.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNoMachine.Location = new Point(4, 25);
            labelNoMachine.Margin = new Padding(4, 0, 4, 25);
            labelNoMachine.Name = "labelNoMachine";
            labelNoMachine.Size = new Size(761, 46);
            labelNoMachine.TabIndex = 3;
            labelNoMachine.Text = "There is no machine to monitore. \r\nUse \"Open Configuration\" button to launch the configuration and set Machine to monitor";
            labelNoMachine.TextAlign = ContentAlignment.TopCenter;
            // 
            // MachineScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(labelNoMachine);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Bahnschrift", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MachineScreen";
            Size = new Size(769, 96);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label labelNoMachine;
    }
}
