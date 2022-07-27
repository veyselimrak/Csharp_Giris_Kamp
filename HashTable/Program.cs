using System;
using System.Collections;

namespace hashTable;

class Program
{
    static void Main(string[] args)
        {
            //HashTable Tanımla 
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(34,"İstanbul");
            sehirler.Add(6,"Ankara");
            sehirler.Add(1,"Adana");
            sehirler.Add(56,"Siirt");

            //Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                System.Console.WriteLine($"  Keys: {item.Key,-5}  Values: {item.Value,-15} ");
            }

            //Anahtarları Alma
            var anahtarlar = sehirler.Keys;

            System.Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                System.Console.WriteLine(item);
            }

            var degerler = sehirler.Values;

            System.Console.WriteLine("\nDeğerler");
            foreach (var item in degerler)
            {
                System.Console.WriteLine(item);
            }


            //Elemana Erişim
            System.Console.WriteLine("\nElemana Erişim");
            System.Console.WriteLine(sehirler[34]);

            //Eleman Silme 
            System.Console.WriteLine("\nEleman Silme");
            sehirler.Remove(6);

            foreach (DictionaryEntry item in sehirler)
            {
                System.Console.WriteLine($"  Keys: {item.Key,-5}  Values: {item.Value,-15} ");
            }

            Console.ReadKey();

            

        }
}