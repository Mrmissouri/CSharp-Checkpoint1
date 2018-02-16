using System;
using System.Linq;

namespace DivideBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersList = Enumerable.Range(1, 100).ToArray();
            int count = 0;


            foreach (int number in numbersList)
            {
                if (number % 3 == 0)
                {
                    count++;
                }

            }



            Console.WriteLine(count);

            Console.ReadLine();






        }
    }
}
