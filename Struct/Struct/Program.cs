using System;

namespace Struct
{
    struct Simple
    {
        public int Position;
        public bool Exists;
        public double LastValue;
    };
    class Program
    {
        static void Main(string[] args)
        {
            Employee structEmployee = new Employee
            {
                id = 100
            };

            Console.WriteLine(structEmployee.id);

            Console.WriteLine(Update(structEmployee).id);
            Console.WriteLine(structEmployee.id);


            Simple s;
            s.Position = 1;
            s.Exists = false;
            s.LastValue = 5.5;
            // ... Write struct field.
            Console.WriteLine(s.Position);
            Console.ReadKey();
        }

        static Employee Update(Employee emp)
        {
            emp.id = 0;
            return emp;
        }
    }

    struct Employee
    {
        public int id { get; set; }
    }

}
