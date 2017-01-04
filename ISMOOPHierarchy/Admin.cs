using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Admin:Person , IPersonInfo
    {
        public Admin()
            : base()
        {
        }
        public Admin(string name, string lastname)
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
