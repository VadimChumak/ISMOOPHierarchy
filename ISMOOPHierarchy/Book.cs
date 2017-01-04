using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Book
    {
        private string title;
        private bool is_free;
        public Book()
            : this("Unknown", false)
        {
        }
        public Book(string title, bool free)
        {
            this.title = title;
            is_free = free;
        }
        public static bool AreFree(string str)
        {
            if (!File.Exists("Book.txt")) File.Create("Book.txt");
            string line = File.ReadAllText("Book.txt");
            string[] book_title=line.Split('\n','\r');
            foreach (string s in book_title)
            {
                if (s == str) return true;
            }
            return false;
        }
    }
}
