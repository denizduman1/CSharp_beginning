using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    class Program
    {
        static void Main(string[] args)
        {
            Product gsm = new Product(50);
            Product pc = new Product(50);
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 5; i++)
            {
                gsm.Sell(10);
                pc.Sell(10);
                Console.ReadLine();

            }
            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm Tükenmek üzere");
        }
    }
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }
        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("{1} Stock amount: {0}", Stock,ProductName);
        }
        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock
        {
            get { return _stock; }
            set
            {
                _stock = value;
                if (value <= 15 && StockControlEvent!=null)
                {
                    StockControlEvent();
                } 
            } 
        }
    }
}
