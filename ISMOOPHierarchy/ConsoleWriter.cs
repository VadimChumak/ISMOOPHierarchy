using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Extension;

namespace ISMOOPHierarchy
{
    public static class ConsoleWriter
    {
        public static void Print(Student s)
        {
            s.ShowInfo();
        }
        public static void Print(Teacher t)
        {
            t.Print();
        }
        public static void Print(Client c)
        {
            c.ShowInfo();
        }
        public static void Print(Admin a)
        {
            a.ShowInfo();
        }
        public static void Print(Patient p)
        {
            p.ShowInfo();
        }
        public static void Print(Nurse n)
        {
            n.ShowInfo();
        }
        public static void Print(Doctor d)
        {
            d.ShowInfo();
        }
        public static void Print(Reader r)
        {
            r.ShowInfo();
        }
        public static void Print(Librerian l)
        {
            l.ShowInfo();
        }
        public static void Print(Course c)
        {
            c.PrintInfo();
        }
        public static void Print(Faculty f)
        {
            f.PrintInfo();
        }
        public static void Print(Book b)
        {
            b.Print();
        }
        public static void Print(Archive a)
        {
            a.PrintInfo();
        }
        public static void Print(Account a)
        {
            a.PrintInfo();
        }
        public static void Print(KK k)
        {
            k.PrintInfo();
        }
        public static void Print(Ordering o)
        {
            o.Print();
        }
    }
}
