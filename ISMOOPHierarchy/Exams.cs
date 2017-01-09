using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Exams : ICloneable , IComparable<Exams>
    {
        private Student student;
        private string name;
        private double mark;
        public Exams(string name , Student st)
        {
            student = st;
            this.name = name;
            mark = 0.0;
        }
        public int CompareTo(Exams e)
        {
            int res = this.Mark.CompareTo(e.Mark);
            if (res == 0)
            {
                return this.Students.CompareTo(e.Students);
            }
            else return res;
        }
        public object Clone()
        {
            Exams e = new Exams(this.name, (Student)this.Students.Clone());
            e.mark = Mark;
            return e;
        }
        public Student Students
        {
            get
            {
                return student;
            }
        }
        public double Mark
        {
            get
            {
                return mark;
            }
        }
        public void SetMark(double mark)
        {
            Console.WriteLine("Робота студента {0}", student.Lastname);
            this.mark = mark;
            Console.WriteLine("Оцінка для {0} виставлена", student.Lastname);
        }
    }
}
