using System;

namespace classDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            paper Paper1 = new paper();

            Paper1.PaperColour = "red";
            Paper1.PaperName = "kırmızı";
            Paper1.PaperPageNumber = 35;
            Paper1.Tur = "spor";

            paper Paper2 = new paper();

            Paper2.PaperColour = "blue";
            Paper2.PaperName = "mavi";
            Paper2.PaperPageNumber = 45;
            Paper2.Tur = "magazin";

            paper Paper3 = new paper();

            Paper3.PaperColour = "orange";
            Paper3.PaperName = "turuncu";
            Paper3.PaperPageNumber = 48;
            Paper3.Tur = "siyaset";


            paper[] papers = new paper[] { Paper1, Paper2, Paper3 };

            foreach (var paper in papers)
            {
                Console.WriteLine(paper.PaperColour + ":" + paper.PaperName + "/" + paper.PaperPageNumber
                  + "/"  + paper.Tur);
            }




            //Console.WriteLine("Hello World!");
        }
    }

    class paper

    {
        public string PaperName{ get; set; }
        public string Tur{ get; set; }

        public int PaperPageNumber{ get; set; }
        public string PaperColour{ get; set; }
    }


}
