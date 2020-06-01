using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    #region Abstract class
    //abstract class Person
    //{
    //    private string _name;
    //    public string Name {
    //        get { return _name; }
    //        set
    //        {
    //            if (string.IsNullOrEmpty(value))
    //            {
    //                Console.WriteLine("The name can't be empty");
    //            }
    //            else
    //            {
    //                _name=value;
    //            }
    //        }  }

    //    public Person(string name)
    //    {
    //        Name = name;
    //    }

    //    public abstract void Display();
    //}

    //class Client : Person
    //{
    //    public int Sum { get; set; }    // сумма на счету

    //    public Client(string name, int sum)
    //: base(name)
    //    {
    //        Sum = sum;
    //    }
    //    public override void Display()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Employee : Person
    //{
    //    public string Position { get; set; } // должность

    //    public Employee(string name, string position)
    //: base(name)
    //    {
    //        Position = position;
    //    }

    //    public override void Display()
    //    {
    //        Console.WriteLine($"Name:{Name} \tPosition:{Position}");
    //    }
    //}


    //class Program
    //{
    //    static void Main()
    //    {
    //        Employee employee = new Employee("","Programmer");
    //        employee.Display();
    //        Console.Read();
    //    }
    //}
    #endregion

    #region Обобщение generic
    class Person<T, U>
    {
        public string Name { get; set; }
        public int age { get; set; }
        public T IIN { get; set; }
        public U Summ { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            this.age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name:{Name} \tAde:{age} \tIIN:{IIN} \tSum nakoplenie:{Summ}");
        }
    }
    class Program
    {
        public static void Main()
        {
            Person<string, decimal> person = new Person<string, decimal>("Asylbek",22);
            person.IIN = "970615300619";
            person.Display();
            Console.Read();
        }
    }
    #endregion
}
