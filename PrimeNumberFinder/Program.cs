using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFinder
{
    class PrimeChecker
    {
        public int isItPrime = 32;

        public bool CheckIfDivisibleByTwoThreeFive(int isItPrime)
        {

            if (isItPrime != 2 ||
                isItPrime != 3 ||
                isItPrime != 5 ||
                isItPrime % 2 == 0 ||
                isItPrime % 3 == 0 ||
                isItPrime % 5 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            
           
        }
    }
}
