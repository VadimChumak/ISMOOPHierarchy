using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Doctor:Nurse,ICloneable , IComparable<Doctor>
    {
        public Doctor()
            : base()
        {
           
        }
        public Doctor(string name, string lastname )
            : base(name, lastname)
        {
           
        }
        public int CompareTo(Doctor a)
        {
            int res = this.name.CompareTo(a.name);
            if (res == 0)
            {
                return this.lastname.CompareTo(a.lastname);
            }
            else return res;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
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
