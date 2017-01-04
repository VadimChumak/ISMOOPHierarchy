using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISMOOPHierarchy
{
    class Medecine : IMenu
    {
        private Patient patient;
        private Nurse nurse;
        private Doctor doctor;
        private Hospital hospital;
        public Medecine()
        {
            hospital = new Hospital();
            doctor = new Doctor("Ivanov", "Ivan");
            nurse = new Nurse("Olena", "Petrova");
            patient = new Patient("Ostap", "Ostapov", " ");
            hospital.Add(patient);
        }
        public void Menu()
        {
            int cay = -1;
            while (cay != 0)
            {
                Console.Clear();
                Console.WriteLine("1.Назначити лікування лікарем");
                Console.WriteLine("2.Назначити лікування медсестрою");
                Console.WriteLine("3.Виконати назначення");
                Console.WriteLine("4.Виписати паціента");
                cay = int.Parse(Console.ReadLine());
                switch (cay)
                {
                    case 1:
                        Console.Clear();
                        doctor.SetAppoint(patient);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        nurse.SetAppoint(patient);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        doctor.ResetAppoint(patient);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        hospital.Remove(patient);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
