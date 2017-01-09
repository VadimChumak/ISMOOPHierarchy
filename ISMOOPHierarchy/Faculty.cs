using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Faculty:Group , ICloneable , IComparable<Faculty>
    {
        public Faculty()
            : base()
        {
        }
        public Faculty(string title, List<Student> visitor)
            : base(title, visitor)
        {
        }
        public int CompareTo(Faculty c)
        {
            if (this.visitor.Count > c.visitor.Count) return 1;
            else if (this.visitor.Count < c.visitor.Count) return -1;
            else return 0;
        }
        public object Clone()
        {
            return new Faculty(this.GroupTitle, this.visitor);
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
