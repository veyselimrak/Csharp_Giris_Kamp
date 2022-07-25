using System;
using System.Collections.Generic;


namespace Struct
{
    public class Program
    {
        static void Main(string[] args)
            {
                var OgrencilerListesi = new List<Ogrenci>()
                {
                    new Ogrenci(125,"Fatma","Yalçın",false),
                    new Ogrenci(126,"Selim","Aydın"),
                    new Ogrenci(127,"Ahmet","Şaşkın",true)
                };

                OgrencilerListesi.ForEach(o => System.Console.WriteLine(o));

            }
    }
}