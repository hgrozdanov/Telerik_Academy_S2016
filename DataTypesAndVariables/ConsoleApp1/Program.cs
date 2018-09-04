using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            ushort uShort = 52130; //min 0, max 65,535
            sbyte sByte = -115; //min -128, max 127
            int Int = 4825932; // min -2 billion, max +2 billion
            byte Byte = 97; // min 0, max 255
            short Short = -10000; //min -32,768, max 32,767

            Console.WriteLine(uShort);
            Console.WriteLine(sByte);
            Console.WriteLine(Int);
            Console.WriteLine(Byte);
            Console.WriteLine(Short);

            byte centuries = 20;    // Usually a small number
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520; // May be a very big number
            Console.WriteLine("{0} centuries is {1} years," +
                              " or {2} days, or {3} hours.",
                              centuries, years, days, hours);
        }
    }
}
