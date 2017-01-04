using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Doctor:Nurse
    {
        public Doctor()
            : base()
        {
           
        }
        public Doctor(string name, string lastname )
            : base(name, lastname)
        {
           
        }
        public override void SetAppoint(Patient pat)
        {
            Console.Write("Призначення : ");
            string str = Console.ReadLine();
            pat.SetAppoint(str);
            Console.WriteLine("Паціенту {0} призначено лікування", pat.Lastname);
        }
        public override void ShowInfo()
        {
            Console.WriteLine("---Данні про Лікаря---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
