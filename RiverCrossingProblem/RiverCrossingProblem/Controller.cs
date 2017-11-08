using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCrossingProblem
{
    class Controller
    {
        Search cautare;

        public Controller()
        {
            cautare = new Search();
        }

        public List<State> StartBFS()
        {
            return cautare.BFS(new State()).Item2;
        }

        public List<State> StartGBFS()
        {
            return cautare.GBFS(new State()).Item2;
        }
    }
}
