namespace arrayClass
{
    class Program
    {
        static void Main(string[] args)
            {
                //Tanımlama
                int[] sayilar = new int[] {5, 3, 8, 9, 12, 25, 35, 48};
                var numbers = Array.CreateInstance(typeof(int),sayilar.Length);

                sayilar.CopyTo(numbers,0);
                Array.Sort(sayilar);
                Array.Clear(numbers,2,3);
                
                System.Console.WriteLine(Array.IndexOf(numbers,25));

                //Dolaşma
                for (int i = 0; i < sayilar.Length; i++)
                {
                    System.Console.WriteLine(
                        $" sayilar[{i}] = {sayilar[i],3} " +
                        $" numbers[{i}] =  {numbers.GetValue(i),3}  "
                    );
                }
                Console.ReadKey();

            }
    }
}