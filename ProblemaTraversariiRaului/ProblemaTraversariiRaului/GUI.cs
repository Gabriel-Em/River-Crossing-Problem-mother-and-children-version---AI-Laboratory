using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProblemaTraversariiRaului
{
    public partial class GUI : Form
    {
        private Controller ctrl;
        private List<Stare> Vizitate;
        private int stareAnimata;
        private bool barcaMoving;
        private bool directie;

        public GUI()
        {
            InitializeComponent();

            ctrl = new Controller();
            Vizitate = new List<Stare>();
            stareAnimata = 0;
            barcaMoving = false;
            directie = false;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            Vizitate.Clear();
            Vizitate = ctrl.StartBFS();
            fillListBoxes();
        }

        private void btnGBFS_Click(object sender, EventArgs e)
        {
            Vizitate.Clear();
            Vizitate = ctrl.StartGBFS();
            fillListBoxes();
        }

        private void fillListBoxes()
        {
            listCopil2S.Items.Clear();
            listCopil1S.Items.Clear();
            listParinteS.Items.Clear();
            listBarca1.Items.Clear();
            listBarca2.Items.Clear();
            listDirectie.Items.Clear();
            listCopil2D.Items.Clear();
            listCopil1D.Items.Clear();
            listParinteD.Items.Clear();

            foreach (Stare stare in Vizitate)
            {
                listCopil2S.Items.Add(stare.malStang[0]);
                listCopil1S.Items.Add(stare.malStang[1]);
                listParinteS.Items.Add(stare.malStang[2]);

                listCopil2D.Items.Add(stare.malDrept[2]);
                listCopil1D.Items.Add(stare.malDrept[1]);
                listParinteD.Items.Add(stare.malDrept[0]);

                if (stare.nrStare == 1)
                {
                    listBarca1.Items.Add("-");
                    listBarca2.Items.Add("-");
                    listDirectie.Items.Add("-");
                }
                else
                {
                    List<string> Barca = getBarca(stare);
                    listBarca1.Items.Add(Barca[0]);
                    listBarca2.Items.Add(Barca[1]);

                    if (stare.malStang[3] != "-")
                        listDirectie.Items.Add("<<");
                    else
                        listDirectie.Items.Add(">>");
                }
            }
        }

        List<string> getBarca(Stare stare)
        {
            Stare parinte = null;
            List<string> Barca = new List<string>();

            foreach (Stare s in Vizitate)
                if (s.nrStare == stare.nrParinte)
                {
                    parinte = s;
                    break;
                }

            for (int i = 0; i < stare.malStang.Count - 1; i++)
                if (stare.malStang[i] != parinte.malStang[i])
                    if (stare.malStang[i] != "-")
                        Barca.Add(stare.malStang[i]);
                    else
                        Barca.Add(parinte.malStang[i]);

            if (Barca.Count == 1)
                Barca.Add("-");
            return Barca;
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            highLightListBox(lb.SelectedIndex);
            setPics(Vizitate[lb.SelectedIndex]);
            if (Vizitate[lb.SelectedIndex].malStang[3] == "-")
                picBarca.Location = new Point(585, 300);
            else
                picBarca.Location = new Point(185, 300);
        }

        private void highLightListBox(int index)
        {
            listCopil2S.SelectedIndex = index;
            listCopil1S.SelectedIndex = index;
            listParinteS.SelectedIndex = index;
            listCopil2D.SelectedIndex = index;
            listCopil1D.SelectedIndex = index;
            listParinteD.SelectedIndex = index;
            listBarca1.SelectedIndex = index;
            listBarca2.SelectedIndex = index;
            listDirectie.SelectedIndex = index;
        }

        private void timerAnimatie_Tick(object sender, EventArgs e)
        {
            if (!barcaMoving)
                if (stareAnimata != Vizitate.Count)
                {
                    Thread.Sleep(500);
                    if (Vizitate[stareAnimata].nrStare == 1)
                        stareAnimata++;
                    else
                    {
                        highLightListBox(stareAnimata);

                        setPics(getParinte(Vizitate[stareAnimata]));

                        List<string> Barca = getBarca(Vizitate[stareAnimata]);

                        string hide;
                        if (Barca[1] != "-")
                        {
                            picBarca.BackgroundImage = ProblemaTraversariiRaului.Properties.Resources.BacrcaCu2Copii;
                            hide = "2Copii";
                        }
                        else
                            if (Barca[0] == "Parinte")
                        {
                            picBarca.BackgroundImage = ProblemaTraversariiRaului.Properties.Resources.BarcaCuParinte;
                            hide = Barca[0];
                        }
                        else
                        {
                            picBarca.BackgroundImage = ProblemaTraversariiRaului.Properties.Resources.BarcaCu1Copil;
                            hide = Barca[0];
                        }

                        if (Vizitate[stareAnimata].malStang[3] != "-")
                        {
                            directie = true;
                            picBarca.Location = new Point(585, 300);

                            switch (hide)
                            {
                                case "Parinte": picParinteD.Visible = false; break;
                                case "Copil1": picCopil1D.Visible = false; break;
                                case "Copil2": picCopil2D.Visible = false; break;
                                case "2Copii": picCopil1D.Visible = false; picCopil2D.Visible = false; break;
                            }
                        }
                        else
                        {
                            directie = false;
                            picBarca.Location = new Point(185, 300);

                            switch (hide)
                            {
                                case "Parinte": picParinteS.Visible = false; break;
                                case "Copil1": picCopil1S.Visible = false; break;
                                case "Copil2": picCopil2S.Visible = false; break;
                                case "2Copii": picCopil1S.Visible = false; picCopil2D.Visible = false; break;
                            }
                        }
                        barcaMoving = true;
                        timerBarca.Enabled = true;
                    }
                }
                else
                {
                    btnStartAnimatie.Enabled = true;
                    btnBFS.Enabled = true;
                    btnGBFS.Enabled = true;
                    timerAnimatie.Enabled = false;
                }

        }

        private Stare getParinte(Stare stare)
        {
            foreach (Stare s in Vizitate)
                if (s.nrStare == stare.nrParinte)
                    return s;
            return null;
        }

        private void setPics(Stare stare)
        {
            if (stare.malStang[0] != "-")
                picCopil2S.Visible = true;
            else
                picCopil2S.Visible = false;

            if (stare.malStang[1] != "-")
                picCopil1S.Visible = true;
            else
                picCopil1S.Visible = false;

            if (stare.malStang[2] != "-")
                picParinteS.Visible = true;
            else
                picParinteS.Visible = false;

            if (stare.malDrept[0] != "-")
                picParinteD.Visible = true;
            else
                picParinteD.Visible = false;

            if (stare.malDrept[1] != "-")
                picCopil1D.Visible = true;
            else
                picCopil1D.Visible = false;

            if (stare.malDrept[2] != "-")
                picCopil2D.Visible = true;
            else
                picCopil2D.Visible = false;
        }

        private void timerBarca_Tick(object sender, EventArgs e)
        {
            if (barcaMoving)
                if (directie)    // daca barca se misca la stanga
                {
                    if (picBarca.Location.X != 185)
                        picBarca.Location = new Point(picBarca.Location.X - 10, picBarca.Location.Y);
                    else
                    {
                        setPics(Vizitate[stareAnimata]);
                        picBarca.BackgroundImage = ProblemaTraversariiRaului.Properties.Resources.Barca_goala;
                        stareAnimata++;
                        timerBarca.Enabled = false;
                        barcaMoving = false;
                    }
                }
                else
                {
                    if (picBarca.Location.X != 585)
                        picBarca.Location = new Point(picBarca.Location.X + 10, picBarca.Location.Y);
                    else
                    {
                        setPics(Vizitate[stareAnimata]);
                        picBarca.BackgroundImage = ProblemaTraversariiRaului.Properties.Resources.Barca_goala;
                        stareAnimata++;
                        timerBarca.Enabled = false;
                        barcaMoving = false;
                    }
                }
        }

        private void btnStartAnimatie_Click(object sender, EventArgs e)
        {
            setPics(Vizitate[0]);
            picBarca.Location = new Point(585, 300);
            stareAnimata = 0;
            btnStartAnimatie.Enabled = false;
            btnBFS.Enabled = false;
            btnGBFS.Enabled = false;
            timerAnimatie.Enabled = true;
        }
    }
}
