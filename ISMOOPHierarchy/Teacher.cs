using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Teacher:Person , IPersonInfo
    {
        public Teacher()
            : base()
        {
        }
        public Teacher(string name, string lastname)
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
        public void SetMark(Student st, Group gr , Archive arch)
        {
            Console.WriteLine("Оцінка для "+st.Name+" "+st.Lastname+" за курс "+gr.GroupTitle+Environment.NewLine);
            double mark = double.Parse(Console.ReadLine());
            arch.AddToArchive(st, gr, mark);
        }
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про викладача---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
