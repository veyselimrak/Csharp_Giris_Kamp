using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
            {
                //Tanımlama
                ArrayList arrayList = new ArrayList()
                {
                    20, "BTK Akademi", true, 'v' 
                };

                //Ekleme
                arrayList.Add(20);
                arrayList.Add("BTK Akademi");
                arrayList.Add(true);
                arrayList.Add('v');



                //Dolaşma
                foreach (var item in arrayList)
                {
                    System.Console.Write($"{item} "); 
                }

                int[] sayilar = new int[] {22, 33, 44};
                arrayList.AddRange(sayilar);
                System.Console.WriteLine();

                foreach (var item in arrayList)
                {
                    System.Console.Write($"{item} "); 
                }
                //Elemana Erişim
                System.Console.WriteLine();
                System.Console.WriteLine(arrayList[4]);

                //Elemana Erişim ve Atama Zorda kalmadığın sürece uygulama performasn açısından iyi değil
                var x = (int)arrayList[0];
                System.Console.WriteLine(x + 10);

                arrayList.Remove(20);
                arrayList.RemoveAt(1);
                arrayList.RemoveRange(3,2);

                foreach (var item in arrayList)
                {
                    System.Console.Write($"{item} "); 
                }


                Console.ReadKey();
            }
    }
}
