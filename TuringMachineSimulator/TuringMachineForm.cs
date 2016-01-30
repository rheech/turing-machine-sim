// TuringMachineForm.cs, v1.0
// Cheong H Lee; 19 July 2013
//
// Main control form of Turing Machine
// derived from UserControl.
// Allows control the Turing Machine.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TuringMachineSimulator
{
    public partial class TuringMachineForm : UserControl
    {
        #region Variables
        private bool isUserTypedSourceCode;
        private Interpreter inpt;
        #endregion

        #region User-Defined EventHandler (Machine State Changed)
        public delegate void pStateChanged(bool isStarted);
        public event pStateChanged StateChanged;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TuringMachineForm()
        {
            InitializeComponent();
            inpt = new Interpreter();
            txtSource.Font = new Font("Courier New", 9);
            cboPreset.SelectedIndex = 0;
            grpSourceCode.Text =
                String.Format("Source Code (Ctrl + E to input \"{0}\", Ctrl + D for \"{1}\")",
                        Interpreter.SYMBOL_SMDELTA, TuringMachine.SYMBOL_START);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Start Machine
        /// </summary>
        /// <param name="text"></param>
        public void StartMachine(string text)
        {
            lblTMGui.SetText(text);
            txtResult.BackColor = txtState.BackColor;
            txtResult.ForeColor = Color.Black;
            txtResult.Text = "";
            
            inpt = new Interpreter();

            foreach (string ss in txtSource.Text.Replace("\r\n", "\n").Split('\n'))
            {
                inpt.AddStatement(ss);
            }

            StateChanged(true);
            tmrInterpret.Enabled = true;
        }

        /// <summary>
        /// Stop machine
        /// </summary>
        public void StopMachine()
        {
            tmrInterpret.Enabled = false;
            txtMachineStatus.Text = "Stopped";
            StateChanged(false);
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Form load event to set Turing Machine text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TuringMachineForm_Load(object sender, EventArgs e)
        {
            lblTMGui.SetText("");
        }

        /// <summary>
        /// Combo box changed event (predefined source code)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            switch (cboPreset.SelectedIndex)
            {
                case 0:
                    sb.Clear();
                    break;
                case 1:
                    sb.AppendFormat("{0}(1, a) = (2, x, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(2, b) = (3, y, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, z) = (4, z, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, x) = (1, x, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(1, y) = (5, y, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, b) = (3, b, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, b) = (4, b, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(5, y) = (5, y, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(2, a) = (2, a, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, z) = (3, z, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, y) = (4, y, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(5, z) = (5, z, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(2, y) = (2, y, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, c) = (4, z, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, a) = (4, a, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(5, {1}) = (F, {1}, L)",
                            Interpreter.SYMBOL_SMDELTA, '\u25CA');
                    break;
                case 2:
                    sb.AppendFormat("{0}(1, a) = (3, x, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(2, a) = (3, x, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, a) = (3, a, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, b) = (3, b, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, c) = (4, z, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, b) = (4, b, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, a) = (4, a, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, x) = (2, x, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, b) = (3, b, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(3, z) = (3, z, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(4, z) = (4, z, L)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(2, b) = (5, b, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(5, z) = (5, z, R)\r\n", Interpreter.SYMBOL_SMDELTA);
                    sb.AppendFormat("{0}(5, {1}) = (F, {1}, L)",
                            Interpreter.SYMBOL_SMDELTA, '\u25CA');
                    break;
                default:
                    sb.Clear();
                    break;
            }

            if (!isUserTypedSourceCode)
            {
                txtSource.Text = sb.ToString();
            }
        }

        /// <summary>
        /// Timer to visualize translating each statement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrInterpret_Tick(object sender, EventArgs e)
        {
            int newState = 0;
            char newChar = '\0';
            int direction = 0;
            string currentStatement = "";

            if (inpt.Interpret(lblTMGui.State, lblTMGui.Symbol,
                        ref newState, ref newChar, ref direction, ref currentStatement))
            {
                lblTMGui.ReplaceSymbol(newChar);
                lblTMGui.State = newState;

                if (direction > 0)
                {
                    lblTMGui.GoRight();
                }
                else if (direction < 0)
                {
                    lblTMGui.GoLeft();
                }

                txtState.Text = lblTMGui.State.ToString();
                txtCurrentStatement.Text = currentStatement;

                if (newState == 0)
                {
                    tmrInterpret.Enabled = false;
                    txtMachineStatus.Text = "Halted";
                    txtResult.Text = "Accepted";
                    txtResult.BackColor = Color.FromArgb(0, 128, 0);
                    txtResult.ForeColor = Color.White;
                    StateChanged(false);
                }
                else
                {
                    txtMachineStatus.Text = "Running";
                }
            }
            else
            {
                txtMachineStatus.Text = "No instruction available.";
                txtResult.Text = "Declined";
                txtResult.BackColor = Color.FromArgb(128, 0, 0);
                txtResult.ForeColor = Color.White;
                tmrInterpret.Enabled = false;
                StateChanged(false);
            }
        }

        /// <summary>
        /// Control to adjust timer interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            int[] tbValues = { 50, 100, 200, 300, 400, 500, 1000, 1500, 2000, 3000, 5000 };

            tmrInterpret.Interval = tbValues[tbSpeed.Value];
            lblTimerInterval.Text = tmrInterpret.Interval.ToString();
        }

        /// <summary>
        /// Text change event on source textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            if (txtSource.Focused)
            {
                isUserTypedSourceCode = true;
                cboPreset.SelectedIndex = 0;
                isUserTypedSourceCode = false;
            }
        }
        #endregion
    }
}
