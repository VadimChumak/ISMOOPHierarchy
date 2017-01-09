using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Book : ICloneable , IComparable<Book>
    {
        private string title;
        private bool is_free;
        public Book()
            : this("Unknown", false)
        {
        }
        public int CompareTo(Book b)
        {
            int res = this.is_free.CompareTo(b.is_free);
            if (res == 0)
            {
                return this.Title.CompareTo(b.Title);
            }
            else return res;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public Book(string title, bool free)
        {
            this.title = title;
            is_free = free;
        }
        public string Title
        {
            get
            {
                return title;
            }
        }
        public bool AreActive
        {
            get
            {
                if (is_free == true) return true;
                else return false;
            }
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
