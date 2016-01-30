// SourceControl.cs, v1.0
// Cheong H Lee; 19 July 2013
//
// SourceControl control derived from TextBox.
// Supports Ctrl + D to input diamond symbol.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TuringMachineSimulator
{
    public partial class SourceControl : TextBox
    {
        #region Variables/Constants
        private bool isCtrlPressed;
        private bool isHandled;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public SourceControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for container
        /// </summary>
        /// <param name="container"></param>
        public SourceControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Keydown event to determine if ctrl key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void this_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                isCtrlPressed = true;
            }
            else
            {
                isCtrlPressed = false;
            }

            if (e.KeyData == (Keys.Control | Keys.A))
            {
                this.SelectionStart = 0;
                this.SelectionLength = this.Text.Length;
                e.Handled = true;
                isHandled = true;
            }
        }
        
        /// <summary>
        /// Keypress event to mount Ctrl + D into diamond symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void this_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isCtrlPressed)
            {
                if (e.KeyChar == 4) // Ctrl + D
                {
                    e.KeyChar = TuringMachine.SYMBOL_START;
                }
                else if (e.KeyChar == 5) // Ctrl + E
                {
                    e.KeyChar = Interpreter.SYMBOL_SMDELTA;
                }
            }

            e.Handled = isHandled;
            isHandled = false;
        }
        #endregion
    }
}
