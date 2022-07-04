namespace proje_ismi
{
    class Program
    {
        enum Islemler
        {
            Toplama = 1,
            Cikarma = 2,
            Carpma = 3,
            Bolme = 4
        }
        static void Main(string[] args)
            {
                System.Console.Write("1.Sayıyı Giriniz: ");
                int a = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("1.Sayıyı Giriniz: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Islemler secim = (Islemler)(new Random().Next(1,4));


                switch (secim)
                {
                    case Islemler.Toplama:
                        System.Console.WriteLine($"{a} + {b} = {a + b}  ");
                        break;

                    case Islemler.Cikarma:
                        System.Console.WriteLine($"{a} - {b} = {a - b}  ");
                        break;

                    case Islemler.Carpma:
                        System.Console.WriteLine($"{a} * {b} = {a * b}  ");
                        break;

                    case Islemler.Bolme:
                        System.Console.WriteLine($"{a} / {b} = {a / b}  ");
                        break;

                    default:
                        System.Console.WriteLine("\aGeçersiz İşlem!");
                        break;
                }
                Console.ReadKey();
            }
     }
}

