using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramToPrintPrimeNumbersUptoNthNumber
{
    class Program
    {
        List<int> GetPrimeNumbers(int limit)
        {
            List<int> primeNumbers = new List<int>();
            int i, j, n1 = 0;

            for (i = 2; i <= limit; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        n1++;
                    }
                }
                if (n1 == 2)
                    primeNumbers.Add(i);
                n1 = 0;
            }
            return primeNumbers;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            int number;
            Console.Write("Enter the number upto which prime number to find : ");
            number = Convert.ToInt32(Console.ReadLine());
            var primeNumbers = obj.GetPrimeNumbers(number);

            Console.WriteLine("\n" + "-------------------- OUTPUT --------------------");

            if (primeNumbers.Count == 0)
                Console.WriteLine("No prime number(s) exist upto this number");

            else
            {
                Console.WriteLine("Prime Number(s) are:");
                foreach (var primeNumber in primeNumbers)
                {
                    Console.WriteLine(primeNumber);
                }
            }

            Console.WriteLine("\n" + "Press any key to exit. . .");
            Console.ReadLine();
        }
    }
}
