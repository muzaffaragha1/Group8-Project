using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{

    class MuzafarTM1 
    {
        public char symbol = 'Δ';
        public string currentstate;
        public List<string> tmStates = new List<string>();

        public List<string> States()
        {
            tmStates.Add("q0");
            tmStates.Add("q1");
            tmStates.Add("q2");
            tmStates.Add("q3");
            tmStates.Add("q4");
            tmStates.Add("q5");
            tmStates.Add("q6");
            tmStates.Add("q7");
            tmStates.Add("q8");
                    return tmStates;
        }

        private List<Transition1> state0Transition = new List<Transition1>() { //Accepting
                                                                               new Transition1() { alhpabet = 'a', state = "q1",  changeChar='X', move=Move.R},
                                                                               new Transition1() { alhpabet = 'b', state = "q4",  changeChar='Z', move=Move.R},
                                                                               new Transition1() { alhpabet = 'X', state = "q7",  changeChar='X', move=Move.R},
                                                                               //Rejecting
                                                                               new Transition1() { alhpabet = 'Z', state = "q0",  changeChar='Z', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q0",  changeChar='Δ', move=Move.H}};
                                                                              

        private List<Transition1> state1Transition = new List<Transition1>() { new Transition1() { alhpabet = 'a', state = "q1",  changeChar='a', move=Move.R},
                                                                               new Transition1() { alhpabet = 'b', state = "q1",  changeChar='b', move=Move.R},
                                                                               new Transition1() { alhpabet = 'X', state = "q1",  changeChar='X', move=Move.R},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q2",  changeChar='Δ', move=Move.L},

                                                                               new Transition1() { alhpabet = 'Z', state = "q1",  changeChar='Z', move=Move.H}
        };

        private List<Transition1> state2Transition = new List<Transition1>() { new Transition1() { alhpabet = 'a', state = "q3",  changeChar='X', move=Move.L},
                                                                               new Transition1() { alhpabet = 'X', state = "q2",  changeChar='X', move=Move.L},

                                                                               new Transition1() { alhpabet = 'b', state = "q2",  changeChar='b', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Z', state = "q2",  changeChar='Z', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q2",  changeChar='Δ', move=Move.H}};

        private List<Transition1> state3Transition = new List<Transition1>() { new Transition1() { alhpabet = 'a', state = "q3",  changeChar='a', move=Move.L},
                                                                               new Transition1() { alhpabet = 'b', state = "q3",  changeChar='b', move=Move.L},
                                                                               new Transition1() { alhpabet = 'X', state = "q0",  changeChar='X', move=Move.R},

                                                                               new Transition1() { alhpabet = 'Z', state = "q3",  changeChar='Z', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q3",  changeChar='Δ', move=Move.H}};

        private List<Transition1> state4Transition = new List<Transition1>() { new Transition1() { alhpabet = 'b', state = "q4",  changeChar='b', move=Move.R},
                                                                               new Transition1() { alhpabet = 'X', state = "q4",  changeChar='X', move=Move.R},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q5",  changeChar='Δ', move=Move.L},

                                                                               new Transition1() { alhpabet = 'Z', state = "q4",  changeChar='Z', move=Move.H},
                                                                               new Transition1() { alhpabet = 'a', state = "q4",  changeChar='a', move=Move.H} };

        private List<Transition1> state5Transition = new List<Transition1>() { new Transition1() { alhpabet = 'b', state = "q6",  changeChar='b', move=Move.L},
                                                                               new Transition1() { alhpabet = 'X', state = "q6",  changeChar='Δ', move=Move.L},
                                                                               new Transition1() { alhpabet = 'Z', state = "q7",  changeChar='Δ', move=Move.R},

                                                                               new Transition1() { alhpabet = 'a', state = "q5",  changeChar='a', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q5",  changeChar='Δ', move=Move.H}};

        private List<Transition1> state6Transition = new List<Transition1>() { new Transition1() { alhpabet = 'b', state = "q6",  changeChar='b', move=Move.L},
                                                                               new Transition1() { alhpabet = 'X', state = "q6",  changeChar='X', move=Move.L},
                                                                               new Transition1() { alhpabet = 'Z', state = "q0",  changeChar='Z', move=Move.R},

                                                                               new Transition1() { alhpabet = 'a', state = "q5",  changeChar='a', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q5",  changeChar='Δ', move=Move.H}};

        private List<Transition1> state7Transition = new List<Transition1>() { new Transition1() { alhpabet = 'X', state = "q7",  changeChar='X', move=Move.R},
                                                                               new Transition1() { alhpabet = 'Δ', state = "q8",  changeChar='Δ', move=Move.H},

                                                                               new Transition1() { alhpabet = 'b', state = "q7",  changeChar='b', move=Move.H},
                                                                               new Transition1() { alhpabet = 'Z', state = "q7",  changeChar='Z', move=Move.H},
                                                                               new Transition1() { alhpabet = 'a', state = "q7",  changeChar='a', move=Move.H}};

        private List<Transition1> state8Transition = new List<Transition1>() { new Transition1() { alhpabet = 'Δ', state = "q8", changeChar = 'Δ', move = Move.H }};

        public Dictionary<string, List<Transition1>> Transition_Dictionary;

        public Dictionary<string, List<Transition1>> add()
        {
            Transition_Dictionary = new Dictionary<string, List<Transition1>>() {
                { "q0", state0Transition},
                { "q1", state1Transition},
                { "q2", state2Transition},
                { "q3", state3Transition},
                { "q4", state4Transition},
                { "q5", state5Transition},
                { "q6", state6Transition},
                { "q7", state7Transition},
                { "q8", state8Transition},
             };
            currentstate = "q0";
            return Transition_Dictionary;
        }


    }
}


public enum Move
{
    L, R, H
}
public struct Transition1
{
    public char alhpabet { get; set; }
    public string state { get; set; }
    public char changeChar { get; set; }
    public Move move { get; set; }
}

