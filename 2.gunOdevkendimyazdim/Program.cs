using System;

namespace _2.gunOdevkendimyazdim
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();
            laptop1.nameLaptop = "acer";
            laptop1.islemci = "i5";
            laptop1.disk ="500gb";

            Laptop laptop2 = new Laptop();
            laptop2.nameLaptop = "asus";
            laptop2.islemci = "i3";
            laptop2.disk = "200gb";

            Laptop[] laptoplar = new Laptop[] { laptop1, laptop2 };

            foreach (var laptop in laptoplar)
            {
                Console.WriteLine(laptop.nameLaptop + ":" + laptop.islemci + "/" + laptop.disk);
            }


            //Console.WriteLine("Hello World!");
        }
    }


    class Laptop 
    {
        public string nameLaptop { get; set; }
        public string islemci { get; set; }
        public string disk{ get; set; }




    }
}
