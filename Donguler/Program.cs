using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // array = dizi


            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya başlandıç için"
            ,"java","Python","C#","C++"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach ( string kurs in kurslar) // dizileri daha kolay dolaşmaya yarar
            {
                Console.WriteLine(kurs);
            }

           

            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
