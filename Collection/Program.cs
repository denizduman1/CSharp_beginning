using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Customer
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");
            //Console.WriteLine(dictionary["table"]);
            //Console.WriteLine(dictionary["glass"]);

            foreach (var item in dictionary)
            {
                Console.Write(item.Key + " = ");
                Console.WriteLine(item.Value);
                Console.WriteLine("----");

            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));


            Console.ReadLine();
            
            //string[] cities = new string[2] { "Ank", "İst" }; //Yeni eleman ekleyemiyoruz.
            //cities = new string[3];
            //Console.WriteLine(cities[0]); //boş

            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Adana");

            //for (int i = 0; i < cities.Count; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //cities.Add("İstanbul");
            //cities.Add(1);

            //for (int i = 2; i < cities.Count; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //List<string> cities = new List<string>();
            //cities.Add("Ankara");
            //cities.Add("string item gerekli");
            //foreach (var item in cities)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { ID = 1, Number = 556, Name = "Deniz" });

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.ID + item.Name + item.Number);
            //}

            //customers.Add(
            //    new Customer
            //    {
            //        ID = 2,
            //        Number = 345,
            //        Name = "Derya"
            //    }
            //    );

            //var customer = new Customer
            //{
            //    ID = 3,
            //    Name = "Emine",
            //    Number = 123
            //};

            //customers.Add(customer);
            //customers.Add(customer);
            //Console.WriteLine("ilkten sıra = " + customers.IndexOf(customer));

            //Console.WriteLine("sondan sıra = "+customers.LastIndexOf(customer)); //aramaya sondan başlayacak.ilkiyle aynı sonucu verecek daha çabuk biter.

            //customers.Insert(1, new Customer { ID= 28,Name="İbrahim",Number=789 }); //indexe göre ekler.

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //customers.RemoveAt(customers.Count-1); //indexe göre çıkartır.
            //customers.RemoveAll(c => c.Name == "Emine"); //predicate aranan özellikteni çıkartır.

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.Name);
            //}



            //Console.WriteLine(cities.Contains("Ankara"));

            //Console.WriteLine(customers.Contains(new Customer{ID=2,Number=345,Name="Derya"}));
            //Console.WriteLine(customers.Contains(customers[1]));


            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item.ID + item.Name + item.Number);
            //}
            //customers.Clear();
            //Console.WriteLine(customers.Count);

        }
    }
}
