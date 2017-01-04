using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Reader:Person , IPersonInfo
    {
        private List<Book> book_on_hand;
        public Reader()
            : base()
        {
        }
        public Reader(string name, string lastname)
            : base(name, lastname)
        {
            book_on_hand = new List<Book>();
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
        public bool AreBook
        {
            get
            {
                if (book_on_hand.Count > 0) return true;
                else return false;
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
        public Book GetBook()
        {
            Console.Write("Назва книги : ");
            string str = Console.ReadLine();
            if (Book.AreFree(str))
            {
                Book b = new Book(str, true);
                book_on_hand.Add(b);
                return b;
            }
            else
            {
                Console.WriteLine("Книга відсутня.");
                return new Book();
            } 
        }
        public void GiveBook()
        {
            book_on_hand.Clear();
            Console.WriteLine("Всі книги віддані");
        }
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про Читача---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
