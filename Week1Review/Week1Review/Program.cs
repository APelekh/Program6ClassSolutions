using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        static void Main(string[] args)
        {

            SpaceRemover("a dog is a great pet");
            // a build in space remover
            string noSpace = " lots of spaces".Replace(" ", "");
            string noSpace1 = " lots of spaces".Replace(" ", string.Empty);
            
           
            //using a inline-string to do a check if a letter is a vowel
            string vowelString = "aeiou";
            //if ("aeiou".Contains(noSpace[1].ToString().ToLower()))
            //{
            
            //}
            //for commenting ctrl+K then C, to uncoment U

            SpecificLetterCounter("s", "Sally is sunny");
            
            Console.WriteLine(NumberRounder(8));
            Console.WriteLine(NumberRounder(6));
            Console.WriteLine(NumberRounder(7));
            Console.WriteLine(NumberRounder(8));
            Console.WriteLine(NumberRounder(9));
            Console.WriteLine(NumberRounder(10));
            Console.WriteLine(NumberRounder(11));
            Console.WriteLine(NumberRounder(12));
            Console.WriteLine(NumberRounder(13));
            Console.WriteLine(NumberRounder(14));
            Console.WriteLine(NumberRounder(15));

            Console.WriteLine(AnnoyingTextifyer("nickleback"));

            Console.WriteLine(0.19 % 0.25);
            Console.WriteLine(0.19 / 0.25);


            Console.ReadKey();            
        }
        /// <summary>
        /// Take in a string, removes all the spaces
        /// </summary>
        /// <param name="inputString">string to despacify</param>
        /// <returns>a string with no spaces</returns>
        static string SpaceRemover(string inputString)
        {
            //declare a empty return string
            string returnString = "";
            //or
            string returnString1 = string.Empty;
            
            //loop over each letter
            for (int i = 0; i < inputString.Length; i++ )
            {
                //get an individual letter
                string letter = inputString[i].ToString();
                if (letter != " ") 
                //or 
                    
                //(!(letter == " "))
                {
                    //huzzah! letter is not a space
                    returnString = returnString + letter;
                }
            }
            //loop completes, return our return string
            return returnString;
        }
        /// <summary>
        /// Counts the number of instances of a spesific letter in a string
        /// </summary>
        /// <param name="letterToCount">Letter to count</param>
        /// <param name="stringToSearch">String to seach</param>
        static void SpecificLetterCounter(string letterToCount, string stringToSearch)
        {
            //Output
            //<stringToSearch> has X letterToCount's in it
            //Sally is sunny has 3 s's in it

            // holds the number of matches found
            int letterCounter = 0;
            //loop through each letter
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                // get a letter
                string letter = stringToSearch[i].ToString().ToLower();
                //comparing the current letter with the letter we are trying to find
                if (letterToCount.ToLower() == letter)
                {
                    letterCounter++;
                }
            }
            Console.WriteLine("{0} has {1} {2} in it", stringToSearch, letterCounter, letterToCount);
        }
        /// <summary>
        /// Rounds the integer to the nearest 5
        /// </summary>
        /// <param name="numberToRound">the number to round</param>
        /// <returns>nearest 5</returns>
        static int NumberRounder(int numberToRound)
        {
           Console.WriteLine("The nearest 5 rounder to {0} is ", numberToRound);
            
            int remainder = numberToRound % 5;
            if (remainder > 2){
                numberToRound = numberToRound + 5 - remainder;
            //Nate's version
            // numberToRound = numberToRound + (5 - remainder) ;
            }
            else{
                numberToRound -= remainder;
            }
            return numberToRound; 
        }
        
        //my initial way how to do it
        /*
        static int NumberRounder(int numberToRound)
        {
            Console.WriteLine("The nearest 5 rounder to {0} is ", numberToRound);
            int numberToReturn = 0;                    
            if (numberToRound % 5 == 1){
                numberToReturn = numberToRound - 1;
                return numberToReturn;
            }
            else if (numberToRound % 5 == 2){
                numberToReturn = numberToRound - 2;
                return numberToReturn;
            }
            else if (numberToRound % 5 == 3){
                numberToReturn = numberToRound + 2;
                return numberToReturn;
            }   
            else if (numberToRound % 5 == 4){
                numberToReturn = numberToRound + 1;
                return numberToReturn;
            }
            return numberToRound;
        }
        */



        /// <summary>
        /// Take in a string, it will return a string with letters alrernation between upper and lower casse.
        /// </summary>
        /// <param name="notAnnoyingstring">string to make annoying</param>
        /// <returns>hard to read string</returns>
        static string AnnoyingTextifyer(string notAnnoyingstring)
        {
            string annoyingString = "";
            string letter = "";
            for (int i = 0; i < notAnnoyingstring.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //letter = notAnnoyingstring[i].ToString();
                    annoyingString = annoyingString + notAnnoyingstring[i].ToString().ToUpper();
                }
                else
                {
                    letter = notAnnoyingstring[i].ToString();
                    annoyingString = annoyingString + letter;
                }
            }

                return annoyingString;
        }
        //other and better way to do this problem

        /*  string annoyingString = "";
            string letter = notAnnoyingstring[i].ToString();
            for (int i = 0; i < notAnnoyingstring.Length; i++)
            {
                if (i % 2 == 0)
                {
                    annoyingString += letter.ToUpper();
                }
                else
                {
                    annoyingString += letter.ToLower();
                }
            }
        */

    }
}
