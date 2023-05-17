using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConstrctorLess constrctorLess = new ConstrctorLess
            {
                FirstName = "Bharath",
                LastName = "Mangalpally"
            };
            constrctorLess.Print();
            ConstrctorClass constrctorClass = new ConstrctorClass();
            constrctorClass = new ConstrctorClass("Archana", "M");
            constrctorClass = new ConstrctorClass(constrctorLess);
            PrivateConstructor privateConstructor = new PrivateConstructor("d");

            employee emp = new employee();
            emp.Salary();
            Console.ReadKey();
        }
    }

    public class ConstrctorLess
    {
        public string FirstName;

        public string LastName;

        public void Print()
        {
            Console.WriteLine("I am from Constrctor Less class");
        }

    }

    public class ConstrctorClass
    {
        public string FullName;
        public ConstrctorClass()
        {
            FullName = "Bharth";
            Console.WriteLine(FullName + "From Default Constructor");
        }

        public ConstrctorClass(string firstName, string LastName)
        {
            FullName = firstName + LastName;
                Console.WriteLine(FullName + "From Parameterized Constructor");
        }

        public ConstrctorClass(ConstrctorLess constrctorLess)
        {
            FullName = constrctorLess.FirstName + constrctorLess.LastName;
            Console.WriteLine(FullName + "From Copy Constructor");
        }




    }


    public class PrivateConstructor
    {

        private PrivateConstructor()
        {
        }

        public PrivateConstructor(string s)
        {
            Console.WriteLine("Private Constructore");
        }
    }


    public class employee
    {
        static employee()
        {
            Console.WriteLine("The static constructor ");
        }
        public employee()
        {
            Console.WriteLine("The non-static constructor of employee");
        }
        public void Salary()
        {
            Console.WriteLine();
            Console.WriteLine("The Salary method");
        }
    }
    
}
