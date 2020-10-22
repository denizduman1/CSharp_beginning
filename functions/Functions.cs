using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Functions
    {

        void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        static double Division(int sayi1 , double sayi2)
        {
            return (sayi1 / sayi2);
        }

        static void ChangesValue(ref string str)
        {
            str = "Aysima";
        }

        static void Manyparameters(int num1, int num2, params int [] numbers )
        {
            int sum = num1 + num2;
            foreach(int item in numbers)
            {
                sum = sum + item;
            }
            Console.WriteLine("Sum = {0} " , sum);
        }


        static void Main()
        {
            SayHello(); //static
            Functions func = new Functions();
            func.SayHi(); //no static
            Console.WriteLine(Division(10, 2));
            Console.WriteLine(Division(11, 3));
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            string ad = "Deniz";
            ChangesValue(ref ad);
            Console.WriteLine("Ad = {0}", ad);
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Manyparameters(1, 2,3,4,5);

        }
    }
}
