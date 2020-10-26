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
}
