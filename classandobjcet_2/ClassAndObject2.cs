using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobjcet_2
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person,Person2
    {
        public string City { get; set; }
    }

    class Student : Person,Person2
    {
        public string Department { get; set; }
    }

    interface Person2
    {
    }

    class Database
    {
        public string ad;
        public string soyad;
        public int number;

        public virtual string Add(string ad,string soyad,int num) {
            this.ad = ad;
            this.soyad = soyad;
            this.number = num;
            return ad + soyad + (number.ToString());
        }
        public virtual void Delete() {
            Console.WriteLine("Deleted by defaut");
        }
    }

    class SqlServer : Database
    {
        public void Kaydet()
        {
            Console.WriteLine(ad +" "+soyad +" "+number);  
        }
    }

    class OracleServer : Database
    {
        public void Kaydet()
        {
            Console.WriteLine(ad + " " + soyad + " " + number);
        }
    }

    abstract class Tecnology //abstract class = interface + inheritiance(virtual = abstract)
    {
        public void ElektrikTuket() => Console.WriteLine("elektrik");
        public abstract void GoruntuCikart(); 
    }

    class Computer : Tecnology
    {
        public override void GoruntuCikart()
        {
            Console.WriteLine("PC");
        }
    }

    class Television : Tecnology
    {
        public override void GoruntuCikart()
        {
            Console.WriteLine("TV");
        }
    }

    class Customers
    {
        public void Buy(Tecnology tecnology)
        {
            tecnology.GoruntuCikart();
            tecnology.ElektrikTuket();
        }
    }

    class ClassAndObject2
    {
        static void Main()
        {

            Customers customers = new Customers();
            Tecnology[] tecnology = new Tecnology[2];
            tecnology[0] = new Television();
            tecnology[1] = new Computer();

            foreach (Tecnology tecno in tecnology)
            {
                tecno.GoruntuCikart();
                tecno.ElektrikTuket();
                Console.WriteLine("--------------");
            }
            customers.Buy(tecnology[0]);
            customers.Buy(tecnology[1]);
                

            //Person[] persons = new Person[3]
            //{
            //    new Customer{
            //        FirstName = "Deniz"
            //    }
            //    ,new Student
            //    {
            //        FirstName = "Aysima"
            //    },
            //    new Person
            //    {
            //        FirstName = "Derya"
            //    }
            //};

            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item.FirstName);
            //}

            //SqlServer sq = new SqlServer();
            //OracleServer oq = new OracleServer();

            //sq.Add("Deniz", "Duman", 556);
            //sq.Kaydet();
            //oq.Add("Derya", "Duman", 345);
            //oq.Kaydet();

        }
    }
}
