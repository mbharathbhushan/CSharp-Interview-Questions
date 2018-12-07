using System;

namespace Struct
{
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
