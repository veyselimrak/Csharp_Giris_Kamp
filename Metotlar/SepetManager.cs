using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming covention
        //syntax

        
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama,double fiyat, int stokAdeti)

        {
            Console.WriteLine("Tebrikler. Sepete Eklendi :" + urunAdi);
        }
    }
}
