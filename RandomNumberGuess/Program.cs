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


            int turn = 0;

            while (turn != 4)
            {
                int number = int.Parse(Console.ReadLine());

                if (random == number)
                {
                    Console.WriteLine("You won a car!");
                    //turn = 5;
                    break;
                }

                else if (random != number)
                {
                    turn++;
                    if (turn == 4)
                    {
                        break;
                    }
                    Console.WriteLine("Please pick again!");
                }
            }

            if (turn == 4)
            {
                Console.WriteLine("You lost, so sad!");
            }

            Console.ReadLine();

        }
    }
}
