using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Nurse:Person , IPersonInfo
    {
        public Nurse()
            : base()
        {
           
        }
        public Nurse(string name, string lastname )
            : base(name, lastname)
        {
           
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public virtual void SetAppoint(Patient pat)
        {
            Console.WriteLine("Виписано направлення до лікаря");
        }
        public void ResetAppoint(Patient pat)
        {
            pat.ResetAppoint();
            Console.WriteLine("Призначення виконані!");
        }
        public string Lastname
        {
            set
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("---Данні про Медсестру---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
