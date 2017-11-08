using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCrossingProblem
{
    class State
    {
        public int stateID { get; set; }
        public List<string> leftSide { get; set; }
        public List<string> rightSide { get; set; }
        public int parentID { get; set; }

        public State()
        {
            stateID = 1;
            leftSide = new List<string>() { "-", "-", "-", "-" };
            rightSide = new List<string>() { "Mom", "Child1", "Child2", "Boat" };
            parentID = 0;
        }

        public State(int stateID, List<string> leftSide, List<string> rightSide, int parentID)
        {
            this.stateID = stateID;
            this.leftSide = leftSide;
            this.rightSide = rightSide;
            this.parentID = parentID;
        }

        public int getRightSideNo
        {
            get
            {
                int nr = 0;

                for (int i = 0; i < rightSide.Count() - 1; i++)
                    if (rightSide[i] != "-")
                        nr++;

                return nr;
            }
        }

        public int getLeftSideNo
        {
            get
            {
                int nr = 0;

                for (int i = 0; i < leftSide.Count() - 1; i++)
                    if (leftSide[i] != "-")
                        nr++;

                return nr;
            }
        }
    
        public State Clone()
        {
            return new State(this.stateID, this.leftSide.ToList(), this.rightSide.ToList(), this.parentID);
        }

        public bool isDuplicate(State stare)
        {
            int cso, pso, css, pss,bo,bs;
            cso = 0;
            pso = 0;
            css = 0;
            pss = 0;
            bo = 0;
            bs = 0;

            for (int i = 0; i < leftSide.Count; i++)
            {
                if (leftSide[i].Contains("Mom"))
                    pso++;
                if (stare.leftSide[i].Contains("Mom"))
                    pss++;
                if (leftSide[i].Contains("Child"))
                    cso++;
                if (stare.leftSide[i].Contains("Child"))
                    css++;
                if (leftSide[i].Contains("Boat"))
                    bo++;
                if (stare.leftSide[i].Contains("Boat"))
                    bs++;
            }

            if (pso != pss || cso != css || bo!=bs)
                return false;

            return true;
        }
    }
}
