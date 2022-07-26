namespace Class
{
    partial class Program
    {
        static void Main(string[] args)
            {
            //Classların referans tipli olduğunu gösteren bir örnek.
                //Tanımla - Atama

                List<OgretimElemani> ogrElmListesi = new List<OgretimElemani>()
                {
                    new OgretimElemani(100,"Ömer","Ay",true),
                    new OgretimElemani(101,"Ali","Yıldız",true),
                    new OgretimElemani(102,"Esra","Alemdar",false),
                    new OgretimElemani(103,"Ahmet","Baş",true),
                    new OgretimElemani(104,"Mısra","Akkurt",false)
                };
                System.Console.WriteLine("Liste 1 ");
                ogrElmListesi.ForEach(ogrElm => System.Console.WriteLine(ogrElm));

                List<OgretimElemani> ogrElmListesi2 = ogrElmListesi;
                System.Console.WriteLine("Liste 2 ");
                ogrElmListesi.ForEach(ogrElm2 => System.Console.WriteLine(ogrElm2));

                Console.ReadKey();

                ogrElmListesi2.Add(new OgretimElemani(105,"Alpay","Aslan",true));
                ogrElmListesi.RemoveAt(0);

                System.Console.WriteLine("Değişiklikkler Yapıldı.");

                System.Console.WriteLine("Liste 1 ");
                ogrElmListesi.ForEach(ogrElm => System.Console.WriteLine(ogrElm));

                System.Console.WriteLine("Liste 2 ");
                ogrElmListesi.ForEach(ogrElm2 => System.Console.WriteLine(ogrElm2));




                Console.ReadKey();

            }
    }
}
