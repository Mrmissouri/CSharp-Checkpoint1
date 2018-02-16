using System;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {



            string exit = "exit";
            string input = "";
            int number = 0;
            int total = 0;



            while (input != "ok")
            {

                Console.WriteLine("Please enter a number or 'ok' " +
                              "to see the sum of all numbers");
                input = Console.ReadLine();

                int.TryParse(input, out number);

                if (number > 0)
                {
                    total += number;
                    number = 0;
                }




            }

            Console.WriteLine("Total is: " + total);
            Console.ReadLine();

        }
    }
}
