using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSetIslemler();
            Console.ReadKey();

        }

        private static void SortedSetIslemler()
        {
            //SotedSet Tanımlama
            var list = new SortedSet<string>();

            //Ekleme - Silme 
            list.Add("Veysel");
            if (list.Add("Veysel"))
            {
                System.Console.WriteLine("Başarıyla Eklendi.");
            }
            else
            {
                System.Console.WriteLine("Ekleme işlemi başarısız.");
            }
            list.Add("Fatih");
            list.Add("Mehmet");
            list.Add("Emre");


            list.Remove("Veysel");
            //Belirtilen koşulları bulunduran değerleri siler.
            list.RemoveWhere(deger => deger.Contains("e"));
            list.RemoveWhere(deger => deger.StartsWith("E"));


            //Liste üzerinde Dolaşma
            System.Console.WriteLine("\nİsimler Listesi");
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}