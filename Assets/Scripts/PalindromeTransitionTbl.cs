using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class PalindromeTransitionTbl
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
            return tmStates;
        }

        private List<Transition2> state0Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q1",  changeChar='Δ', move=Move.R},
                                                                               new Transition2() { alhpabet = 'b', state = "q4",  changeChar='Δ', move=Move.R},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q7",  changeChar='Δ', move=Move.H}};

        private List<Transition2> state1Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q1",  changeChar='a', move=Move.R},
                                                                               new Transition2() { alhpabet = 'b', state = "q1",  changeChar='b', move=Move.R},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q2",  changeChar='Δ', move=Move.L}};

        private List<Transition2> state2Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q3",  changeChar='Δ', move=Move.L},
                                                                               new Transition2() { alhpabet = 'b', state = "q2",  changeChar='b', move=Move.H},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q7",  changeChar='Δ', move=Move.H}};

        private List<Transition2> state3Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q3",  changeChar='a', move=Move.L},
                                                                               new Transition2() { alhpabet = 'b', state = "q3",  changeChar='b', move=Move.L},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q0",  changeChar='Δ', move=Move.R}};

        private List<Transition2> state4Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q4",  changeChar='a', move=Move.R},
                                                                               new Transition2() { alhpabet = 'b', state = "q4",  changeChar='b', move=Move.R},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q5",  changeChar='Δ', move=Move.L}};

        private List<Transition2> state5Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q5",  changeChar='a', move=Move.H},
                                                                               new Transition2() { alhpabet = 'b', state = "q6",  changeChar='Δ', move=Move.L},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q7",  changeChar='Δ', move=Move.H}};

        private List<Transition2> state6Transition = new List<Transition2>() {     new Transition2() { alhpabet = 'a', state = "q6",  changeChar='a', move=Move.L},
                                                                               new Transition2() { alhpabet = 'b', state = "q6",  changeChar='6', move=Move.L},
                                                                               new Transition2() { alhpabet = 'Δ', state = "q7",  changeChar='Δ', move=Move.H}};

        private List<Transition2> state7Transition = new List<Transition2>() { new Transition2() { alhpabet = 'Δ', state = "q7", changeChar = 'Δ', move = Move.H } };







        public Dictionary<string, List<Transition2>> Transition_Dictionary;

        public Dictionary<string, List<Transition2>> add()
        {
            Transition_Dictionary = new Dictionary<string, List<Transition2>>() {
                { "q0", state0Transition},
                { "q1", state1Transition},
                { "q2", state2Transition},
                { "q3", state3Transition},
                { "q4", state4Transition},
                { "q5", state5Transition},
                { "q6", state6Transition},
                { "q7", state7Transition}

             };
            currentstate = "q0";
            return Transition_Dictionary;
        }


    }
}
public struct Transition2
{
    public char alhpabet { get; set; }
    public string state { get; set; }
    public char changeChar { get; set; }
    public Move move { get; set; }
}
