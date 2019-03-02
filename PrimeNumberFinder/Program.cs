using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFinder
{
    class PrimeChecker
    {
        public int isItPrime = 2;

        public bool CheckIfDivisibleByTwoThreeFive()
        {

            if (isItPrime != 1 &&
                isItPrime != 2 &&
                isItPrime != 3 &&
                isItPrime != 5)
            {
                if (isItPrime % 2 == 0 ||
                    isItPrime % 3 == 0 ||
                    isItPrime % 5 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            PrimeChecker check = new PrimeChecker();
            Console.WriteLine(check.CheckIfDivisibleByTwoThreeFive());
           
        }
    }
}
