using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Archive:ICloneable , IComparable<Archive>
    {
        public struct PersonInform
        {
           public string object_name;
           public Student student;
           public double mark;
        }
        List<PersonInform> info;
        public Archive()
        {
            info = new List<PersonInform>();
        }

        public PersonInform this[int i]
        {
            get
            {
                return info[i];
            }
        }
        public int CompareTo(Archive a)
        {
            return this.info.Count.CompareTo(a.info.Count);
        }
        public object Clone()
        {
            Archive ar = new Archive();
            for (int i = 0; i < info.Count; i++)
            {
                ar.AddToArchive(info[i]);
            }
            return ar;
        }
        public void AddToArchive(PersonInform p)
        {
            info.Add(p);
        }

        public void AddToArchive(Student st, Group gr, double mark)
        {
            PersonInform inf;
            inf.object_name = gr.GroupTitle;
            inf.student = st;
            inf.mark = mark;
            info.Add(inf);
        }
        public void PrintInfo()
        {
            foreach (PersonInform i in info)
            {
                Console.WriteLine(i.student.Name + " " + i.student.Lastname + Environment.NewLine);
                Console.WriteLine(i.object_name + Environment.NewLine);
                Console.WriteLine(i.mark + Environment.NewLine);
                Console.WriteLine("----------------------------"+Environment.NewLine);

            }
        }
    }
}
