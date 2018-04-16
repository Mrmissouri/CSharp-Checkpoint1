using System;
using System.Collections;
using System.Linq;

namespace MaxNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your list of numbers, each" +
              "seperated by a comma");

            string input = "";
            int[] numberList = null;
            input = Console.ReadLine();


            try
            {
                numberList = Array.ConvertAll(input.Split(','), int.Parse);
                int max = numberList.Max();
                Console.WriteLine("The max value is: " + max);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("***Did you forget to only include numbers?***");

            }
            Console.ReadLine();


        }
    }
}
