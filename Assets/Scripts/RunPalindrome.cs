using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class RunPalindrome
    {
        private Char[] universe;
        private string currentState;
        private char changeChar;
        private int position = 1;
        private Move stateMove;
        private char readAlphabet;

        PalindromeTransitionTbl tm;
        Dictionary<string, List<Transition2>> Table = new Dictionary<string, List<Transition2>>();
        List<Transition2> stateData = new List<Transition2>();

        public RunPalindrome(Dictionary<string, List<Transition2>> Table, char[] input, string currenSt)
        {
            this.universe = input;
            this.Table = Table;
            this.currentState = currenSt;
        }

        public char nextState()
        {
            List<Transition2> innerdict = Table[currentState];
            Transition2 t = innerdict.Find(x => x.alhpabet == universe[position]);
            readAlphabet = t.alhpabet;
            changeChar = t.changeChar;
            stateMove = t.move;
            universe[position] = changeChar;
            currentState = t.state;
            if (stateMove == Move.R)
            {
                position = position + 1;
            }
            else if (stateMove == Move.L)
            {
                position = position - 1;
            }

            return changeChar;
        }
        public Move last_Move()
        {
            return stateMove;
        }
        public string current_st()
        {
            if (currentState != "q7" && stateMove == Move.H)
            {
                currentState = null;
            }
            return currentState;
        }
        public int currentPosition()
        {
            return position;
        }
        public char _readChar()
        {
            return readAlphabet;
        }
    }
}
