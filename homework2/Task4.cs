using System;

namespace homework2
{
    class Task4
    {
        static void Main(string[] args) // Симметричное число
        {
            string n = Console.ReadLine();
            n.Split();
            int[] a = new int[n.Length];
            foreach (char i in n)
            {
                a[a.Length - 1 - n.IndexOf(i)] = i;
            }
            foreach (char i in a)
                Console.Write(i);
        }
    }
}
