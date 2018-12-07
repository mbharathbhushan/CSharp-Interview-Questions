using System;

namespace InterfacesSample
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            ((IEmployee)employee).hello(1);
            ((IEmployee2)employee).hello(1);

            IEmployee emp1 = new Employee();
            IEmployee2 emp2 = new Employee();

            emp1.hello(1);
            emp2.hello(1);

         

          

            Console.ReadKey();
        }
    }

    public interface IEmployee
    {
        string Name { get; }

        int Id { get; set; }

        bool hello(int a);
    }

    public interface IEmployee2
    {
        bool hello(int a);
    }

    public class Employee : IEmployee, IEmployee2
    {
        public string _name;

        public int _id;

        public string Name
        {
            get { return _name; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        bool IEmployee2.hello(int a)
        {
            Console.WriteLine("IEmployee 2");
            return true;
        }

        bool IEmployee.hello(int a)
        {
            Console.WriteLine("IEmployee");
            return true;
        }
    }
}
