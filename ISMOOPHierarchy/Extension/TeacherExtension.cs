using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Extension
{
    public static class TeacherExtension
    {
        public static string GetFIO(this Teacher t)
        {
            string str = t.Name + " " + t.Lastname;
            return str;
        }
        public static void Print(this Teacher t)
        {
            Console.WriteLine("Данні про викладача : {0} {1}", t.Name, t.Lastname);
        }
    }
}
