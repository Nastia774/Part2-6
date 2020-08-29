using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6.add
{
    static class Calculator
    {
        public static double Plus(double one, double two)
        {
            return one + two;
        }
        public static double Minus(double one, double two)
        {
            return one - two;
        }
        public static double Multiply(double one, double two)
        {
            return one * two;
        }
        public static double Divide(double one, double two)
        {
            if (two == 0)
            {
                Console.WriteLine("Попытка деления на ноль. ");
                return 0;
            }
            else
                return one / two;
        }
    }
}
