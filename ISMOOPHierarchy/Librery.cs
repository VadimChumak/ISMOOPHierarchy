using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Librery:IMenu
    {
        Book book;
        Reader reader;
        Librerian librerian;
        public Librery()
        {
             book = new Book();
             reader = new Reader("Ivan", "Ivanov");
             librerian = new Librerian("Katerina", "Petrova");
        }
        public void Menu()
        {
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1.Оформити замовлення на книгу");
                Console.WriteLine("2.Віддати книгу");
                Console.WriteLine("3.Покинути бібліотеку");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        librerian.GiveBook(reader);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        reader.GiveBook();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (reader.AreBook)
                        {
                            Console.WriteLine("Ви не повернули книги! Вас додано в чорний список!");
                            librerian.AddToBL(reader);
                        }
                        else Console.WriteLine("Бібліотеку покинуто!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
