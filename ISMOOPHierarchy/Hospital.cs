using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Hospital
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
