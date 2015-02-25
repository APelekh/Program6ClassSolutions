using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function with $4.19.  
            //Notice that when using the decimal format you must end numbers with an 'm'
            // use a startTime and End time to determine how quickly something runs
            //DateTime startTime = DateTime.Now;
            
            //DateTime endTime = DateTime.Now;
            //use the timespan to figure out the difference
            //TimeSpan difference = startTime - endTime;
            //Console.WriteLine("There was a {0} ms difference", Math.Abs(difference.Milliseconds));

            double s = 0.1;
            string test = "123abc";
            Console.WriteLine(test.Substring(2,2));
            while (s < 0.5)
            {
                s++;
                Console.WriteLine(s);
            }
            ChangeAmountShorter(4.19m);
            ChangeAmountShorter(5.79m);

            Console.ReadKey();
        }

        public static Change ChangeAmountShorter(decimal amount)
        {
            decimal originalAmount = amount;

            Change amountAsChange = new Change();
            amountAsChange.Hundos = TakeASomething(100m, ref amount);
            amountAsChange.Fiddys = TakeASomething(50m, ref amount);
            amountAsChange.Twenties = TakeASomething(20m, ref amount);
            amountAsChange.Tens = TakeASomething(10m, ref amount);
            amountAsChange.Fives = TakeASomething(5m, ref amount);
            amountAsChange.Ones = TakeASomething(1m, ref amount);
            amountAsChange.Quarters = TakeASomething(.25m, ref amount);
            amountAsChange.Dimes = TakeASomething(.10m, ref amount);
            amountAsChange.Nickles = TakeASomething(.05m, ref amount);
            amountAsChange.Pennies = TakeASomething(.01m, ref amount);
            //output
            Console.WriteLine(@"Amount: {0:C}
Fives:    {6}
Ones:     {5}
Quarters: {1}
Dimes:    {2}
Nickles:  {3}
Pennies:  {4}", originalAmount, amountAsChange.Quarters, amountAsChange.Dimes, amountAsChange.Nickles, amountAsChange.Pennies, amountAsChange.Ones, amountAsChange.Fives);

            return amountAsChange;
        }


        static int TakeASomething(decimal amountToTake, ref decimal userInput)
        {
            //while (amount >= .10m)
            //{
            //    amount -= .10m;
            //    amountAsChange.Dimes++;
            //}
            int counter = 0;
            while (userInput >= amountToTake)
            {
                userInput -= amountToTake;
                counter++;
            }
            return counter;
        }

        /// <summary>
        /// Example using the Change class to store data
        /// </summary>
        public static Change Example(decimal amount)
        {
            //creating a new object of our class Change
            Change amountAsChange = new Change();

            //increasing the number of quarters
            amountAsChange.Quarters++;
            amountAsChange.Quarters += 1;
            amountAsChange.Quarters = amountAsChange.Quarters + 1;


            //outputting to the console
            Console.WriteLine("Quarters: " + amountAsChange.Quarters);

            //returning the object
            return amountAsChange;
        }

    }

    public class Change
    {
        public int Ones { get; set; }
        public int Fives { get; set; }
        public int Tens { get; set; }
        public int Twenties { get; set; }
        public int Fiddys { get; set; }
        public int Hundos { get; set; }


        /// <summary>
        /// This is property to hold the number of Quarters to be returned as change
        /// </summary>
        public int Quarters { get; set; }

        /// <summary>
        /// This is property to hold the number of Dimes to be returned as change
        /// </summary>
        public int Dimes { get; set; }

        /// <summary>
        /// This is property to hold the number of Nickles to be returned as change
        /// </summary>
        public int Nickles { get; set; }

        /// <summary>
        /// This is property to hold the number of Pennies to be returned as change
        /// </summary>public int Nickles { get; set; }
        public int Pennies { get; set; }

        public Random rng { get; set; }

        /// <summary>
        /// This is a constructor, it initializes a new instance of the class (called an object).  This sets it's default values.
        /// </summary>
        public Change()
        {
            this.Quarters = 0;
            this.Dimes = 0;
            this.Nickles = 0;
            this.Pennies = 0;
            this.Ones = 0;
            this.rng = new Random();

        }
    }
}