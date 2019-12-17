using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    class TuringMachine
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
            tmStates.Add("q10");
            tmStates.Add("q11");
            tmStates.Add("q12");
            tmStates.Add("q13");
            tmStates.Add("q14");
            tmStates.Add("q15");
            tmStates.Add("q16");
            tmStates.Add("q17");

            return tmStates;
        }

        private List<Transition> state0Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q1",  changeChar='X', move=Move.R},
                                                                             new Transition() { alhpabet = 'b', state = "q8",  changeChar='Y', move=Move.R},
                                                                             new Transition() { alhpabet = '#', state = "q15", changeChar='#', move=Move.R}};

        private List<Transition> state1Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q1",  changeChar='a', move=Move.R},
                                                                             new Transition() { alhpabet = 'b', state = "q1",  changeChar='b', move=Move.R},
                                                                             new Transition() { alhpabet = '#', state = "q2",  changeChar='#', move=Move.R}};

        private List<Transition> state2Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q3",  changeChar='X', move=Move.R},
                                                                             new Transition() { alhpabet = 'X', state = "q2",  changeChar='X', move=Move.R},
                                                                             new Transition() { alhpabet = 'Y', state = "q2",  changeChar='Y', move=Move.R}};

        private List<Transition> state3Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q3",  changeChar='a', move=Move.R},
                                                                             new Transition() { alhpabet = 'b', state = "q3",  changeChar='b', move=Move.R},
                                                                             new Transition() { alhpabet = '#', state = "q4",  changeChar='#', move=Move.R}};

        private List<Transition> state4Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q5",  changeChar='X', move=Move.L},
                                                                             new Transition() { alhpabet = 'b', state = "q4",  changeChar='a', move=Move.H},
                                                                             new Transition() { alhpabet = 'X', state = "q4",  changeChar='X', move=Move.R},
                                                                             new Transition() { alhpabet = 'Y', state = "q4",  changeChar='Y', move=Move.R}};

        private List<Transition> state5Transition = new List<Transition>() { new Transition() { alhpabet = '#', state = "q6",  changeChar='#', move=Move.L},
                                                                             new Transition() { alhpabet = 'X', state = "q5",  changeChar='X', move=Move.L},
                                                                             new Transition() { alhpabet = 'Y', state = "q5",  changeChar='Y', move=Move.L}};

        private List<Transition> state6Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q6",  changeChar='a', move=Move.L},
                                                                             new Transition() { alhpabet = 'b', state = "q6",  changeChar='b', move=Move.L},
                                                                             new Transition() { alhpabet = '#', state = "q7",  changeChar='#', move=Move.L},
                                                                             new Transition() { alhpabet = 'X', state = "q6",  changeChar='X', move=Move.L},
                                                                             new Transition() { alhpabet = 'Y', state = "q6",  changeChar='Y', move=Move.L}};

        private List<Transition> state7Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q7",  changeChar='a', move=Move.L},
                                                                             new Transition() { alhpabet = 'b', state = "q7",  changeChar='b', move=Move.L},
                                                                             new Transition() { alhpabet = 'X', state = "q0",  changeChar='X', move=Move.R}};

        private List<Transition> state8Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q8",  changeChar='a', move=Move.R},
                                                                             new Transition() { alhpabet = 'b', state = "q8",  changeChar='b', move=Move.R},
                                                                             new Transition() { alhpabet = '#', state = "q9",  changeChar='#', move=Move.R}};

        private List<Transition> state9Transition = new List<Transition>() { new Transition() { alhpabet = 'b', state = "q10",  changeChar='Y', move=Move.R},
                                                                             new Transition() { alhpabet = 'X', state = "q9",   changeChar='X', move=Move.R},
                                                                             new Transition() { alhpabet = 'Y', state = "q9",   changeChar='Y', move=Move.R}};

        private List<Transition> state10Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q10",  changeChar='a', move=Move.R},
                                                                              new Transition() { alhpabet = 'b', state = "q10",  changeChar='b', move=Move.R},
                                                                              new Transition() { alhpabet = '#', state = "q11",  changeChar='#', move=Move.R}};

        private List<Transition> state11Transition = new List<Transition>() { new Transition() { alhpabet = 'b', state = "q12",  changeChar='Y', move=Move.L},
                                                                              new Transition() { alhpabet = 'X', state = "q11",  changeChar='X', move=Move.R},
                                                                              new Transition() { alhpabet = 'Y', state = "q11",  changeChar='Y', move=Move.R}};

        private List<Transition> state12Transition = new List<Transition>() { new Transition() { alhpabet = '#', state = "q13",  changeChar='#', move=Move.L},
                                                                              new Transition() { alhpabet = 'X', state = "q12",  changeChar='X', move=Move.L},
                                                                              new Transition() { alhpabet = 'Y', state = "q12",  changeChar='Y', move=Move.L}};

        private List<Transition> state13Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q13",  changeChar='a', move=Move.L},
                                                                              new Transition() { alhpabet = 'b', state = "q13",  changeChar='b', move=Move.L},
                                                                              new Transition() { alhpabet = '#', state = "q14",  changeChar='#', move=Move.L},
                                                                              new Transition() { alhpabet = 'X', state = "q13",  changeChar='X', move=Move.L},
                                                                              new Transition() { alhpabet = 'Y', state = "q13",  changeChar='Y', move=Move.L}};

        private List<Transition> state14Transition = new List<Transition>() { new Transition() { alhpabet = 'a', state = "q14",  changeChar='a', move=Move.L},
                                                                              new Transition() { alhpabet = 'b', state = "q14",  changeChar='b', move=Move.L},
                                                                              new Transition() { alhpabet = 'Y', state = "q0",   changeChar='Y', move=Move.R}};

        private List<Transition> state15Transition = new List<Transition>() { new Transition() { alhpabet = '#', state = "q16",  changeChar='#', move=Move.R},
                                                                              new Transition() { alhpabet = 'X', state = "q15",  changeChar='X', move=Move.R},
                                                                              new Transition() { alhpabet = 'Y', state = "q15",  changeChar='Y', move=Move.R}};

        private List<Transition> state16Transition = new List<Transition>() { new Transition() { alhpabet = 'X', state = "q16",  changeChar='X', move=Move.R},
                                                                              new Transition() { alhpabet = 'Y', state = "q16",  changeChar='Y', move=Move.R},
                                                                              new Transition() { alhpabet = 'Δ', state = "q17",  changeChar='Δ', move=Move.H}};

        private List<Transition> state17Transition = new List<Transition>() { new Transition() { alhpabet = 'Δ', state = "q17",  changeChar= 'Δ', move=Move.H}};



        public Dictionary<string, List<Transition>> Transition_Dictionary;
        public Dictionary<string, List<Transition>> add()
        {
            Transition_Dictionary = new Dictionary<string, List<Transition>>() {
                { "q0", state0Transition},
                { "q1", state1Transition},
                { "q2", state2Transition},
                { "q3", state3Transition},
                { "q4", state4Transition},
                { "q5", state5Transition},
                { "q6", state6Transition},
                { "q7", state7Transition},
                { "q8", state8Transition},
                { "q9", state9Transition},
                { "q10", state10Transition},
                { "q11", state11Transition},
                { "q12", state12Transition},
                { "q13", state13Transition},
                { "q14", state14Transition},
                { "q15", state15Transition},
                { "q16", state16Transition},
                { "q17", state17Transition}

                 };
            currentstate = "q0";
            return Transition_Dictionary;
        }


    }
}


     
        public struct Transition
        {
            public char alhpabet { get; set; }
            public string state { get; set; }
            public char changeChar { get; set; }
            public Move move { get; set; }
        }
    
