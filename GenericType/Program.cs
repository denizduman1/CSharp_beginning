using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main()
        {
            GenericType genericType = new GenericType();
            List<string> genericList = genericType.GetAll<string>("Ankara", "İstanbul", "Giresun", "Ordu");
            List<int> genericList2 = genericType.GetAll<int>(1,2,3,4);

            foreach (var item in genericList)
            {
                Console.WriteLine(item);
            }

            foreach (var item in genericList2)
            {
                Console.WriteLine(item);
            }
       
        }
    }
    class GenericType
    {
        public List<T> GetAll<T>(params T[] items) 
        {
           return new List<T>(items);
        }
    }

    interface ICustomer<T> where T:class,new()
    {
        List<T> GetCustomer();
        void AddCustomer(T entity);
        void UpdateCustomer(T entity);
        void DeleteCustomer(T entity);
    }

    class Customer
    {

    }

    class CustomerDAL : ICustomer<Customer>
    {
        public void AddCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetCustomer()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer entity)
        {
            throw new NotImplementedException();
        }
    }

}
