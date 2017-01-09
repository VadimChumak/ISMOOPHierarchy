using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ISMOOPHierarchy
{
    public class Teacher:Person , IPersonInfo , ICloneable , IComparable<Teacher>
    {
        public Teacher()
            : base()
        {
        }
        public Teacher(string name, string lastname)
            : base(name, lastname)
        {
        }
        public int CompareTo(Teacher a)
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
            return this.MemberwiseClone();
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
