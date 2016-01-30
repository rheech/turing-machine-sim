// frmMain.cs, v1.0
// Cheong H Lee; 19 July 2013
//
// Contains main form class
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TuringMachineSimulator
{
    public partial class frmMain : Form
    {
        #region Variables
        private bool bMachineRunning;
        #endregion

        #region Constructors
        public frmMain()
        {
            InitializeComponent();
            bMachineRunning = false;
        }
        #endregion

        #region Event Handlers
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bMachineRunning)
            {
                bMachineRunning = true;
                turingMchine.StartMachine(txtInitString.Text);
            }
            else
            {
                turingMchine.StopMachine();
            }
        }

        private void turingMachine_StateChanged(bool isStarted)
        {
            if (isStarted)
            {
                bMachineRunning = true;
                btnStart.Text = "Stop";
            }
            else
            {
                bMachineRunning = false;
                btnStart.Text = "Start";
            }
        }
        #endregion
    }
}
