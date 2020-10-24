using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errormanagement
{
    class RecordNotFoundException:Exception
    {
        public RecordNotFoundException(string msg):base(msg)
        {
            Console.WriteLine("hata");
        }
    }

    class ErrorManagement
    {
        private static void Find()
        {
            List<string> students = new List<string> { "a", "b", "c" };
            if (!students.Contains("d"))
            {
                throw new RecordNotFoundException("Record not found");
            }
            else
            {
                Console.WriteLine("record found");
            }
        }
            
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main()
        {

            HandleException(() => {
                Find();
            }); 
 
            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFoundException exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //string[] students = new string[3] {"Deniz","Derya","Aysima"};
            //try
            //{
            //    students[3] = "Emine";
            //}
            //catch (IndexOutOfRangeException exception) //girerse diğer catche bakmadan 
            //{
            //    Console.WriteLine(exception.Message);
            //}
            //catch(Exception exception)
            //{
            //    Console.WriteLine("dizi boyutu geçildi." + exception.Message);
            //}
            Console.ReadLine();
        }
    }
}