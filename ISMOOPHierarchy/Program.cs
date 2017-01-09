using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISMOOPHierarchy.Comparer;
namespace ISMOOPHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Paiments pai = new Paiments();
            Medecine med = new Medecine();
            Librery lib = new Librery();
            Facult fac = new Facult();
            Examens ex = new Examens();
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1. Система Платежі");
                Console.WriteLine("2. Система Госпіталь");
                Console.WriteLine("3. Система Бібліотека");
                Console.WriteLine("4. Система Факультатив");
                Console.WriteLine("5. Система Екзамен");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        pai.Menu();
                        break;
                    case 2:
                        Console.Clear();
                        med.Menu();
                        break;
                    case 3:
                        Console.Clear();
                        lib.Menu();
                        break;
                    case 4:
                        Console.Clear();
                        fac.Menu();
                        break;
                    case 5:
                        Console.Clear();
                        ex.Menu();
                        break;
                }
            }
        }
    }
}
