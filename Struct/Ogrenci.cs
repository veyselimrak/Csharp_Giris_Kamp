namespace Struct
{
    //Tanımlama
    public struct Ogrenci
    {
        //Yapıllandırıcı Metot - Constructor 
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet=true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } //Property - Özellik
        public string Adi { get; set; }
        public string Soyadi { get; set; } 
        public bool Cinsiyet { get; set; }

        public override string ToString()
        {
            return $" {Numara,-5} " +
            $"{Adi,-10}" +
            $"{Soyadi,-8}" +  
            string.Format("{0,-5}",Cinsiyet == true ? "Bay" : "Bayan");
        }
    }

}