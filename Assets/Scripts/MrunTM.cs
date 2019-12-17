using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class MrunTM
    {
        private Char[] universe;

        private char readAlphabet;
        private string currentState;
        private char changeChar;
        private int position = 1;
        private Move stateMove;

        MuzafarTM1 tm;
        Dictionary<string, List<Transition1>> Table = new Dictionary<string, List<Transition1>>();
        List<Transition1> stateData = new List<Transition1>();

        public MrunTM(Dictionary<string, List<Transition1>> Table, char[] input, string currenSt)
        {
            this.universe = input;
            this.Table = Table;
            this.currentState = currenSt;
        }

        public char nextState()
        {
            List<Transition1> innerdict = Table[currentState];
            Transition1 t = innerdict.Find(x => x.alhpabet == universe[position]);
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
        public char _readChar()
        {
            return readAlphabet;
        }
        public string current_st()
        {
            if (currentState != "q8" && stateMove == Move.H)
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
