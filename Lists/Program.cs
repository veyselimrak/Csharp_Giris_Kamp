using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
            {
                //Tanımlama
                var sayilar = new List<int>();

                //Ekleme
                sayilar.Add(25);
                sayilar.Add(35);
                sayilar.Add(45);
                sayilar.Insert(3,100);

                //Listeye Dizi Ekleme
                int[] numbers = new int[]{10,20,30};

                foreach (var number in numbers)
                {
                    sayilar.Add(number);
                }
                
                //Dolaşma
                foreach (var sayi in sayilar)
                {
                    System.Console.Write($" {sayi,-5}");
                }


                //Çıkarma

                sayilar.Remove(35);
                sayilar.RemoveAt(1);
                sayilar.RemoveRange(1,2);


                foreach (var sayi in sayilar)
                {
                    System.Console.WriteLine();
                    System.Console.Write($" {sayi,-5}");
                }

                Console.ReadKey();

            }
    }
}
