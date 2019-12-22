using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindOutIfNumberIsPrimeOrNot
{
    class Program
    {
        bool isPrime(int number)
        {
            bool result = true;
            if (number == 1)
                result = false;
            else
            {
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            int number;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + "-------------------- OUTPUT --------------------");
            if (number < 1)
                Console.WriteLine(number + " is not a valid number. By definition, prime numbers are positive, non-zero numbers.");

            else
            {
                if (obj.isPrime(number) == true)
                    Console.WriteLine(number + " is a prime number");
                else
                    Console.WriteLine(number + " is not a prime number");
            }

            Console.ReadKey();
        }
    }
}
