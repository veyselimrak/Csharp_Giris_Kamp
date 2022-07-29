using System;
using System.Collections.Generic;


namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackIslemler();
            Console.ReadKey();
            StackIslemler2();
            Console.ReadKey();
        }

        private static void StackIslemler2()
        {
            var karakteryigini = new Stack<char>();

            for (int i = 65; i < 91; i++)
            {
                karakteryigini.Push((char)i);
                System.Console.WriteLine(karakteryigini.Peek() + " yığına eklendi. ");
            }
            System.Console.WriteLine(" Çıkartma İşleminne geçmek için bir tuşa basınız.");
            Console.ReadKey();

            while (karakteryigini.Count > 0)
            {
                System.Console.WriteLine(karakteryigini.Pop() + " yığından çıkarıldı.");
                System.Console.WriteLine("Kalan Eleman Sayısı: " + karakteryigini.Count);
            }
        }
        
        private static void StackIslemler()
        {
            //Tanımlama
            var karakteryigini = new Stack<char>();

            //Ekleme
            karakteryigini.Push('A');
            System.Console.WriteLine(karakteryigini.Peek());

            karakteryigini.Push('B');
            System.Console.WriteLine(karakteryigini.Peek());

            karakteryigini.Push('C');
            System.Console.WriteLine(karakteryigini.Peek());

            System.Console.WriteLine(karakteryigini.Count);

            //Çıkarma   
            System.Console.WriteLine($"{karakteryigini.Pop()}  yığından çıkarıldı. ");
            System.Console.WriteLine($"{karakteryigini.Pop()}  yığından çıkarıldı. ");
            System.Console.WriteLine($"{karakteryigini.Pop()}  yığından çıkarıldı. ");
        }
    }
}
