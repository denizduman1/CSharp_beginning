using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class Program
    {
        public delegate void MyDelegateFunc();
        public delegate void MyDelegateFunc2(string a);
        public delegate int MyDelegateFunc3(int num1,int num2);

        static void Main(string[] args)
        {
            Example example = new Example();
            MyDelegateFunc myDelegate = example.sayHello;
            myDelegate += example.beCareful;
            myDelegate();
            MyDelegateFunc2 myDelegate2 = example.sayHello2;
            myDelegate2("Deniz");
            Mathematic mathe = new Mathematic();
            MyDelegateFunc3 myDelegate3 = mathe.topla;
            myDelegate3 += mathe.carp;
            Console.WriteLine(myDelegate3(1, 3));
            Console.WriteLine("******");
            Repeat(() => {
                example.beCareful();
                example.sayHello();
                example.sayHello2("EMİNE İBRAHİM");
            });
            Func<int> getRandomNum = delegate ()
             {
                 Random rnd = new Random();
                 return rnd.Next(1,10);
             };

            Console.WriteLine(getRandomNum());
            Console.ReadLine();
        }
        public static void Repeat(Action action)
        {
            Console.WriteLine("-----------------------");
            action.Invoke();
        }
    }

    class Mathematic
    {
        public int topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }

    class Example
    {
        public void sayHello2(string ad)
        {
            Console.WriteLine("Hello"+" "+ad);
        }
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
        public void beCareful()
        {
            Console.WriteLine("Be careful please..");
        }
    }
}