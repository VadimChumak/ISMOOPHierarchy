using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Admin:Person , IPersonInfo , ICloneable , IComparable<Admin>
    {
        public Admin()
            : base()
        {
        }
        public Admin(string name, string lastname)
            : base(name, lastname)
        {
           
        }
        public int CompareTo(Admin a)
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
            return new Admin(this.Name, this.Lastname);
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
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про Адміністратора---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
        public void BlockCard(KK card)
        {
            card.RemoveCard();
        }
    }
}
