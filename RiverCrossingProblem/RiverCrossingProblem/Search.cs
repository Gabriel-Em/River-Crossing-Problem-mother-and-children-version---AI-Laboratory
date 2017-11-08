using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCrossingProblem
{
    class Search
    {
        public Tuple<State,List<State>> BFS(State initialState)
        {
            State stare = new State();
            List<State> Visited = new List<State>();
            Queue<State> ToVisit = new Queue<State>();
            int stateID = 1;

            ToVisit.Enqueue(initialState);

            while (ToVisit.Count > 0)
            {
                stare = ToVisit.Dequeue();
                Visited.Add(stare);

                if (finalState(stare))
                    return new Tuple<State, List<State>>(stare, Visited);
                else
                {
                    List<State> successors = getSuccessors(stare);

                    for (int i = 0; i < successors.Count; i++)
                        if (!AlreadyExists(Visited, ToVisit.ToList<State>(), successors[i]))
                        {
                            successors[i].stateID = ++stateID;
                            ToVisit.Enqueue(successors[i]);
                        }
                }
            }

            return null;
        }

        public Tuple<State, List<State>> GBFS(State initialState)
        {
            State state = new State();
            List<State> Visited = new List<State>();
            PriorityQueue ToVisit = new PriorityQueue();
            int stateID = 1;

            ToVisit.Enqueue(initialState);

            while (ToVisit.Count > 0)
            {
                state = ToVisit.Dequeue();
                Visited.Add(state);

                if (finalState(state))
                    return new Tuple<State, List<State>>(state, Visited);
                else
                {
                    List<State> successors = getSuccessors(state);

                    for (int i = 0; i < successors.Count; i++)
                        if (!AlreadyExists(Visited, ToVisit.toList(), successors[i]))
                        {
                            successors[i].stateID = ++stateID;
                            ToVisit.Enqueue(successors[i]);
                        }
                }
            }

            return null;
        }

        private bool finalState(State stare)
        {
            for (int i = 0; i <= 3; i++)
                if (stare.leftSide[i] == "-")
                    return false;

            return true;
        }

        private bool AlreadyExists(List<State> Vizitate, List<State> DeVizitat, State stare)
        {
            for (int i = 0; i < Vizitate.Count; i++)
                if (stare.isDuplicate(Vizitate[i]))
                    return true;

            for (int i = 0; i < DeVizitat.Count; i++)
            {
                if (stare.isDuplicate(DeVizitat[i]))
                    return true;
            }

            return false;
        }

        private List<State> getSuccessors(State stare)
        {
            List<State> successors = new List<State>();
            List<string> boat = new List<string>() { "-", "-" };

            if (stare.leftSide[3] != "-")        // boat is on left side
            {
                if (stare.leftSide[2] != "-")    // mom is on left side
                    successors.Add(generateSuccessor(stare, 1, new List<string>() { "Mom", "-" }));

                if(stare.leftSide[1] != "-")    // if child1 is on left side
                {
                    successors.Add(generateSuccessor(stare,  1, new List<string>() { "Child1", "-" }));

                    if (stare.leftSide[0] != "-")    // if child2 is on left side
                        successors.Add(generateSuccessor(stare, 1, new List<string>() { "Child1", "Child2" }));
                }
                else
                    if(stare.leftSide[0] != "-")    // daca child2 is on left side
                    successors.Add(generateSuccessor(stare, 1, new List<string>() { "Child2", "-" }));
            }
            else                    // boat is on right side
            {
                if (stare.rightSide[0] != "-")    // mom is on right side
                    successors.Add(generateSuccessor(stare, 0, new List<string>() { "Mom", "-" }));

                if (stare.rightSide[1] != "-")    // child1 is on right side
                {
                    successors.Add(generateSuccessor(stare, 0, new List<string>() { "Child1", "-" }));

                    if (stare.rightSide[2] != "-")    // child2 is on right side
                        successors.Add(generateSuccessor(stare, 0, new List<string>() { "Child1", "Child2" }));
                }
                else
                    if (stare.rightSide[2] != "-")    // child2 is on right side
                    successors.Add(generateSuccessor(stare, 0, new List<string>() { "Child2", "-" }));
            }

            return successors;
        }

        public State generateSuccessor(State state, int direction, List<string> boat)         // directie = 1 - se trece de pe malul stang pe drept / directie = 0 - invers
        {
            State st = state.Clone();

            st.parentID = state.stateID;

            switch (direction)
            {
                case 1:
                    switch (boat[0])
                    {
                        case "Mom": st.leftSide[2] = "-"; st.rightSide[0] = "Mom"; break;
                        case "Child1": st.leftSide[1] = "-"; st.rightSide[1] = "Child1"; break;
                        case "Child2": st.leftSide[0] = "-"; st.rightSide[2] = "Child2"; break;
                    }

                    switch (boat[1])
                    {
                        case "Mom": st.leftSide[2] = "-"; st.rightSide[0] = "Mom"; break;
                        case "Child1": st.leftSide[1] = "-"; st.rightSide[1] = "Child1"; break;
                        case "Child2": st.leftSide[0] = "-"; st.rightSide[2] = "Child2"; break;
                    }

                    st.leftSide[3] = "-";
                    st.rightSide[3] = "Boat";

                    break;

                case 0:
                    switch (boat[0])
                    {
                        case "Mom": st.leftSide[2] = "Mom"; st.rightSide[0] = "-"; break;
                        case "Child1": st.leftSide[1] = "Child1"; st.rightSide[1] = "-"; break;
                        case "Child2": st.leftSide[0] = "Child2"; st.rightSide[2] = "-"; break;
                    }

                    switch (boat[1])
                    {
                        case "Mom": st.leftSide[2] = "Mom"; st.rightSide[0] = "-"; break;
                        case "Child1": st.leftSide[1] = "Child1"; st.rightSide[1] = "-"; break;
                        case "Child2": st.leftSide[0] = "Child2"; st.rightSide[2] = "-"; break;
                    }

                    st.leftSide[3] = "Boat";
                    st.rightSide[3] = "-";

                    break;
            }
            return st;
        }
    }
}
