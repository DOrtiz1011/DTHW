using System;

namespace DTHW
{
    class Program
    {
        static void Main()
        {
            var keyCounts = new KeyCounts("input.txt");
            keyCounts.PrintResults();

            Console.ReadLine();
        }
    }
}
