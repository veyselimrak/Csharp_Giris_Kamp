using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
            {
                double toplam = seriToplami(5.5, 15.28, 32.19);
                System.Console.WriteLine($" {toplam,5:0.##}  ");

                Console.ReadKey();

            }
        
        private static double seriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double sayi in seri)
            {
                toplam += sayi;
            }
            return toplam;
        }

    }
}