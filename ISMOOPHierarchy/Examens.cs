using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Examens:IMenu
    {
        private Faculty facult;
        private Teacher teacher;
        private List<Exams> exams;
        private Archive archive;
        public Examens()
        {
            facult = new Faculty("FICT", new List<Student>());
            teacher = new Teacher("Ivanov", "Ivan");
            exams = new List<Exams>();
            archive = new Archive();
        }
        public void Menu()
        {
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1.Записатись на факультет та здати екзамен");
                Console.WriteLine("2.Виставити оцінки");
                Console.WriteLine("3.Вивести студентів , що зараховані");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Ім'я : ");
                        string name = Console.ReadLine();
                        Console.Write("Фамілія : ");
                        string lastname = Console.ReadLine();
                        Student st = new Student(name, lastname);
                        Exams ex = new Exams("OPI", st);
                        exams.Add(ex);
                        facult.AddVisitor(st);
                        Console.WriteLine("Ви записані на факультет та написали екзамен");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        foreach (Exams e in exams)
                        {
                            double i=double.Parse(Console.ReadLine());
                            e.SetMark(i);
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        double smark = 0.0;
                        foreach (Exams e in exams)
                        {
                            smark += e.Mark;
                        }
                        smark /= exams.Count;
                        foreach (Exams n in exams)
                        {
                            if (n.Mark >= smark)
                            {
                                n.Students.ShowInfo();
                            }
                        }
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
