using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            DictionaryTemelleri();
            Console.ReadKey();
        }

        private static void DictionaryTemelleri()
        {
            //Tanımlama
            var sehirler = new Dictionary<int, string>()
            {
                {322,"Malatya"},
                {212,"İstanbul"},
                {146,"İzmir"}
            };
            //Ekleme - Çıkarma
            sehirler.Add(325, "Ankara");
            sehirler.Add(326, "Elazığ");
            sehirler.Remove(322);

            //Conatins
            if (!sehirler.ContainsKey(225))
            {
                System.Console.WriteLine("225 posta kodu bulunmamaktadır.");
                sehirler.Add(225, "Siirt");
                System.Console.WriteLine("Posta Kodu Eklendi");
            }
            if (!sehirler.ContainsValue("Aydın"))
            {
                System.Console.WriteLine("Listede Aydın bulunmamaktadır.");
                sehirler.Add(329, "Aydın");
                System.Console.WriteLine("Aydın listeye eklendi.");
            }
            foreach (var sehir in sehirler)
            {
                System.Console.WriteLine(sehir);
            }
            Console.ReadKey();
        }
    }
}