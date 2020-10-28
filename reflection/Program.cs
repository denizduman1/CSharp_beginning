using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Customer);
            Customer customer = (Customer)Activator.CreateInstance(type,"Deniz",5250.13);
            customer.displayCustomer();
            Console.WriteLine("-----------------------------");

            var instance = Activator.CreateInstance(type, "Derya", 6547.57);
            Console.WriteLine(instance.GetType());
            instance.GetType().GetMethod("displayCustomer").Invoke(instance, null);
            Console.WriteLine("-----------------------------");


            var tip = typeof(Customer);
            var methods = tip.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine(item.Name);
                foreach (var methodparameterName in item.GetParameters())
                {
                    Console.WriteLine(methodparameterName.Name);
                }
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine(attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    class Customer
    {
        string _name;
        double _money;      
        public Customer(string ad,double para)
        {
            _name = ad;
            _money = para;
        }
        public void displayCustomer()
        {
            Console.WriteLine(_name + "  " + _money);
        }
        [Custom("PrivateAttribute")]
        public void funcwithparameters(int sayi1,int sayi2,string str) { }
    }

    class CustomAttribute : Attribute
    {
        public CustomAttribute(string name)
        {

        }
    }

}
