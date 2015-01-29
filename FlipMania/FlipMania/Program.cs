using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static Random randomNumberGenerator1 = new Random();
        static Random randomNumberGenerator2 = new Random();

        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);
            
                        
            Console.ReadKey();
        }
        /// <summary>
        /// Flips a coin for x amount of times and displays how many tails and heads were flipped
        /// </summary>
        /// <param name="numberOfFlips">number of flips</param>
        static void FlipCoins(int numberOfFlips)
        {
            // you can perform the check for valid data, not negative, like:
            // if (numberOfFlips > 0)
            int numberOfHeads = 0;
            int numberOfTails = 0;
            for (int i = 0; i < numberOfFlips; i++)
            {
                //using first declared rng
                int theFlip = randomNumberGenerator1.Next(0, 2);
                //checking for head or tail
                if (theFlip == 0)
                // other way to do it: if (rng.Next(0,2) == 0)
                {
                    numberOfHeads++;
                }
                else
                {
                    numberOfTails++;
                }
            }
            Console.WriteLine("We flipped a coin " + numberOfFlips + " times");
            Console.WriteLine("Number of Heads: " + numberOfHeads);
            Console.WriteLine("Number of Tails: " + numberOfTails);
        }

        /// <summary>
        /// Flipping a coin until the amount of flipped heads is equal to the amount of heads that was passed to function
        /// </summary>
        /// <param name="numberOfHeads">amount of flipped heads</param>
        static void FlipForHeads(int numberOfHeads)
        {
            
            int numberOfHeadsFlipped = 0;
            int totalFlips = 0;
            //checking when number of heads is equal to number of flips
            while (numberOfHeadsFlipped != numberOfHeads)
            {
                //using second declared rng
                int theFlip = randomNumberGenerator2.Next(0, 2);
                totalFlips++;
                if (theFlip == 0)
                {
                    numberOfHeadsFlipped++;
                }
            }
            Console.WriteLine("We are flipping a coin until we find " + numberOfHeads + " heads");
            Console.WriteLine("It took " + totalFlips + " to find " + numberOfHeads + " heads");

        }
    }
}
