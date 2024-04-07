using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;


                DateTime d1 = new DateTime(2018, 11 ,25);
                DateTime d2 = new DateTime(2018, 11, 25, 20, 45, 3);
                DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);
                DateTime d4 = DateTime.Now;
                DateTime d5 = DateTime.Today;
                DateTime d6 = DateTime.UtcNow;
                DateTime d7 = DateTime.Parse("2020-12-04");
                DateTime d8 = DateTime.Parse("2020-12-04 13:05:56");
                DateTime d9 = DateTime.Parse("04/12/2020");
                DateTime d10 = DateTime.Parse("04/12/2020 13:05:58");
                DateTime d11 = DateTime.ParseExact("2020-12-04","yyyy-MM-dd", CI);
                DateTime d12 = DateTime.ParseExact("04/12/2020 13:05:58", "dd-MM-yyyy", CI);

                Console.WriteLine(d1.Ticks);
                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
                Console.WriteLine(d4);
                Console.WriteLine(d5);
                Console.WriteLine(d6);
                Console.WriteLine(d7);
                Console.WriteLine(d8);
                Console.WriteLine(d9);
                Console.WriteLine(d10);
                Console.WriteLine(d11);
                Console.WriteLine(d12);
            }
        }
    }
}