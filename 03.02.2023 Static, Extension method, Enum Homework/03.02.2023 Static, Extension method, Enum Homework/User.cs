using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02._2023_Static__Extension_method__Enum_Homework
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public RegistrationMonth RegistrationMonth { get; set; }
        public string PIN {
            get
            {
                return pin;
            }
            
            set
            {
                if (value.IsCorrectPin())
                {
                    pin = value;
                }
                else
                {
                    throw new Exception("Passed pin is invalid");
                }
            }
        }
        private string pin;

        public User(string name, string surname, RegistrationMonth registrationMonth,string pin)
        {
            Name = name;
            Surname = surname;
            RegistrationMonth = registrationMonth;
            PIN = pin;
        }

        public string GetDetails()
        {
            return $"{Name}, {Surname}, {RegistrationMonth}, {PIN}";
        }
    }
}
