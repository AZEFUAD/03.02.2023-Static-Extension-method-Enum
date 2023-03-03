using System;
namespace _03._02._2023_Static__Extension_method__Enum_Homework
{
    public class Program
    {
        static void Main()
        {
            User user = new User("Fuad", "Sultanli", RegistrationMonth.September, "FSH24LD");
            Console.WriteLine(user.GetDetails());
            User user1 = new User("Elvin", "Ibrahimov", RegistrationMonth.November, "EI34HDL");
            Console.WriteLine(user1.GetDetails());
            User user2 = new User("Senan", "Abdullayev", RegistrationMonth.December, "SA86LKM");
            Console.WriteLine(user2.GetDetails());
            User user3 = new User("Jack", "Osmanov", RegistrationMonth.March, "JOL42MK");
            Console.WriteLine(user3.GetDetails());
            User user4 = new User("Koroglu", "Abbasov", RegistrationMonth.June, "KA98MCR");
            Console.WriteLine(user4.GetDetails());
        }
    }
}

