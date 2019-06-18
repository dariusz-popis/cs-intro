using Day01.Contracts;
using Day01.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.ConsoleApp
{
    internal class Program
    {
        private struct Vector { public int x; public int y; public int z; }
        private static void Main(string[] args)
        {
            ICycleProvider<int> provider = new CycleProvider<int>()
                .Add(1).Add(2).Add(3).Add(4).Add(5).Add(6).Add(7).Add(8)
                .Add(9).Add(10).Add(15).Add(4).Add(14).Add(13);

            var t1 = new Task(() =>
            {
                int i = 0;
                while (++i < 10)
                {
                    lock (provider)
                    {
                        Console.ForegroundColor = (ConsoleColor)provider.Next();
                        Console.WriteLine($"Task 1 i={i} | {provider.CurrentItem} {Console.ForegroundColor}");
                    }
                    1.SleepSec();
                }
            });

            var t2 = new Task(() =>
            {
                int i = 0;
                while (++i < 10)
                {
                    lock (provider)
                    {
                        Console.ForegroundColor = (ConsoleColor)provider.Next();
                        Console.WriteLine($"Task 2 i={i} | {provider.CurrentItem} {Console.ForegroundColor}");
                    }
                    3.SleepSec();
                }
            });

            var t3 = new Task(() =>
            {
                int i = 0;
                while (++i < 10)
                {
                    lock (provider)
                    {
                        Console.ForegroundColor = (ConsoleColor)provider.Next();
                        Console.WriteLine($"Task 3 i={i} | {provider.CurrentItem} {Console.ForegroundColor}");
                    }
                    2.SleepSec();
                }
            });
            t1.Start();
            t2.Start();
            t3.Start();

            Task.WaitAll(t1, t2, t3);
            //Console.ReadKey(true);
            //ParallelForechDemo();
        }

        private static void ParallelForechDemo()
        {
            var taskCollection = "SABCxyz123";

            Parallel.ForEach(taskCollection, ProcessInvokingSim);
        }
        private static void ProcessInvokingSim(char c)
        {
            DateTime start = DateTime.Now;
            (c * 50).SleepSec();
            Console.WriteLine($"{c} {start:mm:ss} - {DateTime.Now:mm:ss}");
        }
        private static void DoSmth(Vector vector) { }
    }
}
