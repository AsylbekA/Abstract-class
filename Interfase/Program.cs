using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    abstract class Person
    {
        private string _name;
        public string Name {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The name can't be empty");
                }
                else
                {
                    _name=value;
                }
            }  }

        public Person(string name)
        {
            Name = name;
        }

        public abstract void Display();
    }

    class Client : Person
    {
        public int Sum { get; set; }    // сумма на счету

        public Client(string name, int sum)
    : base(name)
        {
            Sum = sum;
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
    : base(name)
        {
            Position = position;
        }

        public override void Display()
        {
            Console.WriteLine($"Name:{Name} \tPosition:{Position}");
        }
    }


    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("","Programmer");
            employee.Display();
            Console.Read();
        }
    }
}
