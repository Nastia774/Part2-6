using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6._3
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
        public class Notes
        {
            public void AddNotes(string str)
            {
                if (str != "")
                    Console.WriteLine("Заметка добавлена. ");
                else
                    Console.WriteLine("Заметка отсутствует. ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {/*Расширьте пример урока 005_Delegation, создав в классе Book, вложенный класс Notes, который
позволит сохранять заметки читателя.*/
            Console.Write("Введите заметку : ");
            string str = Console.ReadLine();

            Book.Notes book = new Book.Notes();
            book.AddNotes(str);

            Console.ReadKey();
        }
    }
}
