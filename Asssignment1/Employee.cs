using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssignment1
{
    internal class Employee : Person, Idisplayable
    {
        private int e_Id;
        public Employee(string? firstName, string? lastName, int age, int e_id): base(firstName, lastName, age)
        {
            E_Id = e_Id;
        }

        public int E_Id { get => e_Id; set => e_Id = value; }

        public void DisplayInfo(int age)
        {
            if (age >= 18 && age <= 100)
                Console.WriteLine($" Emplouee Id:" + E_Id);
            Console.WriteLine($"fullname:" + FirstName + LastName);
            Console.WriteLine($"Age:" + Age);

        }
    }
}
