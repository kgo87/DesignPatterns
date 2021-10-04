using System;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        private static object _locker = new object();
        static void Main(string[] args)
        {
            lock (_locker)
            {
                new Thread(LoopFunction1).Start();
            }

            new Thread(LoopFunction1).Start();
            new Thread(LoopFunction2).Start();

            for (var i = 0; i < 10; i++)
            {
                var counter = i;
                Task.Run(() => Console.WriteLine($"Task No. {counter}"));
            }
        }

        public static void LoopFunction1()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"LoopFunction 1, iteration No. {i}");
                Thread.Sleep(2000);

            }
        }

        public static void LoopFunction2()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"LoopFunction 2, iteration No. {i}");
                Thread.Sleep(2000);
            }
        }
    }
}
