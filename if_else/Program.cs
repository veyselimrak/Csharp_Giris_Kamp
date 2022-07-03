namespace bir
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEK Mİ ÇİFT Mİ

            TekCift();

            MutlakDeger();

            KarakterSorgulama();

        }

        private static void KarakterSorgulama()
        {
            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine($"{k} Rakamdır!. ");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine($"{k} küçük harftir. ");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine($"{k} büyük harftir. ");
            }
            else
            {
                Console.WriteLine("Bilinmeyen Karakter.");
            }
            Console.ReadKey();
        }

        private static void MutlakDeger()
        {
            Console.Write("bir sayı giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 0)
            {
                Console.WriteLine($"Sayının Mutlak Değeri: {n} ");
            }
            else
            {
                Console.WriteLine($"Sayının Mutlak Değeri: {-1 * n} ");
            }
        }

        private static int TekCift()
        {
            Console.Write("bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} sayısı çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} sayısı tek bir sayıdır.");
            }

            return sayi;
        }
    }
}