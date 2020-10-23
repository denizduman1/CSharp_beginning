using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class AccessModifier
    {
        static void Main()
        {
            //Student student = new Student();
            //student.ID = 1;

        }
    }

    //internal class Course  //default class'lar internaldır.Bağlı olduğu projede refarans ihtiyacı olmadan kullanabiliriz.Public class lar tüm projelerde referans eklenip çalışılabilir.
    //{
    //    public string Name { get; set; }
    //}

    //protected class School
    //{
    //    public int MyProperty { get; set; }
    //}
    //class Customer
    //{
    //    public int ID { get; set; }
    //    private int id; //private blok içerisinde kullanılabilir.

    //    protected string ad; //private özelliklerini karşılar.privatedan farklı kalıtım yaptığı sınıflarda da kullanılabilir.
    //}

    //class Student:Customer
    //{
    //    public void Save()
    //    {
    //        ID = 1;
    //        ad = "0";
    //    }

    //    //public void Save()
    //    //{
    //    //    Customer customer = new Customer();
    //    //    customer.ID = 1;
    //    //}
    //}
}
