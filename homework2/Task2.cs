using System;

namespace homework2
{
    class Task2
    {
        static void Main(string[] args) // Последняя цифра
        {
            string n = Console.ReadLine();
            n.Split();
            Console.WriteLine(n[n.Length - 1]);
        }
    }
}
