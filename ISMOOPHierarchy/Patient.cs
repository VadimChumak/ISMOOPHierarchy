using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    public  class Patient : Person, IPersonInfo, ICloneable, IComparable<Patient>
    {
        private string appointment;
        public Patient()
            : base()
        {
            appointment = "Unknown";
        }
        public Patient(string name, string lastname  , string appoint)
            : base(name, lastname)
        {
            appointment = appoint;
        }
        public int CompareTo(Patient p)
        {
            string str1 = p.appointment;
            string[] mass = str1.Split(' ');
            string[] arr = this.appointment.Split(' ');
            if (arr.Length > mass.Length) return 1;
            else if (arr.Length < mass.Length) return -1;
            else return 0;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public string Appointment
        {
            set
            {
                appointment = value;
            }
            get
            {
                return appointment;
            }
        }
        public bool Health
        {
            get
            {
                if (appointment == "") return true;
                else return false;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Lastname
        {
            set
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }
        public void SetAppoint(string str)
        {
            Appointment = str;
        }
        public void ResetAppoint()
        {
            Appointment = "";
        }
        public void ShowInfo()
        {
            Console.WriteLine("---Данні про Пацієнта---");
            Console.WriteLine("Ім'я : {0}", Name);
            Console.WriteLine("Фамілія : {0}", Lastname);
        }
    }
}
