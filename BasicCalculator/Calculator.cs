using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCorwin_Lab1
{
    public class Calculator
    {
        //set private variables for class paramaters
        private decimal var1;
        private decimal var2;
        private char op;
        
        //if no fields
        public Calculator() { }
        //for sqrt and 1/x
        public Calculator(decimal var1, char op)
        {
            this.Inpt1 = var1;
            this.Operand = op;
        }
        //with all populated fields
        public Calculator(decimal var1, char op, decimal var2)
        {
            this.Inpt1 = var1;
            this.Inpt2 = var2;
            this.Operand = op;
        }
        //geters and setters
        public decimal Inpt1
        {
            get { return var1; }
            set { var1 = value; }
        }
        public decimal Inpt2
        {
            get { return var2; }
            set { var2 = value; }
        }
        public char Operand
        {
            get { return op; }
            set { op = value; }
        }
        //method Result contains switch case to get operand and perform correct arithmatic
        public string Result()
        {
            string result;
            switch (Operand)
            {
                case '+':
                    decimal add = var1 + var2;
                    result = add.ToString();
                    return result;

                case '-':
                    decimal subtract = var1 - var2;
                    result = subtract.ToString();
                    return result;

                case '*':
                    decimal multiply = var1 * var2;
                    result = multiply.ToString();
                    return result;

                case '/':
                    decimal divide = var1 / var2;
                    result = divide.ToString();
                    return result;
                //sqrt
                case 's':
                    double s = Math.Sqrt(Convert.ToDouble(var1));
                    result = s.ToString();
                    return result;
                //1/x
                case 'x':
                    decimal x = 1 / var1;
                    result = x.ToString();
                    return result;
                //if just a number and = is pressed then return var2
                default:
                    return var2.ToString();
            }
        }
    }
}
