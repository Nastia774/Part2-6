using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6._2
{
    class Book
    {
        string[] str1 = new string[3]{"Архимедовы штаны во все стороны равны.",
   "И сонце ярче светится, и веселее пеезаж, когда в желудке плещица С2Н5ОН.",
   "Тело впертое у воду выперает на свободу, обьем выпертой воды тела впертого туды." };
        public string[] Str1
        {
            get { return str1; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string newstr = "Архимедовы штаны во все стороны равны.";
            Book book = new Book();

            Console.WriteLine($"Поиск строки произведен, строка найдена : {FindAndReplaceManager.FindNext(newstr, book.Str1)}");

            Console.ReadKey();
        }
    }
}