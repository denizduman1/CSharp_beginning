using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Constructors
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager(3);
            customerManager.Add();
            int adet = customerManager.count;
            Console.WriteLine(adet);
            customerManager.List();
            Console.WriteLine("--------");
            CustomerManager customerManager2 = new CustomerManager();
            Console.WriteLine("--------");

            A objectA = new A(1, "Deniz") { id = 2, ad = "Derya" };
            objectA.display();

            Console.WriteLine("--------");

            Race race = new Race(new First());
            race.Add();

            Race race2 = new Race(new Second());
            race2.Add();

            Console.WriteLine("--------");

            HomeClass homeClass = new HomeClass("Varlık");
            homeClass.Message();
            Console.WriteLine("---------");
            homeClass.Msg();
            Teacher.Number = 10;
            Teacher.IslemYap();

            Do.DoSomething();
            Do yap = new Do();
            yap.DoSomething2();
        }
    }



    class Do{
        public static void DoSomething() { } //refsiz çağıralabilir.
        public void DoSomething2() { }
    }

    static class Teacher //newlenemez.Paylaşılan bir kaynak varsa kullanılabilir.
    {
        public static int Number { get; set; } //üyesi de static tanımlanmalıdır.
        public static void IslemYap() { }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("Message = {0}", _entity);
        }
    }

    class HomeClass : BaseClass 
    { 
       public HomeClass(string entity) : base(entity)
       {
       }
       public void Msg()
       {
            Console.WriteLine("HomeClass");
            Message();
       }
       
    }

    interface IBase
    {
        void Add();
        void Delete();
    }
    
    class First : IBase
    {
        public void Add()
        {
            Console.WriteLine("first add");
        }
        public void Delete()
        {
            Console.WriteLine("first delete");
        }
    }
    class Second : IBase
    {
        public void Add()
        {
            Console.WriteLine("second add");
        }
        public void Delete()
        {
            Console.WriteLine("second delete");
        }
    }
    
    class Race
    {
        IBase _ibase;
        public Race(IBase ibase)
        {
            _ibase = ibase;
        }

        public void Add()
        {
            _ibase.Add();
        }

    }

    class A
    {
        public int id;
        public string ad;

        public A(int id,string ad)
        {
            this.id = id;
            this.ad = ad;
        }

        public void display()
        {
            Console.WriteLine(id + " " + ad);
        }
    }

    class CustomerManager
    {
        int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
            Console.WriteLine("Constructor");
        }

        public CustomerManager()
        {
            Console.WriteLine("Based Constructor " + _count + " items default");
        }

        public int count {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public void List()
        {
            Console.WriteLine("Listed " + _count  + " items");
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }
}