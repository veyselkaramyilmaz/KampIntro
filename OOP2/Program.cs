using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual1 = new Individual();
            individual1.Name = "Engin";
            individual1.Name = "Demiroğ";
            individual1.CustumerNumber = "45454";

            // kodlama io:
            Coorporate coorporate1 = new Coorporate();
            coorporate1.CompanyName = "KodlamaIo";
            coorporate1.CustumerNumber = "54545";
            coorporate1.TaxNumber = "45454";


            //Gerçek Müşteri- Tüzel Müşteri birbirinin yerine kullanılmaz
            //SOLID "L" söyler.


            Customer customer3 = new Coorporate();
            Customer customer4 = new Individual();






        }
    }
}
