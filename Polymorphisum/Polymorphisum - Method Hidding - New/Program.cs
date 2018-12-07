using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisum___Method_Hidding___New
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[2];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
   

            foreach (var emp in employees)
            {
                if(emp.ToString() != "Polymorphisum___Method_Hidding___New.Employee")
                {
                    Console.WriteLine("----------------------------------------------------------");
                    Console.WriteLine("Calling the base class methods even we assign child class to base class. (Vice Vesa in Overrid)");
                }

                emp.PrintFullName();

            }
            Console.ReadLine();
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
    }

    public class FullTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time Employee");
        }
    }
  
}
