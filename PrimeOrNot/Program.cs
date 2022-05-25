using System;

namespace PrimeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, i, counter = 0;

            Console.Write("\n\n");
            Console.Write("Check whether a given number is prime or not:\n");
            Console.Write("-----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if(num % i == 0)
                {
                    counter++;
                    break;
                }
            }

            if (counter == 0 && num != 1)
            {
                Console.Write($"{0} is a prime number.\n", num);
            }
            else
            {
                Console.Write($"{0} is a prime number.\n", num);
            }
        }
    }
}
