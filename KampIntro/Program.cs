using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety
            //do not repeat yourself
            //değer tutucu, alias(kategoriEtiketi)
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            //ifden sonra iki kere taba bas
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else
            {
                Console.WriteLine("degişmedi butonu");

            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            
            else
            {
                Console.WriteLine("Giris Yap Butonu");
            }
            

            Console.WriteLine(kategoriEtiketi);


        }
    }
}
