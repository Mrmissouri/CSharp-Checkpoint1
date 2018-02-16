using System;

namespace RandomNumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int random = new Random().Next(1, 11);

            Console.WriteLine(random);
            Console.WriteLine("Please enter a number between 1 and 10:");


            int turn = 1;

            while (turn <= 4)
            {
                int number = int.Parse(Console.ReadLine());

                if (random == number)
                {
                    Console.WriteLine("You won a car!");
                    turn = 5;
                }

                else if (random != number && turn < 4)
                {
                    Console.WriteLine("Please pick again!");
                    turn = turn + 1;
                }
                else
                {
                    turn = 5;
                    Console.WriteLine("You lost, so sad!");

                }
            }

            Console.ReadLine();

        }
    }
}
