namespace SortedSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedSet Küme Uygulaması

            var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var B = new SortedSet<int>() { 1, 2, 5, 6 };

            System.Console.WriteLine("A Kümesi");
            foreach (int sayi in A)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();

            System.Console.WriteLine("B Kümesi");
            foreach (int sayi in B)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();

            //Kümede Temel İşlemler
            UnionWithIslem(A, B);
            IntersectWithIslem(A, B);
            ExceptWithIslem(A, B);
            SymmetricExceptWithIslem(A, B);

        }

        private static void SymmetricExceptWithIslem(SortedSet<int> A, SortedSet<int> B)
        {
            //SymmetricExceptWith - Sadece A ve B kümelerinde olan elemanlar alınır.
            A.SymmetricExceptWith(B);


            // Birleşim sonucunda elemanlar A kümesine eklenir.

            System.Console.WriteLine("Sadece A Kümesi");
            foreach (int sayi in A)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Oluşan Eleman Sayısı: {A.Count}");
        }

        private static void ExceptWithIslem(SortedSet<int> A, SortedSet<int> B)
        {
            //ExceptWithx -Sadece A kümesine ya ait olan elemanlar
            A.ExceptWith(B);

            // Birleşim sonucunda elemanlar A kümesine eklenir.

            System.Console.WriteLine("Sadece A Kümesi");
            foreach (int sayi in A)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Oluşan Eleman Sayısı: {A.Count}");
        }

        private static void IntersectWithIslem(SortedSet<int> A, SortedSet<int> B)
        {
            // //IntersectWith - Kesişim
            A.IntersectWith(B);

            // Birleşim sonucunda elemanlar A kümesine eklenir.

            System.Console.WriteLine("A ve B Kümesi Kesişimi");
            foreach (int sayi in A)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Oluşan Eleman Sayısı: {A.Count}");
        }

        private static void UnionWithIslem(SortedSet<int> A, SortedSet<int> B)
        {
            //UnionWith - Birleşme
            A.UnionWith(B);

            // Birleşim sonucunda elemanlar A kümesine eklenir.

            System.Console.WriteLine("A ve B Kümesi Birleşimi");
            foreach (int sayi in A)
            {
                System.Console.WriteLine($"{sayi,5}");
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"Oluşan Eleman Sayısı: {A.Count}");
        }
    }
}