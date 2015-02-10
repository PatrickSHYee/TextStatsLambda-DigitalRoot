using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "Mike's favorite color is blue.";
            Console.WriteLine("Consonants: {0}", NumberOfConsonants(temp));
            Console.WriteLine("Special Chars: {0}", NumberOfSpecialCharacters(temp));
        }

        /// <summary>
        /// Sum of the digits.
        /// </summary>
        /// <param name="rootThisNumber">string of digits</param>
        /// <returns>returns int < 10</returns>
        public static int DigitalRoot(string rootThisNumber)
        {
            int returnInt;
            try
            {
                int.TryParse(rootThisNumber, out returnInt);
                return (1 + (returnInt - 1) % 9);
            }
            catch
            {
                Console.WriteLine("Invalid entry");
                return 0;
            }
        }

        /// <summary>
        /// Number of the words in a sentence
        /// </summary>
        /// <param name="inputString">a sentence</param>
        /// <returns>number of words</returns>
        public static int NumberOfWords(string inputString)
        {
            List<string> words = inputString.Split(' ').ToList<string>();
            return words.Count;
        }

        /// <summary>
        /// Number of vowels in a sentence
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static int NumberOfVowels(string inputString)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            return inputString.Count(x => vowels.Contains(x));
        }

        /// <summary>
        /// Number of Consonants in a sentence remember it's case dependent
        /// </summary>
        /// <param name="inputString">a sentence</param>
        /// <returns>number of consonants</returns>
        public static int NumberOfConsonants(string inputString)
        {
            // bcdfghjklmnpqrstvwxyz
            return inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(x.ToString().ToLower()));
        }

        /// <summary>
        /// number of special characters in a sentence
        /// </summary>
        /// <param name="inputString">a sentence</param>
        /// <returns>nubmer of special characters</returns>
        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => " .,?;'!@#$%^&*()".Contains(x));
        }

        /// <summary>
        /// Order by descending to find the longest word
        /// </summary>
        /// <param name="inputString">a sentence</param>
        /// <returns>longest word</returns>
        public static string LongestWord(string inputString)
        {
            return inputString.Split(' ').OrderByDescending(x=>x.Length).First();
        }

        /// <summary>
        /// Using the order by descending to find the stortest word
        /// </summary>
        /// <param name="inputString">a sentence</param>
        /// <returns>the shortest word</returns>
        public static string ShortestWord(string inputString)
        {
            return inputString.Split(' ').OrderByDescending(x=>x.Length).Last();
        }


    }
}
