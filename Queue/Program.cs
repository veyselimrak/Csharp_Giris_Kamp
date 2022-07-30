using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueIslemleri();
            QueueIslemleri2();
            
        }

        private static void QueueIslemleri2()
        {
            var karakterKuyrugu = new Queue<char>();
            char[] sesliHarfler = new char[]
            {
                'a','e','ı','i',
                'u','ü','o','ö'
            };

            System.Console.WriteLine(sesliHarfler);

            foreach (var item in sesliHarfler)
            {

                System.Console.Write($" {item,5} Kuyruğa Eklensin mi: e/h");
                char kontrol = Convert.ToChar(Console.ReadLine());
                if (kontrol == 'e')
                {
                    karakterKuyrugu.Enqueue(item);
                    System.Console.WriteLine($" {item,5} Kuyruğa eklendi.");
                }
                System.Console.WriteLine("Eleman sayısı: " + karakterKuyrugu.Count());
            }

            Console.ReadKey();
        }

        private static void QueueIslemleri()
        {
            //Queue First In First Out İlk giren ilk çıkar.
            // Tanımlama
            var karakterKuyrugu = new Queue<char>();

            //Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('b');
            karakterKuyrugu.Enqueue('c');


            //Diziye Çevirme
            System.Console.WriteLine(karakterKuyrugu.ToArray());

            //Çıkarma
            System.Console.WriteLine($"Kuyruğun Başındaki Eleman:  {karakterKuyrugu.Peek()} ");
            System.Console.WriteLine($"{karakterKuyrugu.Dequeue()} eleman kıyruktan çıkartıldı.   ");
            System.Console.WriteLine("Kuyruktaki eleman sayısı:  " + karakterKuyrugu.Count());

            Console.ReadKey();
        }
    }
}