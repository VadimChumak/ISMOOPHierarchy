using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Faculty:Group
    {
        public Faculty()
            : base()
        {
        }
        public Faculty(string title, List<Student> visitor)
            : base(title, visitor)
        {
        }
        public override void AddVisitor(Student student)
        {
            visitor.Add(student);
        }
        public override void PrintInfo()
        {
            Console.WriteLine("Назва факультету : {0}", GroupTitle);
            Console.WriteLine("Відвідувачі :" + Environment.NewLine + GroupVisitor);
        }
    }
}
