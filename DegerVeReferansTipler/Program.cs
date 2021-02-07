using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            // sayi1 30 verir

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar1 = sayilar2;
            sayilar2[0] = 999;



            //değer tip olanlar "stack" bölümünde gerçekleşir.değeri kopyalar o satırdan sonraki ilgilendirmez onu.
            //"heap" bölümünde tutulduğunda hep atadığın değişkene bağlı kalır.
            // array,class,interface=referance tip olarak kullanılır."heap"
            //int, decimal, float,bool= değer tip olarak kullanılır."stack"
            // yazılımda sürdürlebilirlik çok önemlidir.very important


        }
    }
}
