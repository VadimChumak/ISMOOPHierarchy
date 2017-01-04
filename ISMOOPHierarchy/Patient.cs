using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Patient:Person , IPersonInfo
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
