namespace altust_sinir
{
    class Program
    {
        static void Main(string[] args)
            {
                // Signed 8-bit Integer
                System.Console.WriteLine(nameof(SByte));
                System.Console.WriteLine($"Alt Limit        : {SByte.MinValue,20}  ");
                System.Console.WriteLine($"Üst Limit        : {SByte.MaxValue,20}  ");
                System.Console.WriteLine($"Boyut        : {sizeof(SByte),20}  ");
                System.Console.WriteLine();
                Console.ReadKey();

                // UnSigned 8-bit Integer
                System.Console.WriteLine(nameof(Byte));
                System.Console.WriteLine($"Alt Limit        : {Byte.MinValue,20}  ");
                System.Console.WriteLine($"Üst Limit        : {Byte.MaxValue,20}  ");
                System.Console.WriteLine($"Boyut        : {sizeof(Byte),20}  ");
                System.Console.WriteLine();
                Console.ReadKey();

                // Signed 8-bit Integer
                System.Console.WriteLine(nameof(Int16));
                System.Console.WriteLine($"Alt Limit        : {Int16.MinValue,20}  ");
                System.Console.WriteLine($"Üst Limit        : {Int16.MaxValue,20}  ");
                System.Console.WriteLine($"Boyut        : {sizeof(Int16),20}  ");
                System.Console.WriteLine();
                Console.ReadKey();

                
                // UnSigned 8-bit Integer
                System.Console.WriteLine(nameof(UInt16));
                System.Console.WriteLine($"Alt Limit        : {UInt16.MinValue,20}  ");
                System.Console.WriteLine($"Üst Limit        : {UInt16.MaxValue,20}  ");
                System.Console.WriteLine($"Boyut        : {sizeof(UInt16),20}  ");
                System.Console.WriteLine();
                Console.ReadKey();






            }
    }
}
