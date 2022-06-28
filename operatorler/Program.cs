using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARİTMETİK OPERATÖRLER

            int a = 30;
            int b = 60;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b );
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            //İLİŞKİSEL OPERATÖRLER

            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            //MANTIKSAL OPERATÖRLER
            Console.WriteLine(a > b && a > 10);
            Console.WriteLine(!(a > b && a >10));
            Console.WriteLine(a > 20 || a < b);

            Console.ReadKey();
        }
    }
}
