using System;

namespace Stopwatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Press 's' to start the clock.");

            ConsoleKeyInfo start = Console.ReadKey(true);

            if (start.KeyChar == 's')
            {
                DateTime startTime = DateTime.Now;
                Console.WriteLine(startTime);

                Console.WriteLine("Press 'x' to stop the clock.");

                ConsoleKeyInfo stop = Console.ReadKey(true);

                if (stop.KeyChar == 'x')
                {
                    DateTime stopTime = DateTime.Now;
                    Console.WriteLine(stopTime);

                    TimeSpan heatTime = (stopTime - startTime);
                    Console.WriteLine("Heat time: " + heatTime);
                }
            }
        }





        }
    }
