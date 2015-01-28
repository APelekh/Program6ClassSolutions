using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //funtion call for the vowel counter
            string testString = "the lazy dog jumps over the also lazy bear";
            Console.WriteLine("We found {0} vowels in {1}", VowelCounter3000(testString), testString);
            Console.WriteLine("The average length of a word in '{0}' is {1}", testString, AverageWordLengthFinder8000(testString));
            oldTimeyTextPrinter(testString, 500);
            oldTimeyTextPrinter(testString, 100);



            //Console.WriteLine(testString.Split(' ').Average(x => x.Length));
            //another way to count the number of vowels using lambdas
            //testSring.Count(x => "aeiou".Contains(x.ToString().ToLower()));
            
            Console.ReadKey();
        }
        //new functions are declared outside of other functions, but inside the class

        /// <summary>
        /// Counter the number of vowels in a string
        /// </summary>
        /// <param name="inputText">the string to analyze</param>
        /// <returns>the number of vowels found</returns>
        static int VowelCounter3000(string inputText)
        {
            //this is our counteri for vowels
            int numberOfVowelsFound = 0;

            // we need to loop through all indexes to compare each letter

            for (int i = 0; i < inputText.Length; i++)
            {
                //pulling out an individual letter, converting to the lowercase version
                char letter = char.ToLower(inputText[i]);
                //is it a vowel?
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    //yes, it is a vowel! count it!
                    numberOfVowelsFound++;

                }
            }
            //loop complete. gone though every letter of the string, counted all vowels. return the number of vowels found
            return numberOfVowelsFound;
        }

        /// <summary>
        /// Finds the average length of a word in a string
        /// </summary>
        /// <param name="inputText">string to analyze</param>
        /// <returns>average length of characters in a word</returns>
        static double AverageWordLengthFinder8000(string inputText)
        {
            //counters to hold our values to calculate an average
            //need to use doubles, because division returns rounding
            double totalNumberOfCharacters = 0;
            double totalNumberOfWords = 0;

            //we need to split a string into words
            string[] wordArray = inputText.Split(' ');
            //loop over each word in the our wordArray
            for (int i = 0; i < wordArray.Length; i++)
            {
                //get the current word
                string currentWord = wordArray[i];
                //lets process the word
                totalNumberOfWords++;
                totalNumberOfCharacters = totalNumberOfCharacters + currentWord.Length;
            }
            //return our results
            //average = total/number of items
            return totalNumberOfCharacters / totalNumberOfWords;

        }

        /// <summary>
        /// Prints text to the screen like an 80s Apple IIe
        /// </summary>
        /// <param name="inputText">text to print</param>
        /// <param name="pauseDuration">pause between characters in milliseconds</param>
        static void oldTimeyTextPrinter(string inputText, int pauseDuration)
        {
            for (int i = 0; i < inputText.Length; i++){
                
                //get a letter
                char letter = inputText[i];
                //print the letter to the screen
                Console.Write(letter);
                //pause
                System.Threading.Thread.Sleep(pauseDuration);

            }
            //after the text is complete, write a line break
            Console.WriteLine();
        }
    }
}
