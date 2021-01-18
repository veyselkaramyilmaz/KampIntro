using System;

namespace classDeneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            car car1 = new car();
            car1.marka = "ford";
            car1.renk = " mavi";
            car1.tipi = "sedan";
            car1.fiyat = 1000;

            car car2 = new car();
            car2.marka = "hyundai";
            car2.renk = "sarı";
            car2.tipi = "suv";
            car2.fiyat = 50000;

            car car3 = new car();
            car3.marka = "opel";
            car3.renk = "beyaz";
            car3.tipi = "cSuv";
            car3.fiyat = 41000;

            car[] cars = new car[] { car1, car2, car3 };

            foreach (var car in cars)
            {
                Console.WriteLine(car.marka + ":" + car.renk + "/" + car.tipi + "/" + car.fiyat);

            }

            renk renk1 = new renk();

            renk1.adi = "mavi";
            renk1.sekli = "kare";
            renk1.numarası = 5;

            renk renk2 = new renk();
            renk2.adi = "kırmızı";
            renk2.sekli = "daire";
            renk2.numarası = 10;

            renk renk3 = new renk();
            renk3.adi = "turucu";
            renk3.sekli = "yamuk";
            renk3.numarası = 45;

            renk[] renkler = new renk[] { renk1, renk2, renk3 };

            foreach (var renk in renkler)
            {
                Console.WriteLine(renk.adi + ":" + renk.sekli + "/" + renk.numarası);
            }
          
            
            
            
            
            
            
            
            //Console.WriteLine("Hello World!");
        }
    }

    class car
    {
        public string marka{ get; set; }

        public string renk{ get; set; }
        public int fiyat{ get; set; }

        public string tipi{ get; set; }
    }

    class renk
    {
        public string adi{ get; set; }
        public int numarası{ get; set; }

        public string sekli{ get; set; }
    }
}
