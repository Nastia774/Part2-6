using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_6._2
{
    static class FindAndReplaceManager
    {
        public static string FindNext(string str, string[] str1)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str == str1[i])
                    return str1[i];
            }
            return "Такая строка не найдена.";
        }
    }
}
