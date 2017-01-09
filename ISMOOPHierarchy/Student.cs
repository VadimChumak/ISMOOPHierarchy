using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Student:Person , IPersonInfo , ICloneable , IComparable<Student>
    {
       
        public Student()
            : base()
        {
        }
        public Student(string name, string lastname)
            : base(name, lastname)
        {
           
        }
        public int CompareTo(Student a)
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
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про студента---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
        public void SubscribeCourse(Group gr)
        {
            gr.AddVisitor(this);
        }
    }
}
