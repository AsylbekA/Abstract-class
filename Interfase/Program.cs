using DocumentFormat.OpenXml.ExtendedProperties;
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
    //class Person<T, U>
    //{
    //    public string Name { get; set; }
    //    public int age { get; set; }
    //    public T IIN { get; set; }
    //    public U Summ { get; set; }
    //    public Person(string name,int age)
    //    {
    //        Name = name;
    //        this.age = age;
    //    }

    //    public void Display()
    //    {
    //        Console.WriteLine($"Name:{Name} \tAde:{age} \tIIN:{IIN} \tSum nakoplenie:{Summ}");
    //    }
    //}
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Person<string, decimal> person = new Person<string, decimal>("Asylbek",22);
    //        person.IIN = "970615300619";
    //        person.Display();
    //        Console.Read();
    //    }
    //}
    #endregion

    #region Обобщенные методы
    //class Program
    //{
    //    public static void Main()
    //    {

    //    }

    //    //private void Add<T, V>(T a,V s)
    //    //{
    //    //    double a;

    //    //}
    //}
    #endregion

    #region try catch finnaly
    //class Program
    //{
    //    private static int y,x;

    //    public static void Main()
    //    {
    //        try
    //        {
    //            int x = 5;
    //            int y = x / 1;
    //            Console.WriteLine(Math.Sqrt(5));

    //            Person person = new Person("AsekeSAFDSCSDVFDVDSVER", 15, message: "");
    //            person.Display();
    //        }
    //        catch (Exception ex) when (y == 0 && x == 0)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //        Console.Read();
    //    }
    //}

    //internal class Person:Exception
    //{
    //    private int age;
    //    private string name;
    //    internal string Name {set
    //        {
    //            if (value.Length > 12)
    //            {
    //                throw new Exception("Tne name can't more than 12 simvols");
    //            }
    //            else
    //            {
    //                name = value;
    //            }
    //        }
    //        get
    //        {
    //            return name;
    //        }
    //    }
    //    internal int Age {
    //        set
    //        {
    //            if (value <= 18)
    //            {
    //                throw new Exception("The age can't be min 18");
    //            }
    //            else
    //            {
    //                age = value;
    //            }
    //        }
    //        get { return age; }
    //    }

    //    internal Person(string name,int age,string message):base(message)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public Person(string message, int v) : base(message)
    //    {
    //    }

    //    internal virtual void Display()
    //    {
    //        Console.WriteLine($"Name:{Name} \tAge:{Age}");
    //    }
    //}
    #endregion
    #region Interface
    interface IAccount
    {
        int CurrentSum { get; }  // Текущая сумма на счету
        void Put(int sum); // Положить деньги на счет
        void Withdraw(int sum); // Взять со счета

        void Movie(); // метод для явной реализация
    }
    interface IClient
    {
        string Name { get; set; }
    }
    class Client : IClient, IAccount
    {
        int _sum;
        public string Name { get; set; }

        public int CurrentSum { get { return _sum; } }

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
        void IAccount.Movie() // метод для явной реализация
        {
            Console.WriteLine("Movie");
        }
       public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
    }


   public interface ICloneable // Копирование объектов. Интерфейс ICloneable
    {
        object Clone();
    }

    class Person:ICloneable //Копирование объектов. Интерфейс ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Company Work { get; set; }
        public object Clone()
        {

            Company _company = new Company { Name = this.Work.Name };
            new Person
            {
                Name = this.Name,
                Age = this.Age,
                Work = _company
            };
            return this.MemberwiseClone();
        }
    } 
    class Company
    {
        public string Name { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Client client = new Client("Asulbek",2000000);
            client.Put(100000);
            Console.WriteLine(client.CurrentSum);
            client.Withdraw(1500000);
            Console.WriteLine($"Ostatok na c4ete:{client.CurrentSum}");

            ((IAccount)client).Movie(); //необходимо приведение к типу IAccount


            #region Копирование объектов. Интерфейс ICloneable
            Person person = new Person { Name = "Asylbek", Age = 22, Work = new Company { Name = "Microsoft" } };
            Console.WriteLine(person.Work.Name);
            Person person1 = new Person { Name = "Madiyar", Age = 22, Work = new Company { Name = "Apple" } };
            Console.WriteLine(person1.Work.Name);
            #endregion
            Console.Read();
        }
    }
    #endregion
}
