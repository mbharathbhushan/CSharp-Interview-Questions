using System;

namespace Polymorphisum
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new FullTimeEmployee();
            employees[2] = new PartTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach(var emp in employees)
            {
                emp.PrintFullName();
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public string FirstName = "FN";

        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Full Time Employee");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Part Time Employee");
        }
    }

    public class TemporaryEmployee : Employee
    {
        ////public override void PrintFullName()
        ////{
        ////    Console.WriteLine(FirstName + " " + LastName + " - Temporary Employee");
        ////}

    }
}
