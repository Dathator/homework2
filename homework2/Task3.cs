using System;

namespace homework2
{
    class Task3
    {
        static void Main(string[] args) // Число десятков
        {
            string n = Console.ReadLine();
            n.Split();
            int[] a = new int[n.Length - 1];
            if (n.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                foreach (char i in n)
                {
                    if (n.IndexOf(i) != n.Length - 1)
                    {
                        a[n.IndexOf(i)] = i;
                    }
                }
                foreach (char i in a)
                    Console.Write(i);
            }
        }
    }
}