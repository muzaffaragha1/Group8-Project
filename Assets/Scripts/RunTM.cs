using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class RunTM
    {
        private Char[] universe;

        private string currentState;
        private char changeChar;
        private int position = 1;
        private Move stateMove;
        private char readAlphabet;

        TuringMachine tm;
        Dictionary<string, List<Transition>> Table = new Dictionary<string, List<Transition>>();
        List<Transition> stateData = new List<Transition>();

        public RunTM(Dictionary<string, List<Transition>> Table, char[] input, string currenSt)
        {
            this.universe = input;
            this.Table = Table;
            this.currentState = currenSt;
        }

        public char nextState()
        {
            List<Transition> innerdict = Table[currentState];
            Transition t = innerdict.Find(x => x.alhpabet == universe[position]);
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

        public char _readChar()
        {
            return readAlphabet;
        }

        public Move last_Move()
        {
            return stateMove;
        }
        public string current_st()
        {
            if (currentState != "q17" && stateMove == Move.H)
            {
                currentState = null;
            }
            return currentState;
        }
        public int currentPosition()
        {
            return position;
        }
    }
}
