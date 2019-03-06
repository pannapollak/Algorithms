using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFinder
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfPrime(73454371));

            bool CheckIfPrime(int num)
            {
                for (int i = 2; i < num/2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine($"{num} is dividible by {i}");
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
