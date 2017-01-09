using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
   public abstract class Group
    {
        protected string group_title;
        protected List<Student> visitor;
        public Group(string title, List<Student> visitor)
        {
            group_title = title;
            this.visitor = visitor;
        }
        public Group()
            : this("Unknown" , null)
        {
        }
        public string GroupTitle
        {
            set
            {
                group_title = value;
            }
            get
            {
                return group_title;
            }
        }
        public string GroupVisitor
        {
            get
            {
                string str = "";
                foreach (Student st in visitor)
                {
                    str += st.Name + " " + st.Lastname + Environment.NewLine;
                }
                return str;
            }
        }
        public abstract void PrintInfo();
        public abstract void AddVisitor(Student student);
    }
}
