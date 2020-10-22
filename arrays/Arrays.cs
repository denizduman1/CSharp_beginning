using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Arrays
    {
        static void Main()
        {
            string[] names = { "Deniz", "Derya", "Emine", "İbrahim" };
            int index = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0}-) {1}",index,name);
                index += 1;
            }
            for (int j = 0; j < 15; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            char[] character = new char[100];

            foreach (string item in names)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write("{0}-) {1} ", i , item[i]);
                }
                Console.WriteLine();
            }

            for (int j = 0; j < 15; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            int[,] matris = new int[4, 5];

            for (int i = 0; i < 4; i++)
            {   
                for (int j = 0; j < 5; j++)
                {
                    matris[i, j] = j;
                }
            }

            for (int i = 0; i <= matris.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matris.GetUpperBound(1); j++)
                {
                    Console.Write(matris[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < 15; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

        }
    }
}
