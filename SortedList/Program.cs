using System;   
using System.Collections;

namespace sortedList;

class Program
{
    static void Main(string[] args)
    {
        //Tanımlama
        var list = new SortedList()
        {
            {1,"Bir"},
            {9,"Dokuz"},
            {6,"Altı"},
            {4,"Dört"},
            {8,"Sekiz"}
        };
        //Dolaşma
        foreach (DictionaryEntry item in list)
        {
            System.Console.WriteLine($" {item.Key} - {item.Value}  ");
        }

        System.Console.WriteLine("Listenin Kapasitesi       :  {0} ",list.Capacity);
        System.Console.WriteLine("Listenin Eleman Sayısı    :  {0} ",list.Count);
        list.TrimToSize();
        System.Console.WriteLine("Listenin Yeni Kapasitesi  :  {0} ",list.Capacity);

        //Listeden Ekleme, Güncelleme, Key - Value Getirme
        list.Add(7,"Yedi");
        list.Remove(4);
        if (list.ContainsKey(6))
        {
            list[6] = "Six";
        }

        foreach (DictionaryEntry item in list)
        {
            System.Console.WriteLine($" {item.Key} - {item.Value}  ");
        }

        System.Console.WriteLine(list.GetByIndex(3));

        System.Console.WriteLine(list.GetKey(4));

        System.Console.WriteLine(list.GetByIndex(list.Count - 1));

        Console.ReadKey();

    }

}