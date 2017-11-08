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

namespace RiverCrossingProblem
{
    public partial class GUI : Form
    {
        private Controller ctrl;
        private List<State> Visited;
        private int animatedState;
        private bool boatIsMoving;
        private bool direction;

        public GUI()
        {
            InitializeComponent();

            ctrl = new Controller();
            Visited = new List<State>();
            animatedState = 0;
            boatIsMoving = false;
            direction = false;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            Visited.Clear();
            Visited = ctrl.StartBFS();
            fillListBoxes();
        }

        private void btnGBFS_Click(object sender, EventArgs e)
        {
            Visited.Clear();
            Visited = ctrl.StartGBFS();
            fillListBoxes();
        }

        private void fillListBoxes()
        {
            listChild2L.Items.Clear();
            listChild1L.Items.Clear();
            listMomL.Items.Clear();
            listBoat1.Items.Clear();
            listBoat2.Items.Clear();
            listDirection.Items.Clear();
            listChild2R.Items.Clear();
            listChild1R.Items.Clear();
            listMomR.Items.Clear();

            foreach (State stare in Visited)
            {
                listChild2L.Items.Add(stare.leftSide[0]);
                listChild1L.Items.Add(stare.leftSide[1]);
                listMomL.Items.Add(stare.leftSide[2]);

                listChild2R.Items.Add(stare.rightSide[2]);
                listChild1R.Items.Add(stare.rightSide[1]);
                listMomR.Items.Add(stare.rightSide[0]);

                if (stare.stateID == 1)
                {
                    listBoat1.Items.Add("-");
                    listBoat2.Items.Add("-");
                    listDirection.Items.Add("-");
                }
                else
                {
                    List<string> Boat = getBoat(stare);
                    listBoat1.Items.Add(Boat[0]);
                    listBoat2.Items.Add(Boat[1]);

                    if (stare.leftSide[3] != "-")
                        listDirection.Items.Add("<<");
                    else
                        listDirection.Items.Add(">>");
                }
            }
        }

        List<string> getBoat(State state)
        {
            State mom = null;
            List<string> Boat = new List<string>();

            foreach (State s in Visited)
                if (s.stateID == state.parentID)
                {
                    mom = s;
                    break;
                }

            for (int i = 0; i < state.leftSide.Count - 1; i++)
                if (state.leftSide[i] != mom.leftSide[i])
                    if (state.leftSide[i] != "-")
                        Boat.Add(state.leftSide[i]);
                    else
                        Boat.Add(mom.leftSide[i]);

            if (Boat.Count == 1)
                Boat.Add("-");
            return Boat;
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            highLightListBox(lb.SelectedIndex);
            setPics(Visited[lb.SelectedIndex]);
            if (Visited[lb.SelectedIndex].leftSide[3] == "-")
                picBoat.Location = new Point(585, 300);
            else
                picBoat.Location = new Point(185, 300);
        }

        private void highLightListBox(int index)
        {
            listChild2L.SelectedIndex = index;
            listChild1L.SelectedIndex = index;
            listMomL.SelectedIndex = index;
            listChild2R.SelectedIndex = index;
            listChild1R.SelectedIndex = index;
            listMomR.SelectedIndex = index;
            listBoat1.SelectedIndex = index;
            listBoat2.SelectedIndex = index;
            listDirection.SelectedIndex = index;
        }

        private void timerAnimatie_Tick(object sender, EventArgs e)
        {
            if (!boatIsMoving)
                if (animatedState != Visited.Count)
                {
                    Thread.Sleep(500);
                    if (Visited[animatedState].stateID == 1)
                        animatedState++;
                    else
                    {
                        highLightListBox(animatedState);

                        setPics(getMom(Visited[animatedState]));

                        List<string> Boat = getBoat(Visited[animatedState]);

                        string hide;
                        if (Boat[1] != "-")
                        {
                            picBoat.BackgroundImage = RiverCrossingProblem.Properties.Resources.BoatWith2Children;
                            hide = "2Children";
                        }
                        else
                            if (Boat[0] == "Mom")
                        {
                            picBoat.BackgroundImage = RiverCrossingProblem.Properties.Resources.BoatWithMom;
                            hide = Boat[0];
                        }
                        else
                        {
                            picBoat.BackgroundImage = RiverCrossingProblem.Properties.Resources.BoatWith1Children;
                            hide = Boat[0];
                        }

                        if (Visited[animatedState].leftSide[3] != "-")
                        {
                            direction = true;
                            picBoat.Location = new Point(585, 300);

                            switch (hide)
                            {
                                case "Mom": picMomR.Visible = false; break;
                                case "Child1": picChild1R.Visible = false; break;
                                case "Child2": picChild2R.Visible = false; break;
                                case "2Children": picChild1R.Visible = false; picChild2R.Visible = false; break;
                            }
                        }
                        else
                        {
                            direction = false;
                            picBoat.Location = new Point(185, 300);

                            switch (hide)
                            {
                                case "Mom": picMomL.Visible = false; break;
                                case "Child1": picChild1L.Visible = false; break;
                                case "Child2": picChild2L.Visible = false; break;
                                case "2Children": picChild1L.Visible = false; picChild2R.Visible = false; break;
                            }
                        }
                        boatIsMoving = true;
                        boatTimer.Enabled = true;
                    }
                }
                else
                {
                    btnStartAnimation.Enabled = true;
                    btnBFS.Enabled = true;
                    btnGBFS.Enabled = true;
                    animationTimer.Enabled = false;
                }

        }

        private State getMom(State state)
        {
            foreach (State s in Visited)
                if (s.stateID == state.parentID)
                    return s;
            return null;
        }

        private void setPics(State stare)
        {
            if (stare.leftSide[0] != "-")
                picChild2L.Visible = true;
            else
                picChild2L.Visible = false;

            if (stare.leftSide[1] != "-")
                picChild1L.Visible = true;
            else
                picChild1L.Visible = false;

            if (stare.leftSide[2] != "-")
                picMomL.Visible = true;
            else
                picMomL.Visible = false;

            if (stare.rightSide[0] != "-")
                picMomR.Visible = true;
            else
                picMomR.Visible = false;

            if (stare.rightSide[1] != "-")
                picChild1R.Visible = true;
            else
                picChild1R.Visible = false;

            if (stare.rightSide[2] != "-")
                picChild2R.Visible = true;
            else
                picChild2R.Visible = false;
        }

        private void timerBoat_Tick(object sender, EventArgs e)
        {
            if (boatIsMoving)
                if (direction)    // if boat moves left
                {
                    if (picBoat.Location.X != 185)
                        picBoat.Location = new Point(picBoat.Location.X - 10, picBoat.Location.Y);
                    else
                    {
                        setPics(Visited[animatedState]);
                        picBoat.BackgroundImage = RiverCrossingProblem.Properties.Resources.Empty_Boat;
                        animatedState++;
                        boatTimer.Enabled = false;
                        boatIsMoving = false;
                    }
                }
                else
                {
                    if (picBoat.Location.X != 585)
                        picBoat.Location = new Point(picBoat.Location.X + 10, picBoat.Location.Y);
                    else
                    {
                        setPics(Visited[animatedState]);
                        picBoat.BackgroundImage = RiverCrossingProblem.Properties.Resources.Empty_Boat;
                        animatedState++;
                        boatTimer.Enabled = false;
                        boatIsMoving = false;
                    }
                }
        }

        private void btnStartAnimation_Click(object sender, EventArgs e)
        {
            setPics(Visited[0]);
            picBoat.Location = new Point(585, 300);
            animatedState = 0;
            btnStartAnimation.Enabled = false;
            btnBFS.Enabled = false;
            btnGBFS.Enabled = false;
            animationTimer.Enabled = true;
        }
    }
}