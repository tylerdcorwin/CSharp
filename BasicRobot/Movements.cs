using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab3
{
    class Movements
    {
        //delegate and event
        public delegate void Collision();
        public event Collision Crash;
        
        //global variables
        public char dir;
        private string direction;
        private Point current;
        
        //default constructor
        public Movements() { location = new Point(); }  //starts location at (0,0)
        
        //location constructor
        public Point location { get; set; }

        //direction constructor
        public Movements (string direction)
        {
            this.Facing = direction;
        }
        
        public string Facing
        {
            get { return direction; }
            set { direction = value; }
        }

        //increment constructor

        public Movements(char dir, Point current)
        {
            this.CurrentPoint = current;
            this.Pointing = dir;
        }

        public char Pointing
        {
            get { return dir; }
            set { dir = value; }
        }

        public Point CurrentPoint
        {
            get { return current; }
            set { current = value; }
        }

        //Direction Arrow is Facing based off input
        public string Face()
        {
            string result;
            switch (direction)
            { 
                case "North":
                    string North;
                    North = Convert.ToChar(233).ToString();
                    result = North;
                    return result;

                case "South":
                    string South;
                    South = Convert.ToChar(234).ToString();
                    result = South;
                    return result;

                case "West":
                    string West;
                    West = Convert.ToChar(231).ToString();
                    result = West;
                    return result;

                case "East":
                    string East;
                    East = Convert.ToChar(232).ToString();
                    result = East;
                    return result;

                default:
                    return null;
            }
        }
        //Arrow Navigation
        public void txtlocation(int moved, char dir)
        {
            //create new location at (0,0)
            Point P = new Point();
            //get direction from main and distance
            switch (dir)
            {
                case 'N':
                    if (moved == 1 || moved == 10)
                    {
//----------------------------if needed this is where you change the txt properties for results------------------------------------//
                        P.X = location.X;
                        P.Y = location.Y - moved;
                        //set boundries
                        if (P.Y > -101)
                        {
                            location = P;
                        }
                        //crash event prevents further movement or increment
                        else
                        {
                            Crash();
                        }
                    }
                    break;

                case 'S':

                    if (moved == 1 || moved == 10)
                    {
                        P.X = location.X;
                        P.Y = location.Y + moved;
                        if (P.Y < 101)
                        {
                            location = P;
                        }
                        else
                        {
                            Crash();
                        }
                    }
                    break;

                case 'W':
                    if (moved == 1 || moved == 10)
                    {
                        P.X = location.X - moved;
                        P.Y = location.Y;
                        if (P.X > -101)
                        {
                            location = P;
                        }
                        else
                        {
                            Crash();
                        }
                    }
                    break;

                case 'E':
                    if (moved == 1 || moved == 10)
                    {
                        P.X = location.X + moved;
                        P.Y = location.Y;
                        if (P.X < 101)
                        {
                            location = P;
                        }
                        else
                        {
                            Crash();
                        }
                    }
                    break;

                default:
                    break;
            }
        }

       public Point Moving(int moved)
       {
           //Takes in location and moves arrow
           switch (dir)
           {
               case 'N':
                   Point northPoint = CurrentPoint;
                   northPoint.Y = northPoint.Y - moved;
                   //set boundry limit North
                    if (northPoint.Y < 0)
                       {
                          //return current point 
                           northPoint = CurrentPoint;
                       }
                       return northPoint;

               case 'S':
                   Point southPoint = CurrentPoint;
                   southPoint.Y = southPoint.Y + moved;
                   if (southPoint.Y > 200)
                       {
                           southPoint = CurrentPoint;
                       }
                       return southPoint;

               case 'W':
                   Point westPoint = CurrentPoint;
                   westPoint.X = westPoint.X - moved;
                   if (westPoint.X < 0)
                       {
                           westPoint = CurrentPoint;
                       }
                       return westPoint;

               case 'E':
                   Point eastPoint = CurrentPoint;
                   eastPoint.X = eastPoint.X + moved;
                   if (eastPoint.X > 200)
                       {
                           eastPoint = CurrentPoint;
                       }
                       return eastPoint;
               default:
                   return CurrentPoint;
           }
       }
       
    }
}
