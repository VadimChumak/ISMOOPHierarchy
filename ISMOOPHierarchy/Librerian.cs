using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Librerian:Person , IPersonInfo
    {
        private BookOrder bo;
        private List<Reader> black_list;
        public Librerian()
            : base()
        {
        }
        public Librerian(string name, string lastname)
            : base(name, lastname)
        {
            bo = new BookOrder();
            black_list = new List<Reader>();
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
        public void GiveBook(Reader r)
        {
            bo.Confirm(r);
            Console.WriteLine("Книгу видано !");
        }
        public void AddToBL(Reader r)
        {
            black_list.Add(r);
        }
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про Бібліотекаря---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
