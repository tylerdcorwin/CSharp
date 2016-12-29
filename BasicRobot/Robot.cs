using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Robot : Form
    {
        //load Movements class
        private Movements Cyborg = new Movements();

        public Robot()
        {
            InitializeComponent();
        }
        //declare global variables for direction
        string ArrowPointing = "";
        Point increment;
        char dir;

        //Ignore this
        private void lblArrow_Click(object sender, EventArgs e)
        {
            
        }
        //On Load
        private void Robot_Load(object sender, EventArgs e)
        {
            //Arrow directionals
            //Arrow South = 234
            //Arrow North = 233
            //Arrow West = 231
            //Arrow East = 232
            Cyborg.Crash += new Movements.Collision(Crashed);
            //use Movements Class to populate the pnlNav with arrow in middle facing North
            ArrowPointing = "North";
            dir = 'N';
            lblArrow.Location = new Point (100, 100);
            lblLocation.Text = new Point().ToString();
            Movements start = new Movements(ArrowPointing);
            lblArrow.Text = start.Face();
        }
        //North
        private void btnNorth_Click(object sender, EventArgs e)
        {
            ArrowPointing = "North";
            dir = 'N';
            Movements north = new Movements(ArrowPointing);
            lblArrow.Text = north.Face();
        }
        //West
        private void btnWest_Click(object sender, EventArgs e)
        {
            ArrowPointing = "West";
            dir = 'W';
            Movements west = new Movements(ArrowPointing);
            lblArrow.Text = west.Face();
        }
        //East
        private void btnEast_Click(object sender, EventArgs e)
        {
            ArrowPointing = "East";
            dir = 'E';
            Movements east = new Movements(ArrowPointing);
            lblArrow.Text = east.Face();
        }
        //South
        private void btnSouth_Click(object sender, EventArgs e)
        {
            ArrowPointing = "South";
            dir = 'S';
            Movements south = new Movements(ArrowPointing);
            lblArrow.Text = south.Face();
        }
        //Move one pixel in direction
        private void btnGoOne_Click(object sender, EventArgs e)
        {
            increment = lblArrow.Location;
            Movements goOne = new Movements(dir, increment);
            Cyborg.txtlocation(1, dir);
            lblArrow.Location = goOne.Moving(1);//increment by 1
            lblLocation.Text = Cyborg.location.ToString();
        }
        //Move ten pixels in direction
        private void btnGoTen_Click(object sender, EventArgs e)
        {
            increment = lblArrow.Location;
            Movements goTen = new Movements(dir, increment);
            Cyborg.txtlocation(10, dir);
            lblArrow.Location = goTen.Moving(10);//increment by 10
            lblLocation.Text = Cyborg.location.ToString();
        }
        //Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Event Crashed
        public void Crashed()
        {
            lblLocation.Text = Cyborg.location.ToString();
            MessageBox.Show("CRASH", "CRASH");
        }
    }
}
