using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaTraversariiRaului
{
    class Stare
    {
        public int nrStare { get; set; }
        public List<string> malStang { get; set; }
        public List<string> malDrept { get; set; }
        public int nrParinte { get; set; }

        public Stare()
        {
            nrStare = 1;
            malStang = new List<string>() { "-", "-", "-", "-" };
            malDrept = new List<string>() { "Parinte", "Copil1", "Copil2", "Barca" };
            nrParinte = 0;
        }

        public Stare(int nrStare, List<string> malStang, List<string> malDrept, int nrParinte)
        {
            this.nrStare = nrStare;
            this.malStang = malStang;
            this.malDrept = malDrept;
            this.nrParinte = nrParinte;
        }

        public int getNrMalDrept
        {
            get
            {
                int nr = 0;

                for (int i = 0; i < malDrept.Count() - 1; i++)
                    if (malDrept[i] != "-")
                        nr++;

                return nr;
            }
        }

        public int getNrMalStang
        {
            get
            {
                int nr = 0;

                for (int i = 0; i < malStang.Count() - 1; i++)
                    if (malStang[i] != "-")
                        nr++;

                return nr;
            }
        }
    
        public Stare Clone()
        {
            return new Stare(this.nrStare, this.malStang.ToList(), this.malDrept.ToList(), this.nrParinte);
        }

        public bool isDuplicate(Stare stare)
        {
            int cso, pso, css, pss,bo,bs;
            cso = 0;
            pso = 0;
            css = 0;
            pss = 0;
            bo = 0;
            bs = 0;

            for (int i = 0; i < malStang.Count; i++)
            {
                if (malStang[i].Contains("Parinte"))
                    pso++;
                if (stare.malStang[i].Contains("Parinte"))
                    pss++;
                if (malStang[i].Contains("Copil"))
                    cso++;
                if (stare.malStang[i].Contains("Copil"))
                    css++;
                if (malStang[i].Contains("Barca"))
                    bo++;
                if (stare.malStang[i].Contains("Barca"))
                    bs++;
            }

            if (pso != pss || cso != css || bo!=bs)
                return false;

            return true;
        }
    }
}
