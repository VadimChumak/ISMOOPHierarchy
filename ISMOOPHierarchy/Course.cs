using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Course:Group
    {
        public Course()
            : base()
        {
        }
        public Course(string title, List<Student> visitor)
            : base(title, visitor)
        {
        }
        public override void AddVisitor(Student student)
        {
            visitor.Add(student);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Назва курсу : {0}", GroupTitle);
            Console.WriteLine("Відвідувачі :" + Environment.NewLine + GroupVisitor);
        }

    }
}
