using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calculator
    {
        private double num1;
        private double num2;
        public Calculator(double num1,double num2) 
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException("Cannot Divide By Zero");
            }
            return num2 / num1;
        }
    }
}
