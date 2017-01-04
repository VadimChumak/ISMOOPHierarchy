using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Student:Person , IPersonInfo
    {
       
        public Student()
            : base()
        {
        }
        public Student(string name, string lastname)
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
