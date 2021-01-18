using System;

namespace classDeneme3
{
    class Program
    {
        static void Main(string[] args)
        {

            kelime kelime1 = new kelime();

            kelime1.Yazilisi = "naber";
            kelime1.ilkHarf = "n";
            kelime1.harfSayisi = 5;

            kelime kelime2 = new kelime();

            kelime2.Yazilisi = "merhaba";
            kelime2.ilkHarf = "m";
            kelime2.harfSayisi = 7;

            kelime[] kelimeler = new kelime[] {kelime1, kelime2 };


            foreach (var kelime in kelimeler )
            {
                Console.WriteLine(kelime.Yazilisi + ":" + "ilk harfi= " + " " + kelime.ilkHarf + " " + "harf sayısı=" + " " + kelime.harfSayisi);
            }
            
            //Console.WriteLine("Hello World!");
        }
    }


    class kelime
    {
        public int harfSayisi{ get; set; }
        public string ilkHarf{ get; set; }
        public string Yazilisi{ get; set; }
    }

}
