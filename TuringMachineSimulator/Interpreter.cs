// Interpreter.cs, v1.0
// Cheong H Lee; 19 July 2013
//
// Contains interpreter for translating
// turing machine command statements into the actions.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuringMachineSimulator
{
    class Interpreter
    {
        private struct Statement
        {
            public int CurrentState;
            public char CurrentChar;
            public int ReplaceState;
            public char ReplaceChar;
            public int Direction;
        }

        #region Variables
        public const char SYMBOL_SMDELTA = '\u03B4';
        private Statement[] stmt;
        private int stmtCnt;
        #endregion

        #region Constructor/Methods
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Interpreter()
        {
            stmt = new Statement[stmtCnt];
        }

        /// <summary>
        /// Add statement to intepreter
        /// </summary>
        /// <param name="statement">Statement to add</param>
        public void AddStatement(string statement)
        {
            // skip if empty statement
            if (statement.Trim().Length == 0)
                return;

            // Parse statement
            // 1. Split "="
            // 2. Split "," for left and right side of "="
            // 3. Put parsed information to Statement structure.
            string[] sChunk;
            string[] left, right;
            Statement newStatement = new Statement();

            sChunk = statement.Split('=');

            sChunk[0] = sChunk[0].Trim();
            sChunk[1] = sChunk[1].Trim();

            left = sChunk[0].Split(',');
            right = sChunk[1].Split(',');

            // Remove delta and parenthesis
            left[0] = left[0].Trim().Substring(2);
            left[1] = left[1].Trim();
            left[1] = left[1].Substring(0, left[1].Length - 1);

            newStatement.CurrentState = int.Parse(left[0]);
            newStatement.CurrentChar = left[1].Trim()[0];

            // Remove parenthesis
            right[0] = right[0].Trim().Substring(1);
            right[1] = right[1].Trim();
            right[2] = right[2].Trim();
            right[2] = right[2].Substring(0, right[2].Length - 1);

            // If Final state, replace to "0"
            if (right[0][0] != 'F')
            {
                newStatement.ReplaceState = int.Parse(right[0]);
            }
            else
            {
                newStatement.ReplaceState = 0;
            }

            newStatement.ReplaceChar = right[1].Trim()[0];

            right[2] = right[2].Trim();

            // Parse direction (-1: Left, 1: Right)
            if (right[2][0] == 'L')
            {
                newStatement.Direction = -1;
            }
            else if (right[2][0] == 'R')
            {
                newStatement.Direction = 1;
            }
            else
            {
                newStatement.Direction = 0;
            }

            // Put information to Statement
            Array.Resize<Statement>(ref stmt, ++stmtCnt);
            stmt[stmtCnt - 1] = newStatement;
        }

        /// <summary>
        /// Translate statement into action
        /// </summary>
        /// <param name="currentState">(in) Current state of Turing Machine</param>
        /// <param name="currentChar">(in) Current symbol of Turing Machine</param>
        /// <param name="newState">(out) New state from translated statement</param>
        /// <param name="newChar">(out) New symbol from translated statement</param>
        /// <param name="direction">(out) Direction from translated statement</param>
        /// <param name="currentStatement">(out) Formatted current statement to display</param>
        /// <returns>True if translation succeed</returns>
        public bool Interpret(int currentState, char currentChar,
                ref int newState, ref char newChar, ref int direction,
                ref string currentStatement)
        {
            char tempDirection;

            // Find statement
            foreach (Statement ss in stmt)
            {
                // If found
                if (ss.CurrentState == currentState &&
                        ss.CurrentChar == currentChar)
                {
                    // Return translated statement to variables
                    newState = ss.ReplaceState;
                    newChar = ss.ReplaceChar;
                    direction = ss.Direction;

                    // Translate direction into statement
                    // to display
                    if (direction > 0)
                    {
                        tempDirection = 'R';
                    }
                    else if (direction < 0)
                    {
                        tempDirection = 'L';
                    }
                    else
                    {
                        tempDirection = 'N';
                    }

                    // Write statement to display
                    currentStatement = String.Format("{5}({0}, {1}) = ({2}, {3}, {4})",
                                    currentState, currentChar, newState,
                                    newChar, tempDirection, SYMBOL_SMDELTA);
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}
