using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCrossingProblem
{
    class PriorityQueue
    {
        private List<State> queue;

        public int Count
        {
            get
            {
                return queue.Count();
            }
        }

        public List<State> toList()
        {
            return queue.ToList();
        }

        public PriorityQueue()
        {
            queue = new List<State>();
        }

        public void Enqueue(State stare)
        {
            bool adaugat = false;

            for (int i = 0; i < queue.Count(); i++)
                if (stare.getLeftSideNo >= queue[i].getLeftSideNo)
                {
                    queue.Insert(i, stare);

                    adaugat = true;
                    break;
                }

            if (!adaugat)
                queue.Add(stare);
        }

        public State Dequeue()
        {
            State stare = queue[0];
            queue.RemoveAt(0);

            return stare;
        }
    }
}