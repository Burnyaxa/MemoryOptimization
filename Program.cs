using System;
using System.Diagnostics;
namespace MemoryOptimization
{
    class Program
    {
        static void NonOptimized()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[,] a = new int[10, 10];
            int res = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[j, i]++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Total time: {0}", stopwatch.Elapsed);
        }

        static void Optimized()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int[,] a = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j]++;
                }
            }
            stopwatch.Stop();
            Console.WriteLine("Total time: {0}", stopwatch.Elapsed);
        }
        static void Main(string[] args)
        {
            NonOptimized();
            Optimized();
        }
    }
}
