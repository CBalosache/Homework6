using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class CalculatorUnderTest
    {
        public double Divide(double num1,double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Minus(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
    }
}
