namespace TuringMachineSimulator
{
    partial class TuringMachineForm
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
            this.components = new System.ComponentModel.Container();
            this.scBack = new System.Windows.Forms.SplitContainer();
            this.lblTMGui = new TuringMachineSimulator.TuringMachine(this.components);
            this.scBackBottom = new System.Windows.Forms.SplitContainer();
            this.scBackBottomLeft = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentStatement = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtMachineStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimerInterval = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPreset = new System.Windows.Forms.ComboBox();
            this.grpSourceCode = new System.Windows.Forms.GroupBox();
            this.txtSource = new TuringMachineSimulator.SourceControl(this.components);
            this.tmrInterpret = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scBack)).BeginInit();
            this.scBack.Panel1.SuspendLayout();
            this.scBack.Panel2.SuspendLayout();
            this.scBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBackBottom)).BeginInit();
            this.scBackBottom.Panel1.SuspendLayout();
            this.scBackBottom.Panel2.SuspendLayout();
            this.scBackBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBackBottomLeft)).BeginInit();
            this.scBackBottomLeft.Panel1.SuspendLayout();
            this.scBackBottomLeft.Panel2.SuspendLayout();
            this.scBackBottomLeft.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.grpSourceCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // scBack
            // 
            this.scBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBack.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBack.IsSplitterFixed = true;
            this.scBack.Location = new System.Drawing.Point(0, 0);
            this.scBack.Name = "scBack";
            this.scBack.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBack.Panel1
            // 
            this.scBack.Panel1.Controls.Add(this.lblTMGui);
            // 
            // scBack.Panel2
            // 
            this.scBack.Panel2.Controls.Add(this.scBackBottom);
            this.scBack.Size = new System.Drawing.Size(581, 350);
            this.scBack.SplitterDistance = 94;
            this.scBack.TabIndex = 0;
            this.scBack.TabStop = false;
            // 
            // lblTMGui
            // 
            this.lblTMGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTMGui.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Bold);
            this.lblTMGui.Location = new System.Drawing.Point(0, 0);
            this.lblTMGui.Name = "lblTMGui";
            this.lblTMGui.Size = new System.Drawing.Size(581, 94);
            this.lblTMGui.State = 1;
            this.lblTMGui.TabIndex = 0;
            this.lblTMGui.Text = "TuringMachine\r\n↑";
            // 
            // scBackBottom
            // 
            this.scBackBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBackBottom.IsSplitterFixed = true;
            this.scBackBottom.Location = new System.Drawing.Point(0, 0);
            this.scBackBottom.Name = "scBackBottom";
            // 
            // scBackBottom.Panel1
            // 
            this.scBackBottom.Panel1.Controls.Add(this.scBackBottomLeft);
            // 
            // scBackBottom.Panel2
            // 
            this.scBackBottom.Panel2.Controls.Add(this.grpSourceCode);
            this.scBackBottom.Size = new System.Drawing.Size(581, 252);
            this.scBackBottom.SplitterDistance = 284;
            this.scBackBottom.TabIndex = 0;
            this.scBackBottom.TabStop = false;
            // 
            // scBackBottomLeft
            // 
            this.scBackBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBackBottomLeft.IsSplitterFixed = true;
            this.scBackBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.scBackBottomLeft.Name = "scBackBottomLeft";
            this.scBackBottomLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBackBottomLeft.Panel1
            // 
            this.scBackBottomLeft.Panel1.Controls.Add(this.groupBox1);
            // 
            // scBackBottomLeft.Panel2
            // 
            this.scBackBottomLeft.Panel2.Controls.Add(this.lblTimerInterval);
            this.scBackBottomLeft.Panel2.Controls.Add(this.label4);
            this.scBackBottomLeft.Panel2.Controls.Add(this.tbSpeed);
            this.scBackBottomLeft.Panel2.Controls.Add(this.label3);
            this.scBackBottomLeft.Panel2.Controls.Add(this.cboPreset);
            this.scBackBottomLeft.Size = new System.Drawing.Size(284, 252);
            this.scBackBottomLeft.SplitterDistance = 133;
            this.scBackBottomLeft.TabIndex = 0;
            this.scBackBottomLeft.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCurrentStatement);
            this.groupBox1.Controls.Add(this.lblCurrent);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtMachineStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(107, 101);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(138, 20);
            this.txtResult.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Acceptor Result:";
            // 
            // txtCurrentStatement
            // 
            this.txtCurrentStatement.Location = new System.Drawing.Point(107, 75);
            this.txtCurrentStatement.Name = "txtCurrentStatement";
            this.txtCurrentStatement.ReadOnly = true;
            this.txtCurrentStatement.Size = new System.Drawing.Size(138, 20);
            this.txtCurrentStatement.TabIndex = 5;
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(6, 78);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(95, 13);
            this.lblCurrent.TabIndex = 4;
            this.lblCurrent.Text = "Current Statement:";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(107, 23);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(138, 20);
            this.txtState.TabIndex = 1;
            // 
            // txtMachineStatus
            // 
            this.txtMachineStatus.Location = new System.Drawing.Point(107, 49);
            this.txtMachineStatus.Name = "txtMachineStatus";
            this.txtMachineStatus.ReadOnly = true;
            this.txtMachineStatus.Size = new System.Drawing.Size(138, 20);
            this.txtMachineStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "State:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Machine Status:";
            // 
            // lblTimerInterval
            // 
            this.lblTimerInterval.AutoSize = true;
            this.lblTimerInterval.Location = new System.Drawing.Point(208, 33);
            this.lblTimerInterval.Name = "lblTimerInterval";
            this.lblTimerInterval.Size = new System.Drawing.Size(25, 13);
            this.lblTimerInterval.TabIndex = 4;
            this.lblTimerInterval.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Speed:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(56, 33);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(146, 45);
            this.tbSpeed.TabIndex = 3;
            this.tbSpeed.Value = 5;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Presets:";
            // 
            // cboPreset
            // 
            this.cboPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPreset.FormattingEnabled = true;
            this.cboPreset.Items.AddRange(new object[] {
            "(Select Preset)",
            "a^n b^n c^n : n >= 1",
            "a^n b c^n : n > 0"});
            this.cboPreset.Location = new System.Drawing.Point(56, 6);
            this.cboPreset.Name = "cboPreset";
            this.cboPreset.Size = new System.Drawing.Size(146, 21);
            this.cboPreset.TabIndex = 1;
            this.cboPreset.SelectedIndexChanged += new System.EventHandler(this.cboPreset_SelectedIndexChanged);
            // 
            // grpSourceCode
            // 
            this.grpSourceCode.Controls.Add(this.txtSource);
            this.grpSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSourceCode.Location = new System.Drawing.Point(0, 0);
            this.grpSourceCode.Name = "grpSourceCode";
            this.grpSourceCode.Size = new System.Drawing.Size(293, 252);
            this.grpSourceCode.TabIndex = 0;
            this.grpSourceCode.TabStop = false;
            this.grpSourceCode.Text = "Source Code";
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(3, 16);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSource.Size = new System.Drawing.Size(287, 233);
            this.txtSource.TabIndex = 0;
            this.txtSource.TextChanged += new System.EventHandler(this.txtSource_TextChanged);
            // 
            // tmrInterpret
            // 
            this.tmrInterpret.Interval = 500;
            this.tmrInterpret.Tick += new System.EventHandler(this.tmrInterpret_Tick);
            // 
            // TuringMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scBack);
            this.Name = "TuringMachineForm";
            this.Size = new System.Drawing.Size(581, 350);
            this.Load += new System.EventHandler(this.TuringMachineForm_Load);
            this.scBack.Panel1.ResumeLayout(false);
            this.scBack.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBack)).EndInit();
            this.scBack.ResumeLayout(false);
            this.scBackBottom.Panel1.ResumeLayout(false);
            this.scBackBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBackBottom)).EndInit();
            this.scBackBottom.ResumeLayout(false);
            this.scBackBottomLeft.Panel1.ResumeLayout(false);
            this.scBackBottomLeft.Panel2.ResumeLayout(false);
            this.scBackBottomLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBackBottomLeft)).EndInit();
            this.scBackBottomLeft.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.grpSourceCode.ResumeLayout(false);
            this.grpSourceCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scBack;
        private TuringMachine lblTMGui;
        private System.Windows.Forms.SplitContainer scBackBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtMachineStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSourceCode;
        private System.Windows.Forms.SplitContainer scBackBottomLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPreset;
        private System.Windows.Forms.Timer tmrInterpret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbSpeed;
        private SourceControl txtSource;
        private System.Windows.Forms.Label lblTimerInterval;
        private System.Windows.Forms.TextBox txtCurrentStatement;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label5;

    }
}
