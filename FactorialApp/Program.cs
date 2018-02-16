using System;

namespace FactorialApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find the factorial");

            int n = int.Parse(Console.ReadLine());
            int factorial = 1;

            for (int i = n; i > 0; i--)
            {
                factorial = factorial * i;
            }



            Console.WriteLine("The factorial of {0}! is {1}", n, factorial);
            Console.ReadLine();

        }
    }
}
