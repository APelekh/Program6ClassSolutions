using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        static Random randomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            /*for (int i=0; i < 10; i++)
            {
                Console.WriteLine(FlipACoint());
            }*/
            
           
            
            Console.WriteLine(FlipForHeads());
            

                      
            Console.ReadKey();
        }

        /// <summary>
        /// Flips a "coin"
        /// </summary>
        /// <returns>returns a strng of either heads or tails</returns>
        static string FlipACoint()
        {
            int theFlip = randomNumberGenerator.Next(0, 2);
            if (theFlip == 0){
                return "Head";
            }

            return "Tails";

        }

        /// <summary>
        /// Flips a coin until a heads ha been flipped
        /// </summary>
        /// <returns>number of tries it toll to flip the coin</returns>
        static int FlipForHeads()
        {
            bool headsHasNotBeenFlipped = true;
            int howManyFlips = 0;
            while (headsHasNotBeenFlipped)
            {
                string theFlip = FlipACoint();
                howManyFlips++;
                if (theFlip == "Head")
                {
                    headsHasNotBeenFlipped = false;
                }
                
            }
            return howManyFlips;
        }


      }
    
}

