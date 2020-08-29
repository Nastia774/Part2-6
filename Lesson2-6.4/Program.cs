using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6._4
{
    class Program
    {
        static int[] CraeteArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
            }
            return array;
        }
        static void SortAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }
                }
            }
        }
        static void Write(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = new int[8];
            array = CraeteArray(array);
            Write(array);

            SortAsc(array);
            Write(array);

            Console.ReadKey();
        }
    }
}
