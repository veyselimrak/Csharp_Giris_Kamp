using System;

namespace Comparable
{
    
    public class Sehir : IComparable<Sehir>
    {
        public int plakaNO { get; set; }
        public string SehirAdi { get; set; }

        public Sehir(int plakaNO, string sehirAdi)
        {
            this.plakaNO = plakaNO;
            SehirAdi = sehirAdi;
        }
        public override string ToString()
        {
            return $"{plakaNO,-5}   {SehirAdi,-15}";
        }

        public int CompareTo(Sehir other)
        {
            if (this.plakaNO < other.plakaNO)
            {
                return -1;
            }
            else if (this.plakaNO == other.plakaNO)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>(){5, 25, 14, 17, 28, 55, 11};
            sayilar.Sort();
            sayilar.ForEach(s => System.Console.WriteLine(s));

            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir(34,"İstanbul"),
                new Sehir(56,"Siirt"),
                new Sehir(44,"Malatya"),
                new Sehir(55,"Samsun")
            };

            sehirler.Sort();

            sehirler.ForEach(s => System.Console.WriteLine(s));
            
            Console.ReadKey();  
        }
    }
}