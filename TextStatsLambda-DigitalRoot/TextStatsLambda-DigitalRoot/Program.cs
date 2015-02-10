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
            //string text = "I'm a code ninja!";
            //TextStats(text);
            DigitalRoot("589");
            

            Console.ReadKey();
        }

        /// <summary>
        /// Calculates different parameters of the string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        static void TextStats(string inputString)
        {
            Console.WriteLine("Input is: \"{0}\"", inputString);
            Console.WriteLine("Number of characters: {0}", inputString.Count(x => "abcdefghijklmnopqrstuvwxyz".Contains(char.ToLower(x))));
            Console.WriteLine("Number of words: {0}", NumberOfWords(inputString));
            Console.WriteLine("Number of vowels: {0}", NumberOfVowels(inputString));
            Console.WriteLine("Number of consonants: {0}", NumberOfConsonants(inputString));
            Console.WriteLine("Number of spec characters: {0}", NumberOfSpecialCharacters(inputString));
            Console.WriteLine("Longest word: {0}", LongestWord(inputString));
            Console.WriteLine("Shortest word: {0}", ShortestWord(inputString));
        }
        /// <summary>
        /// Calculates the digital root of the number
        /// </summary>
        /// <param name="rootThisNumber">Number to be processed</param>
        /// <returns>Digital root of the input number</returns>
        public static int DigitalRoot(string rootThisNumber)
        {
            //declaring a new variable to store the sum of digits
            int sum = 0;
            //converting input number to integer
            int inputNumber = int.Parse(rootThisNumber);
            //looping if an input number is greater then 9
            while (inputNumber > 9)
            {
                //getting the last digit of an input number and adding to the sum variable
                sum += inputNumber % 10;
                //cutting the last digit from an input number
                inputNumber = inputNumber / 10;
                //checking if an input number is less then 9 after above calculations
                if (inputNumber < 9)
                {
                    //adding up input number and sum variable, and assigning their sum to new input number
                    inputNumber = sum + inputNumber;
                    //reseting my sum varible
                    sum = 0;
                }
            }
            //returning the digital sum
            return inputNumber;
        }
        /// <summary>
        /// Calculates how many words are in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Number of words in a string</returns>
        public static int NumberOfWords(string inputString)
        {
            List<string> list = inputString.Split(' ').ToList(); 
            return list.Count;
        }
        /// <summary>
        /// Calculates the number of vowels in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Number of vowels in a string</returns>
        public static int NumberOfVowels(string inputString)
        {
            return inputString.Count(x => "aeiou".Contains(char.ToLower(x)));
        }
        /// <summary>
        /// Calculates the number of consonants in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Number of consonants in a string</returns>
        public static int NumberOfConsonants(string inputString)
        {
            return inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(x)));
        }
        /// <summary>
        /// Calculates the number of special characters in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Number of special characters in a string</returns>
        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            return inputString.Count(x => ".,?;'!@#$%^&*() ".Contains(char.ToLower(x)));
        }
        /// <summary>
        /// Returns the longest word in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Returns the longest word</returns>
        public static string LongestWord(string inputString)
        {
            List<string> list = inputString.Split(' ').ToList();
            return list.OrderByDescending(x => x.Length).First();
        }
        /// <summary>
        /// Returns the shortest word in a string
        /// </summary>
        /// <param name="inputString">String to be processed</param>
        /// <returns>Returns the shortest word</returns>
        public static string ShortestWord(string inputString)
        {
            List<string> list = inputString.Split(' ').ToList();
            return list.OrderBy(x => x.Length).First();
        }


    }
}
