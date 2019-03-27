using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (SortCharacters(word1).SequenceEqual(SortCharacters(word2)))
            {
                return true;
            }
            return false;
        }

        public SortedList<char, int> SortCharacters(string wordToCheck)
        {
            var listOfWord = new SortedList<char, int>();
            foreach (var letter in wordToCheck)
            {
                if (listOfWord.ContainsKey(letter))
                {
                    listOfWord[letter] += 1;
                }
                else
                {
                    listOfWord.Add(letter, 1);
                }
            }
            return listOfWord;
        }

        public string Urlify(string wordWithSpaces)
        {
            string UrlifiedString = Regex.Replace(wordWithSpaces, " ", "%20");

            return UrlifiedString;
        }

        public bool CheckIfPalindrome(string isItPalindrome)
        {
            return true;
        }

        public bool CheckIfOneAway(string first, string second)
        {
            string longerString;
            string shorterString;
            if (first.Length >= second.Length)
            {
                longerString = first;
                shorterString = second;
            }
            else
            {
                longerString = second;
                shorterString = first;
            }

            int awayCounter = 0;
            int secondIndex = 0;
            foreach (var letter in longerString)
            {
                if (letter != second[secondIndex])
                {
                    awayCounter++;
                }
                secondIndex++;
                if (awayCounter > 1)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Program start = new Program();
            Console.WriteLine(start.IsUnique("qwertzuiopélkjhgfdsyxcvbnm"));
            Console.WriteLine(start.CheckPermutation("yessye", "yessye"));
            Console.WriteLine(start.Urlify("wat up "));
            Console.WriteLine(start.CheckIfPalindrome(""));
            Console.WriteLine(start.CheckIfOneAway("pali", "lapi"));
        }
    }
}
