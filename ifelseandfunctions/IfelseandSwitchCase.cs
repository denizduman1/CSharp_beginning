using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseandfunctions
{
    enum Colors
    {
        Red,Blue,Green
    }

    class IfelseandSwitchCase
    {
        static void Main()
        {
            string str = Console.ReadLine();
            if (str == "exit")
            {
                Console.WriteLine("application exit..");
            }
            else
            {
                Console.WriteLine("Continue");
            }

            var num = Console.ReadLine();
            string num_str = Convert.ToString(num);
            Console.WriteLine("convert to string: " + num_str);
            if (num_str == "num_str")
            {
                Console.WriteLine("correct");
            }
            //string number = "10";
            //int num = Convert.ToInt32(number);
            //Console.WriteLine(num + 10);

            short choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(Colors.Red);
                    break;
                case 2:
                    Console.WriteLine(Colors.Blue);
                    break;
                case 3:
                    Console.WriteLine(Colors.Green);
                    break;
                default:
                    Console.WriteLine("hata");
                    break;
            }
        }
    }
}
