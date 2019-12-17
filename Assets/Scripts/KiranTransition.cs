using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{

    class KiranTransition
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
            tmStates.Add("q9");
            return tmStates;
        }


        private List<Transition3> state1Transition = new List<Transition3>() { new Transition3() { alhpabet = '0',state="q1",changeChar='Δ', move=Move.R},
                                                                            new Transition3() { alhpabet = '1',state="q1",changeChar='1', move=Move.H},
                                                                           new Transition3() { alhpabet = 'x',state="q8",changeChar='x', move=Move.R},
                                                                             new Transition3() { alhpabet = 'Δ',state="q0",changeChar='Δ', move=Move.H} };



        private List<Transition3> state2Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q1", changeChar = '0', move = Move.R },
                                                                             new Transition3() { alhpabet = '1',state = "q1",changeChar = '1', move = Move.R},
                                                                             new Transition3() { alhpabet = 'x',state = "q1",changeChar = 'x', move = Move.R},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q2",changeChar = 'Δ', move = Move.L}};


        private List<Transition3> state3Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q3", changeChar = 'Δ', move = Move.L } ,
                                                                             new Transition3() { alhpabet = '1',state = "q2",changeChar = '1', move = Move.H},
                                                                             new Transition3() { alhpabet = 'x',state = "q2",changeChar = 'x', move = Move.H},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q2",changeChar = 'Δ', move = Move.H} };



        private List<Transition3> state4Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q3", changeChar = '0', move = Move.L },
                                                                             new Transition3() { alhpabet = '1',state = "q3",changeChar = '1', move = Move.L},
                                                                             new Transition3() { alhpabet = 'x',state = "q3",changeChar = 'x', move = Move.L},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q4",changeChar = 'Δ', move = Move.R}};


        private List<Transition3> state5Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q4", changeChar = '0', move = Move.R } ,
                                                                             new Transition3() { alhpabet = '1',state = "q5",changeChar = 'x', move = Move.R},
                                                                             new Transition3() { alhpabet = 'x',state = "q4",changeChar = 'x', move = Move.R},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q4",changeChar = 'Δ', move = Move.H}};

        private List<Transition3> state6Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q5", changeChar = '0', move = Move.R },
                                                                             new Transition3() { alhpabet = '1',state = "q5",changeChar = '1', move = Move.R},
                                                                             new Transition3() { alhpabet = 'x',state = "q5",changeChar = 'x', move = Move.R},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q6",changeChar = 'Δ', move = Move.L} };

        private List<Transition3> state7Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q6", changeChar = '0', move = Move.L },
                                                                             new Transition3() { alhpabet = '1',state = "q7",changeChar = 'x', move = Move.L},
                                                                             new Transition3() { alhpabet = 'x',state = "q6",changeChar = 'x', move = Move.L},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q6",changeChar = 'Δ', move = Move.H} };


        private List<Transition3> state8Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q7", changeChar = '0', move = Move.L } ,
                                                                             new Transition3() { alhpabet = '1',state = "q7",changeChar = '1',   move = Move.L},
                                                                             new Transition3() { alhpabet = 'x',state = "q7",changeChar = 'x',   move = Move.L},
                                                                             new Transition3() { alhpabet = 'Δ',state = "q0",changeChar = 'Δ',   move = Move.R} };

        private List<Transition3> state9Transition = new List<Transition3>() { new Transition3() { alhpabet = '0', state = "q8", changeChar = '0', move = Move.H } ,
                                                                             new Transition3() { alhpabet = '1',state = "q8",changeChar = '1',   move = Move.H},
                                                                             new Transition3() { alhpabet = 'x', state = "q8", changeChar = 'x', move = Move.R },
                                                                             new Transition3() { alhpabet = 'Δ',state = "q9",changeChar = 'Δ',   move = Move.H} };



        private List<Transition3> state10Transition = new List<Transition3>() { new Transition3() { alhpabet = 'Δ', state = "q9", changeChar = 'Δ', move = Move.H } };



        public Dictionary<string, List<Transition3>> Transition_Dictionary;

        public Dictionary<string, List<Transition3>> add()
        {
            Transition_Dictionary = new Dictionary<string, List<Transition3>>() {
                { "q0", state1Transition},
                { "q1", state2Transition},
                { "q2", state3Transition},
                { "q3", state4Transition},
                { "q4", state5Transition},
                { "q5", state6Transition},
                { "q6", state7Transition},
                { "q7", state8Transition},
                { "q8", state9Transition},
                { "q9", state10Transition}
             };
            currentstate = "q0";
            return Transition_Dictionary;
        }


    }
}


public struct Transition3
{
    public char alhpabet { get; set; }
    public string state { get; set; }
    public char changeChar { get; set; }
    public Move move { get; set; }
}


