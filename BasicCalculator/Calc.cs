using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCorwin_Lab1
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        //displayValue = displays what numbers have been clicked in txtResult.Text
        //Var1 = current value of txtResult.Text when an operand has been clicked
        //Var2 = current value of txtResult.Text when the equal has been clicked
        //crtVal = current value of txtResult.Text when the equal has been clicked more than once
        //Operand = char value of operand click
        //click = counter for number of equal clicks
        string displayValue = "";
        decimal Var1, Var2, crtVal;
        char Operand;
        int click = 0;
        int dotClick = 0;
        //function to display the clicked numbers in the txtResult.Text
        private void NumDisplay(object sender, EventArgs e)
        {
            //prevents adding multiple 0's
            if (displayValue.StartsWith("0."))
            {
                displayValue = ((Button)sender).Text;
                txtResult.Text = displayValue;
            }

            
            else if (displayValue.StartsWith("0"))
            {
                displayValue += ((Button)sender).Text;
                txtResult.Text = displayValue;
            }
            else
            {
                displayValue += ((Button)sender).Text;
                txtResult.Text = displayValue;
            }
        }
        //Add
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operand = '+';
            currentValue();
        }
        //Equal
        private void btnEqual_Click(object sender, EventArgs e)
        {
            //Repeat action if Equal is clicked more than once
            click++;
            try
            {
                //if equal has been clicked more than once run this
                if (click > 1)
                {
                    if (Var2 == 0 && Operand == '/')
                    {
                        MessageBox.Show("Cannot Divide by Zero", "Error");
                        Var1 = 0;
                        Var2 = 0;
                        displayValue = "";
                    }
                    //create new variable crtVal to multi click equal btn with arithmatic
                    else
                    {
                        crtVal = Convert.ToDecimal(txtResult.Text);
                        Calculator endValue = new Calculator(crtVal, Operand, Var2);
                        txtResult.Text = endValue.Result();
                        displayValue = "";
                    }
                }
                //if first click of equal btn
                else
                {
                    //check for divide by zero
                    Var2 = Convert.ToDecimal(txtResult.Text);
                    if (Var2 == 0 && Operand == '/')
                    {
                        MessageBox.Show("Cannot divide by Zero", "Error");
                        Var2 = 0;
                        displayValue = "";
                        click = 0;
                    }
                    //set Var2 and do arithmatic
                    else
                    {
                        Var2 = Convert.ToDecimal(txtResult.Text);
                        Calculator endValue = new Calculator(Var1, Operand, Var2);
                        txtResult.Text = endValue.Result();
                        displayValue = "";
                    }
                }
            }
            //catches if an operand is clicked then equals is clicked
            catch (FormatException)
            {
                MessageBox.Show("Please Enter A Value", "Format Error");
                click = 0;
            }
        }
        //Minus
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operand = '-';
            currentValue();
        }
        //fucntion to get currentValue for Var1
        private void currentValue()
        {
            Var1 = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
            displayValue = "";
            dotClick = 0;
            click = 0;
        }
        //sets click counter to 0 on program load (probably redundant)
        private void Calc_Load(object sender, EventArgs e)
        {
            //dotClick = 0;
            click = 0;
            txtResult.Text = "0";
        }
        //Multiply
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operand = '*';
            currentValue();
        }
        //Divide
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operand = '/';
            currentValue();
        }
        //Plus/Minus
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            //takes current value in txtResult.Text and multiplys by -1 to get correct format
            decimal timesNegOne, txt;
            txt = Convert.ToDecimal(txtResult.Text);
            timesNegOne = txt * (-1);
            txtResult.Text = timesNegOne.ToString();
        }
        //Sqrt
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtResult.Text != "0" || txtResult.Text != "")
                {
                    Operand = 's';
                    currentValue();
                    //negative number check
                    if (Var1 > 0)
                    {
                        Calculator sqrt = new Calculator(Var1, Operand);
                        txtResult.Text = sqrt.Result();
                    }
                    else
                    {
                        MessageBox.Show("Cannot get the square of a negative number", "Error");
                    }
                }
            }
            //check that sqrt wasn't clicked after an operand was clicked
            catch (FormatException)
            {
                MessageBox.Show("Cannot square a number after operand has been pressed, Please enter a new value", "Square root error");
            }
           
        }
        //1/X
        private void btnOneOverX_Click(object sender, EventArgs e)
        {
            Operand = 'x';
            currentValue();
            Calculator oneX = new Calculator(Var1, Operand);
            txtResult.Text = oneX.Result();
        }
        //decimal point
        private void btnDot_Click(object sender, EventArgs e)
        {
            dotClick++;
            if (dotClick > 1)
            {
                MessageBox.Show("You Can Not Have More Than One Decimal Point", "Decimal Point Error" );
                
            }
            else
            {
                string yes = txtResult.Text = txtResult.Text + ".";
                displayValue = yes;
            }
        }
        //clear out data stored in variables and txtResult.Text
        private void btnClear_Click(object sender, EventArgs e)
        {
            //txtResult.Text set to 0 so that it will not break if equal is clicked directly after clear.
            txtResult.Text = "0";
            Var1 = 0;
            Var2 = 0;
            click = 0;
            dotClick = 0;
            displayValue = "";
        }
        //back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            dotClick = 0;
            click = 0;
            string str;
            int loc;
            if (txtResult.Text.Length > 0)
            {
                str = txtResult.Text.Substring(txtResult.Text.Length - 1);
                loc = txtResult.Text.Length;
                txtResult.Text = txtResult.Text.Remove(loc - 1, 1);
                displayValue = txtResult.Text;
            }
            else
            {
                txtResult.Text = "";
            }
        }
    }
}
