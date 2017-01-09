using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Extension
{
    public static class BookExtension
    {
        public static string AreAct(this Book b)
        {
            if (b.AreActive) return "Книга доступна";
            else return "Книга відсутня";
        }
        public static void Print(this Book b)
        {
            Console.WriteLine("Назва книги : {0}", b.Title);
            if (b.AreActive == true) Console.WriteLine("Наявна в бібліотеці.");
            else Console.WriteLine("Книга відсутня.");
        }
    }
}
