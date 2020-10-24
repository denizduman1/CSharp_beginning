using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueandreferencetypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities = new string []{ "Ankara", "Adana", "Afyon" };
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };
            cities2 = cities;
            for (int i = 0; i < cities2.Length; i++)
            {
                Console.WriteLine(cities2[i]);
            }

            DataTable dataTable = new DataTable(); //anlamsız olur.
            DataTable dataTable1 = new DataTable();
            dataTable = dataTable1;


        }
    }
}
