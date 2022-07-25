using System;
using System.Collections.Generic;

namespace struct1
{
    class Program
    {
        struct Nokta
        {
            public Nokta(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }

            public override string ToString()
            {
                return $" {X},{Y}  ";
            }

            public void SetOrigin()
            {
                this.X = 0;
                this.Y = 0;
            }

            public void Degistir()
            {
                int gecici = X;
                X = Y;
                Y = gecici;
            }

        }
        static void Main(string[] args)
            {
                // Struct Değer Tiplidir.
                var n1 = new Nokta(3,4);
                System.Console.WriteLine($"n1: {n1} ");

                n1.Degistir();
                System.Console.WriteLine($"n1: {n1} ");
                var n2 = n1;
                System.Console.WriteLine($"n2:  {n2}  ");

                n2.X = -1 * n2.X;

                System.Console.WriteLine($"n1: {n1} ");
                System.Console.WriteLine($"n2:  {n2}  ");




            }
    }
}
