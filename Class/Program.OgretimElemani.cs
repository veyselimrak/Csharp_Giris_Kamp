namespace Class
{
    partial class Program
    {
        public class OgretimElemani
        {
            public int SicilNo { get; set; }
            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public bool Cinsiyet { get; set; } 

            public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
            {
                SicilNo = sicilNo;
                Adi = adi;
                Soyadi = soyadi;
                Cinsiyet = cinsiyet;
            }
            public override string ToString()
            {
                return $"{SicilNo,-5} " +
                $" {Adi,-10}  " + 
                $" {Soyadi,-10}" + 
                string.Format( " {0,-8} ", Cinsiyet == true ? "Bay" : "Bayan" );
            }

        }
    }
}
