// TuringMachine.cs, v1.0
// Cheong H Lee; 19 July 2013
//
// Turing Machine Control derived from Label
// for visualizing Turing Machine.
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TuringMachineSimulator
{
    public partial class TuringMachine : Label
    {
        #region Shared Symbols (Constants)
        public const char SYMBOL_ARROWUP = '\u2191';
        public const char SYMBOL_START = '\u25CA';
        #endregion

        #region Variables/Constants
        private StringBuilder sb;
        private char[] cStrings;
        private int iPointer;
        private int iState;
        #endregion

        #region Constructors and Private Methods
        /// <summary>
        /// Default Constructor
        /// </summary>
        public TuringMachine()
        {
            InitializeVariables();
            InitializeComponent();
        }

        /// <summary>
        /// Constructor for container
        /// </summary>
        /// <param name="container"></param>
        public TuringMachine(IContainer container)
        {
            container.Add(this);
            InitializeVariables();
            InitializeComponent();
        }

        /// <summary>
        /// Initialize private variables
        /// (initial state to 1, pointer to 1)
        /// </summary>
        private void InitializeVariables()
        {
            sb = new System.Text.StringBuilder();
            iPointer = 1;
            iState = 1;
        }

        /// <summary>
        /// Update graphical component to
        /// visualize the Turing Machine.
        /// </summary>
        private void UpdateGraphics()
        {
            sb.Clear();
            sb.AppendFormat("{0}\r\n", new string(cStrings));
            sb.AppendFormat("{0}{1}", new string(' ', iPointer), SYMBOL_ARROWUP);
            this.Text = sb.ToString();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Set text to Turing Machine
        /// </summary>
        /// <param name="text">Text to set</param>
        public void SetText(string text)
        {
            InitializeVariables();
            cStrings = String.Format("{0}{1}{0}", SYMBOL_START, text).ToCharArray();
            UpdateGraphics();
        }

        /// <summary>
        /// Replace current symbol in the Turing Machine.
        /// </summary>
        /// <param name="rep">Symbol to replace into.</param>
        public void ReplaceSymbol(char rep)
        {
            if (cStrings != null &&
                    Symbol != rep)
            {
                cStrings[iPointer] = rep;
                UpdateGraphics();
            }
        }

        /// <summary>
        /// Move Turing Machine's pointer to right
        /// </summary>
        public void GoRight()
        {
            iPointer++;
            UpdateGraphics();
        }

        /// <summary>
        /// Move Turing Machine's pointer to left
        /// </summary>
        public void GoLeft()
        {
            // if pointer is not out of bound
            if (iPointer > 0)
            {
                iPointer--;
                UpdateGraphics();
            }
        }
        #endregion

        #region Properties
        /// <summary>
        /// Current state of the Turing Machine
        /// </summary>
        public int State
        {
            get
            {
                return iState;
            }
            set
            {
                iState = value;
            }
        }

        /// <summary>
        /// Current symbol of the Turing Machine
        /// </summary>
        public char Symbol
        {
            get
            {
                if (cStrings != null &&
                        iPointer < cStrings.Length)
                {
                    return cStrings[iPointer];
                }

                // return start/end symbol if out of bound
                return SYMBOL_START;
            }
        }
        #endregion
    }
}
