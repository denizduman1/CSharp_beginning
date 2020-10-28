using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Add();
        }
    }
    class Customer { 
        [Obsolete("Don't use Add, instead use Add_New Method")]
        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Add_New()
        {
        }
    }
}