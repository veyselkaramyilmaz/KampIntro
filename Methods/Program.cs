using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();

            product1.Id = 155454;
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya";

            Product product2 = new Product();

            product2.Id = 454545;
            product2.Adi = "Çilek";
            product2.Fiyati = 45;
            product2.Aciklama = "Çilek gibi Çilek";

            Product product3 = new Product();

            product3.Id = 54545;
            product3.Adi = "Muz";
            product3.Fiyati = 10;
            product3.Aciklama = "Anamur";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine( "Product Name = " + product.Adi );
                Console.WriteLine("Product Id = "  + product.Id );
                Console.WriteLine( "Product Price = " + product.Fiyati);
                Console.WriteLine("Product Explanation = " + product.Aciklama);
                Console.WriteLine("-------------------------------");
            }


            //encapsulation 

            Console.WriteLine("----------------Metodlar-------------------");

            SepetManager sepetmaneger = new SepetManager();
            sepetmaneger.Ekle(product1);
            sepetmaneger.Ekle(product2);
            sepetmaneger.Ekle(product3);
           
          

        }
    }
}
