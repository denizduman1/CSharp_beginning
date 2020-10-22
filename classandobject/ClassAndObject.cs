using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandobject
{
    class Student
    {
        public int ID { get; set; }

        private string name;
        private int number;

        public string Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value.ToUpper();
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                if (value < 0)
                {
                    number = 0;
                }
                else
                {
                    number = value;
                }
            }
        }
    }

    interface IDataBases
    {
        public void Add();
        void Delete(); //interface class have only public methods.
        void Update();
        void Read();
    }

    class Oracle : IDataBases
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Read()
        {
            Console.WriteLine("Oracle read");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class SqlDataBase : IDataBases
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void Read()
        {
            Console.WriteLine("Sql read");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

        public void Sql()
        {
            Console.WriteLine("..");
        }

    }

    class Customer
    {
        public void Add(IDataBases dataBases)
        {
            dataBases.Add();
            Console.WriteLine("Customer is added");
        }
    }

    interface IBook
    {
        string kapakAdi { get; set; }
        int sayfaSayisi { get; set; }
        string basimYeri { get; set; }
        public void Goster();
    }

    interface ICizim
    {
        void ResimCiz();
        void RenkSec();
    }

    interface ISoru
    {
        public int SoruAdet { get; set; }
        public string CevapAnahtari { get; set; }
        public string DersAdi { get; set; }
    }

    class BoyamaKitabi : ICizim, IBook
    {
        string KAPAKADI;
        int SAYFASAYISI;
        string BASIMYERI;

        public BoyamaKitabi(string ad, int sayi, string yer)
        {
            KAPAKADI = ad;
            this.SAYFASAYISI = sayi;
            this.basimYeri = yer;
        }
        public string kapakAdi { get { return KAPAKADI; } set { KAPAKADI = value; } }
        public int sayfaSayisi { get { return SAYFASAYISI; } set { SAYFASAYISI = value; } }
        public string basimYeri { get { return BASIMYERI; } set { BASIMYERI = value; } }

        public void Goster()
        {
            Console.WriteLine(this.kapakAdi+ this.sayfaSayisi+ this.basimYeri);
        }

        public void RenkSec()
        {
        }

        public void ResimCiz()
        {
        }
    }

    class TestKitabi : IBook, ISoru
    {
        string KAPAKADI;
        int SAYFASAYISI;
        string BASIMYERI;
        public string kapakAdi { get { return KAPAKADI; } set { KAPAKADI = value; } }
        public int sayfaSayisi { get { return SAYFASAYISI; } set { SAYFASAYISI = value; } }
        public string basimYeri { get { return BASIMYERI; } set { BASIMYERI = value; } }

        public TestKitabi(string ad,int sayi,string yer)
        {
            KAPAKADI = ad;
            this.SAYFASAYISI = sayi;
            this.basimYeri = yer;
        }
        public void Goster()
        {
            Console.WriteLine(this.kapakAdi+ this.sayfaSayisi+ this.basimYeri);
        }

        public int SoruAdet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CevapAnahtari { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DersAdi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    class KitapAl
    {
        public KitapAl(IBook book)
        {
            Console.WriteLine(book.kapakAdi + " " + book.sayfaSayisi + " " + book.basimYeri);
        }
    }

    class ClassAndObject
    {
        static void Main()
        {
            //IBook[] books = new IBook[2]
            //{
            //  new TestKitabi("test",150,"Ankara"),
            //  new BoyamaKitabi("çizim",10,"İstanbul")
            //};

            //foreach (var item in books)
            //{
            //    item.Goster();
            //}

            //Student student = new Student
            //{
            //    Name = "deniz",
            //    ID = 1,
            //    Number = -5
            //};
            //Console.WriteLine("Student ID = "+ student.ID);
            //Console.WriteLine("Student Name = "+student.Name);
            //Console.WriteLine("Student Number = "+student.Number);

            //IDataBases oracleDatabase = new Oracle();
            //IDataBases sqlDatabase = new SqlDataBase();

            //Console.Write("ADD SQL = ");
            //sqlDatabase.Add();
            //Console.Write("ADD ORACLE = ");
            //oracleDatabase.Add();

            //Customer customer = new Customer();
            //customer.Add(new Oracle());
            //Console.WriteLine("*******");
            //customer.Add(new SqlDataBase());

            //IDataBases[] databases = new IDataBases[2]
            //{
            //    new SqlDataBase(),
            //    new Oracle()
            //};

            //foreach (var item in databases)
            //{
            //    item.Add();
            //}
            //databases[0].Add();

        }
    }
}
