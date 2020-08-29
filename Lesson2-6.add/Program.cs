using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6.add
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 5;
            double two = 4.75;
            Console.WriteLine($"Plus : {Calculator.Plus(one, two)}");
            Console.WriteLine($"Minus : {Calculator.Minus(one, two)}");
            Console.WriteLine($"Multiply : {Calculator.Multiply(one, two)}");
            Console.WriteLine($"Divide : {Calculator.Divide(one, two)}");



            Console.ReadKey();
        }
    }
}
