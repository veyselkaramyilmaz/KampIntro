using System;

namespace _2.gunKodlamaioOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.ProductName = "ball";
            product1.ProductPrice = 50;
            product1.ProductNumberOfSale = 100;


            Product product2 = new Product();

            product2.ProductName = "book";
            product2.ProductPrice = 121;
            product2.ProductNumberOfSale = 10;


            Product[] products = new Product[] {product1, product2 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ProductName:" + products[i].ProductName);
                Console.WriteLine("ProductPrice:" + products[i].ProductPrice);
                Console.WriteLine("ProductNumberOfSale:" + products[i].ProductNumberOfSale);
            }

            foreach (var product in products) 
            {
                Console.WriteLine(product.ProductName + ":" + product.ProductNumberOfSale + "/" +  product.ProductPrice);
            }

            int x = 0;
            while (x<products.Length)
            {
                Console.WriteLine(products[x].ProductName + ":" +  products[x].ProductNumberOfSale + "/" +  products[x].ProductPrice);
                
            x++;
            }
            


            //Console.WriteLine("Hello World!");
        }
    }

    class Product
    {
        public string ProductName{ get; set; }
        public int ProductPrice{ get; set; }
        
        public  int ProductNumberOfSale{ get; set; }


    }

}
