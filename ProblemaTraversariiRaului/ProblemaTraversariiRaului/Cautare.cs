using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaTraversariiRaului
{
    class Cautare
    {
        public Cautare()
        {

        }

        public Tuple<Stare,List<Stare>> BFS(Stare stareInitiala)
        {
            Stare stare = new Stare();
            List<Stare> Vizitate = new List<Stare>();
            Queue<Stare> DeVizitat = new Queue<Stare>();
            int nrStare = 1;

            DeVizitat.Enqueue(stareInitiala);

            while (DeVizitat.Count > 0)
            {
                stare = DeVizitat.Dequeue();
                Vizitate.Add(stare);

                if (stareFinala(stare))
                    return new Tuple<Stare, List<Stare>>(stare, Vizitate);
                else
                {
                    List<Stare> succesori = getSuccesori(stare);

                    for (int i = 0; i < succesori.Count; i++)
                        if (!Exista(Vizitate, DeVizitat.ToList<Stare>(), succesori[i]))
                        {
                            succesori[i].nrStare = ++nrStare;
                            DeVizitat.Enqueue(succesori[i]);
                        }
                }
            }

            return null;
        }

        public Tuple<Stare, List<Stare>> GBFS(Stare stareInitiala)
        {
            Stare stare = new Stare();
            List<Stare> Vizitate = new List<Stare>();
            PriorityQueue DeVizitat = new PriorityQueue();
            int nrStare = 1;

            DeVizitat.Enqueue(stareInitiala);

            while (DeVizitat.Count > 0)
            {
                stare = DeVizitat.Dequeue();
                Vizitate.Add(stare);

                if (stareFinala(stare))
                    return new Tuple<Stare, List<Stare>>(stare, Vizitate);
                else
                {
                    List<Stare> succesori = getSuccesori(stare);

                    for (int i = 0; i < succesori.Count; i++)
                        if (!Exista(Vizitate, DeVizitat.toList(), succesori[i]))
                        {
                            succesori[i].nrStare = ++nrStare;
                            DeVizitat.Enqueue(succesori[i]);
                        }
                }
            }

            return null;
        }

        private bool stareFinala(Stare stare)
        {
            for (int i = 0; i <= 3; i++)
                if (stare.malStang[i] == "-")
                    return false;

            return true;
        }

        private bool Exista(List<Stare> Vizitate, List<Stare> DeVizitat, Stare stare)
        {
            bool gasit;

            for (int i = 0; i < Vizitate.Count; i++)
            {
                gasit = true;

                if (!stare.isDuplicate(Vizitate[i]))
                    gasit = false;
                
                if (gasit)
                    return true;
            }

            for (int i = 0; i < DeVizitat.Count; i++)
            {
                gasit = true;

                if (!stare.isDuplicate(DeVizitat[i]))
                    gasit = false;

                if (gasit)
                    return true;
            }

            return false;
        }

        private List<Stare> getSuccesori(Stare stare)
        {
            List<Stare> succesori = new List<Stare>();
            List<string> barca = new List<string>() { "-", "-" };

            if (stare.malStang[3] != "-")        // barca e pe malul stang
            {
                if (stare.malStang[2] != "-")    // daca Parinte e pe malul stang
                    succesori.Add(genereazaSuccesor(stare, 1, new List<string>() { "Parinte", "-" }));

                if(stare.malStang[1] != "-")    // daca Copil1 e pe malul stang
                {
                    succesori.Add(genereazaSuccesor(stare,  1, new List<string>() { "Copil1", "-" }));

                    if (stare.malStang[0] != "-")    // daca Copil2 e pe malul stang
                        succesori.Add(genereazaSuccesor(stare, 1, new List<string>() { "Copil1", "Copil2" }));
                }
                else
                    if(stare.malStang[0] != "-")    // daca Copil2 e pe malul stang
                    succesori.Add(genereazaSuccesor(stare, 1, new List<string>() { "Copil2", "-" }));
            }
            else                    // daca barca e pe malul drept
            {
                if (stare.malDrept[0] != "-")    // daca Parinte e pe malul drept
                    succesori.Add(genereazaSuccesor(stare, 0, new List<string>() { "Parinte", "-" }));

                if (stare.malDrept[1] != "-")    // daca Copil1 e pe malul stang
                {
                    succesori.Add(genereazaSuccesor(stare, 0, new List<string>() { "Copil1", "-" }));

                    if (stare.malDrept[2] != "-")    // daca Copil2 e pe malul stang
                        succesori.Add(genereazaSuccesor(stare, 0, new List<string>() { "Copil1", "Copil2" }));
                }
                else
                    if (stare.malDrept[2] != "-")    // daca Copil2 e pe malul stang
                    succesori.Add(genereazaSuccesor(stare, 0, new List<string>() { "Copil2", "-" }));
            }

            return succesori;
        }

        public Stare genereazaSuccesor(Stare stare, int directie, List<string> barca)         // directie = 1 - se trece de pe malul stang pe drept / directie = 0 - invers
        {
            Stare st = stare.Clone();

            st.nrParinte = stare.nrStare;

            switch (directie)
            {
                case 1:
                    switch (barca[0])
                    {
                        case "Parinte": st.malStang[2] = "-"; st.malDrept[0] = "Parinte"; break;
                        case "Copil1": st.malStang[1] = "-"; st.malDrept[1] = "Copil1"; break;
                        case "Copil2": st.malStang[0] = "-"; st.malDrept[2] = "Copil2"; break;
                    }

                    switch (barca[1])
                    {
                        case "Parinte": st.malStang[2] = "-"; st.malDrept[0] = "Parinte"; break;
                        case "Copil1": st.malStang[1] = "-"; st.malDrept[1] = "Copil1"; break;
                        case "Copil2": st.malStang[0] = "-"; st.malDrept[2] = "Copil2"; break;
                    }

                    st.malStang[3] = "-";
                    st.malDrept[3] = "Barca";

                    break;

                case 0:
                    switch (barca[0])
                    {
                        case "Parinte": st.malStang[2] = "Parinte"; st.malDrept[0] = "-"; break;
                        case "Copil1": st.malStang[1] = "Copil1"; st.malDrept[1] = "-"; break;
                        case "Copil2": st.malStang[0] = "Copil2"; st.malDrept[2] = "-"; break;
                    }

                    switch (barca[1])
                    {
                        case "Parinte": st.malStang[2] = "Parinte"; st.malDrept[0] = "-"; break;
                        case "Copil1": st.malStang[1] = "Copil1"; st.malDrept[1] = "-"; break;
                        case "Copil2": st.malStang[0] = "Copil2"; st.malDrept[2] = "-"; break;
                    }

                    st.malStang[3] = "Barca";
                    st.malDrept[3] = "-";

                    break;
            }
            return st;
        }
    }
}
