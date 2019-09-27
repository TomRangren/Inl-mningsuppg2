using System;

namespace Swap Numbers
{
    class Program
    {
        static void Main()
        {
            int a = 10, b = 20;
            BytPlats(ref a, ref b);
            Console.WriteLine("a= " + a +" "+"b=" + b);
        }
            public static void BytPlats(ref int c, ref int d) {
            int temp = c;
            c = d;
            d = temp;
        }
    }
}
