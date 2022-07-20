namespace dizi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler
            DiziOrnegi();

            DiziOrnegi1();

            ÇokBoyutluDiziOrnegi();

            Console.ReadKey();

        }

        private static void ÇokBoyutluDiziOrnegi()
        {
            double[,] matris = new double[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            double toplam = 0;
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = 0;
                    }
                    if (matris[i, j] % 2 == 0)
                    {
                        matris[i, j] = -1;
                    }
                    System.Console.Write($" {matris[i, j],5}");

                    toplam += matris[i, j];

                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine($"Elemanlar Toplamı: {toplam}");
        }

        private static void DiziOrnegi1()
        {
            Console.Write("Dizi Boyutunu Giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];


            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);


            foreach (var item in sayilar)
            {
                Console.WriteLine(item);
            }
        }

        private static void DiziOrnegi()
        {
            int[] numaralar = { 3, 5, 7 };

            for (int i = 0; i < numaralar.Length; i++)
            {
                System.Console.WriteLine($"Numaralar[{i}] = {numaralar[i]}");
            }
        }
    }
}