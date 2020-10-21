using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuetypes
{
    class Program
    {
        enum MyEnum
        {
            Working, NotWorking, Faulty, Stopped
        }
        static void Main(string[] args)
        {

            string enumvalue = "";
            int enumindex;
            enumindex = (int)MyEnum.Working;
            enumvalue = MyEnum.Working.ToString();
            Console.WriteLine(MyEnum.Working);
            Console.WriteLine("Enum Value = " + enumvalue);
            Console.WriteLine("Enum Index Value = " + enumindex);
            int value_int = 1234567891;
            short value_short = 12345;
            long value_long = 1234567891234567891;
            byte value_byte = 255;
            bool value_bool = false;
            char value_char = 'c';
            string value_string = "str";
            double value_double = 123456789123456789.1234567891234567891234567891;
            decimal value_decimal = 123456789.123456789m;
            var value_val = "maybe string maybe int";

            Console.WriteLine("int = {0}  short = {1}  long = {2}", value_int, value_short, value_long);
            Console.WriteLine("byte = {0}", value_byte);
            Console.WriteLine("bool = {0}", value_bool);
            Console.WriteLine("char = {0} string = {1}", value_char, value_string);
            Console.WriteLine("double = {0}  decimal = {1} ", value_double, value_decimal);
            Console.WriteLine("variable = {0}", value_val);

        }
    }
}


