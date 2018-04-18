using System;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please type Start, to start the timer.");
        string input = Console.ReadLine().ToLower();

        while (input != "quit")
        {


            Stopwatch stopwatch = new Stopwatch();

            if (input == "start")
            {
                stopwatch.Start();
                Console.WriteLine("Please type Stop, to stop your timer and get elapsed time.");
                input = Console.ReadLine().ToLower();

                if (input == "stop")
                {
                    stopwatch.Stop();
                    Console.WriteLine(stopwatch.Elapsed);
                    Console.WriteLine("Please type start, to start a new timer, or quit, " +
                            "to quit the timer application.");
                    input = Console.ReadLine().ToLower();
                }
            }
            else
            {
                Console.WriteLine("Please type Start, to start the timer.");
                input = Console.ReadLine().ToLower();
            }
        }

    }

}
