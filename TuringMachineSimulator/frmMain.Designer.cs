namespace TuringMachineSimulator
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtInitString = new System.Windows.Forms.TextBox();
            this.lblInitString = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.turingMchine = new TuringMachineSimulator.TuringMachineForm();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtInitString);
            this.splitContainer1.Panel1.Controls.Add(this.lblInitString);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.turingMchine);
            this.splitContainer1.Size = new System.Drawing.Size(584, 412);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtInitString
            // 
            this.txtInitString.Location = new System.Drawing.Point(85, 12);
            this.txtInitString.Name = "txtInitString";
            this.txtInitString.Size = new System.Drawing.Size(135, 20);
            this.txtInitString.TabIndex = 1;
            // 
            // lblInitString
            // 
            this.lblInitString.AutoSize = true;
            this.lblInitString.Location = new System.Drawing.Point(12, 15);
            this.lblInitString.Name = "lblInitString";
            this.lblInitString.Size = new System.Drawing.Size(67, 13);
            this.lblInitString.TabIndex = 0;
            this.lblInitString.Text = "Initial String: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(226, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // turingMchine
            // 
            this.turingMchine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turingMchine.Location = new System.Drawing.Point(0, 0);
            this.turingMchine.Name = "turingMchine";
            this.turingMchine.Size = new System.Drawing.Size(584, 365);
            this.turingMchine.TabIndex = 0;
            this.turingMchine.StateChanged += new TuringMachineSimulator.TuringMachineForm.pStateChanged(this.turingMachine_StateChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turing Machine Simulator - Cheong Lee";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtInitString;
        private System.Windows.Forms.Label lblInitString;
        private System.Windows.Forms.Button btnStart;
        private TuringMachineForm turingMchine;









    }
}

