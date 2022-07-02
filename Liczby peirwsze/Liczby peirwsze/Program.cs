using System;
using System.Threading;

namespace Liczby_peirwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            long counter = 0;
            bool active = true;
            long result = 0;
            Object locker = new Object();

            Thread thread1 = new Thread(() =>
            {
                for (int i = 1; active; i+=1)
                {
                    lock (locker)
                    {
                        ++counter;
                        if (czyPierwsza(counter)) {
                            ++result;
                        }
                    }
                }

            });

            Thread thread2 = new Thread(() =>
            {
                for (int i = 2; active; i += 2)
                {
                    lock (locker)
                    {
                        ++counter;
                        if (czyPierwsza(counter))
                        {
                            ++result;
                        }
                    }
                }

            });

            Thread thread3 = new Thread(() =>
            {
                for (int i = 3; active; i += 3)
                {
                    lock (locker)
                    {
                        ++counter;
                        if (czyPierwsza(counter))
                        {
                            ++result;
                        }
                    }
                }

            });

            Thread thread4 = new Thread(() =>
            {
                for (int i = 4; active; i += 4)
                {
                    lock (locker)
                    {
                        ++counter;
                        if (czyPierwsza(counter))
                        {
                            ++result;
                        }
                    }
                }

            });

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            Thread.Sleep(10 * 1000);
            active = false;
            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();

            Console.WriteLine("Wynik:" + result);
        }

        static bool czyPierwsza(long a)
        {
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
