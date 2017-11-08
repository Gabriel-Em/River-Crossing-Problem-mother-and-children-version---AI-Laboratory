using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaTraversariiRaului
{
    class Controller
    {
        Cautare cautare;

        public Controller()
        {
            cautare = new Cautare();
        }

        public List<Stare> StartBFS()
        {
            return cautare.BFS(new Stare()).Item2;
        }

        public List<Stare> StartGBFS()
        {
            return cautare.GBFS(new Stare()).Item2;
        }
    }
}
