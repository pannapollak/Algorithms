using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {

        public bool IsUnique(string word)
        {
            for (int index = 0; index < word.Length; index++)
            {
                for (int nextIndex = index + 1; nextIndex < word.Length; nextIndex++)
                {
                    if (word[index] == word[nextIndex])
                    {
                        return false;
                    }
                } 
            }
            return true;
        }

        public bool CheckPermutation(string word1, string word2)
        {
            return true;
        }

        public string Urlify(string stringWithSpaces)
        {
            return "fed";
        }

        static void Main(string[] args)
        {
            Program start = new Program();
            Console.WriteLine(start.IsUnique("qwertzuiopélkjhgfdsyxcvbnm"));

        }
    }
}
