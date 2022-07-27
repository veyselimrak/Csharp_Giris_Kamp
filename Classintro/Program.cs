using System;

namespace Classintro
{
     class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmeni { get; set; }

        public int IzlenmeOrani { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Veysel";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Veysel İmrak";
            kurs2.IzlenmeOrani = 100;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.Egitmeni = "Muhyettin İmrak";
            kurs3.IzlenmeOrani = 200;



            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            Console.WriteLine(kurs1.Egitmeni + " " + kurs3.IzlenmeOrani);

            foreach (var Kurs in kurslar)
            {
                Console.WriteLine(Kurs.KursAdi + " " + Kurs.Egitmeni + " " + Kurs.IzlenmeOrani);
            }



        }
    }
}
