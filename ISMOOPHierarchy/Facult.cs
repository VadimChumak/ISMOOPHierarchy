using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Facult:IMenu
    {
        private Teacher teacher;
        private Student student;
        private Course course;
        private Archive archive;
        public Facult()
        {
            teacher = new Teacher("Ivan", "Ivanov");
            student = new Student("Petro", "Petrov");
            course = new Course();
            archive = new Archive();
        }
        public void Menu()
        {
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1.Оголосити набір на курс");
                Console.WriteLine("2.Записатися на курс");
                Console.WriteLine("3.Виставити оцінку");
                Console.WriteLine("4.Інформація з архіву");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Назва курсу : ");
                        string title = Console.ReadLine();
                        course = new Course(title, new List<Student>());
                        Console.WriteLine("Набір на курс оголошено");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        student.SubscribeCourse(course);
                        Console.WriteLine("Студент {0} записався на курс {1}", student.Lastname, course.GroupTitle);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        teacher.SetMark(student, (Group)course, archive);
                        Console.WriteLine("Оцінку збережено до архіву");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        archive.PrintInfo();
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
