using System;

namespace homework2
{
    class Task5
    {
        static void Main(string[] args) // Улитка
        {
            string h = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int h1 = int.Parse(h);
            int a1 = int.Parse(a);
            int b1 = int.Parse(b);
            int y0 = 0;
            int n = 0;
            while (y0 < h1)
            {
                y0 += a1;
                y0 -= b1;
                if (y0 < h1)
                    n += 1;
            }
            Console.WriteLine(n);
        }
    }
}
