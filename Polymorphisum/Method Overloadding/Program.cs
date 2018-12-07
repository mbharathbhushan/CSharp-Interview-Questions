using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloadding
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new FullTimeEmployee();

            employee.PrintFullName();
            employee.PrintFullName("Bhushan");
            ////employee.PrintFullName("Bhushan", "Mangalpally");
            ///

            FullTimeEmployee employee2 = new FullTimeEmployee();

            employee2.PrintFullName();
            employee2.PrintFullName("Bhushan");
            employee2.PrintFullName("Bhushan", "Mangalpally");

            Console.ReadKey();
        }
    }

    public class Employee
    {
        public string FirstName = "FN";

        public string LastName = "LN";

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public void PrintFullName(string lastName)
        {
            Console.WriteLine(lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + "  " + lastName);
        }
    }
}
