using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public class Hospital : ICloneable , IComparable<Hospital>
    {
        private List<Patient> Archivs;
        public Hospital()
        {
            Archivs = new List<Patient>();
        }
        public void Add(Patient pat)
        {
            Archivs.Add(pat);
        }
        public int CompareTo(Hospital h)
        {
            if (this.Archivs.Count > h.Archivs.Count) return 1;
            else if (this.Archivs.Count < h.Archivs.Count) return -1;
            else return 0;
        }
        public object Clone()
        {
            Hospital h = new Hospital();
            for (int i = 0; i < Archivs.Count; i++)
            {
                h.Add((Patient)Archivs[i].Clone());
            }
            return h;
        }
        public void Remove(Patient pat)
        {
            if (pat.Health)
            {
                Archivs.Remove(pat);
                Console.WriteLine("Паціента виписано");
            }
            else Console.WriteLine("Паціент не пройшов курс лікування");
        }
    }
}
