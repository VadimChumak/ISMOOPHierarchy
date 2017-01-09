using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy.Comparer
{
    class CourseVisiterGrate:IComparer<Course>
    {
        public int Compare(Course a, Course b)
        {
            if (a.Visit.Count > b.Visit.Count) return -1;
            else if (a.Visit.Count < b.Visit.Count) return 1;
            else return 0;
        }
    }
    class CourseVisiterLess : IComparer<Course>
    {
        public int Compare(Course a, Course b)
        {
            if (a.Visit.Count > b.Visit.Count) return 1;
            else if (a.Visit.Count < b.Visit.Count) return -1;
            else return 0;
        }
    }
    class CourseTitleLess : IComparer<Course>
    {
        public int Compare(Course a, Course b)
        {
            if (a.GroupTitle.CompareTo(b.GroupTitle)==-1) return -1;
            else if (a.GroupTitle.CompareTo(b.GroupTitle)==1) return 1;
            else return 0;
        }
    }
    class CourseTitleGrate : IComparer<Course>
    {
        public int Compare(Course a, Course b)
        {
            if (a.GroupTitle.CompareTo(b.GroupTitle) == 1) return -1;
            else if (a.GroupTitle.CompareTo(b.GroupTitle) == -1) return 1;
            else return 0;
        }
    }
}
