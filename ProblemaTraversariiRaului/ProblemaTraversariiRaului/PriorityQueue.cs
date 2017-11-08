using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaTraversariiRaului
{
    class PriorityQueue
    {
        private List<Stare> coada;

        public int Count
        {
            get
            {
                return coada.Count();
            }
        }

        public List<Stare> toList()
        {
            return coada.ToList();
        }

        public PriorityQueue()
        {
            coada = new List<Stare>();
        }

        public void Enqueue(Stare stare)
        {
            bool adaugat = false;

            for (int i = 0; i < coada.Count(); i++)
                if (stare.getNrMalStang >= coada[i].getNrMalStang)
                {
                    coada.Insert(i, stare);

                    adaugat = true;
                    break;
                }

            if (!adaugat)
                coada.Add(stare);
        }

        public Stare Dequeue()
        {
            Stare stare = coada[0];
            coada.RemoveAt(0);

            return stare;
        }
    }
}