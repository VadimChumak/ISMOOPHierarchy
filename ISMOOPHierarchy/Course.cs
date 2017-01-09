using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Course:Group , ICloneable , IComparable<Course>
    {
        public Course()
            : base()
        {
        }
        public Course(string title, List<Student> visitor)
            : base(title, visitor)
        {
        }
        public List<Student> Visit
        {
            get
            {
                return visitor;
            }
        }
        public int CompareTo(Course c)
        {
            if (this.visitor.Count > c.visitor.Count) return 1;
            else if (this.visitor.Count < c.visitor.Count) return -1;
            else return 0;
        }
        public object Clone()
        {
            return new Course(this.GroupTitle, this.visitor);
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
