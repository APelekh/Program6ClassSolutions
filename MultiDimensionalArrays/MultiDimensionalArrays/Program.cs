using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a 1D array
            int[] my1DArray = new int[3];

            //how to make a 2D array?
            int[,] my2DArray = new int[3, 3];

            //populate our 2D array with random values
            //(how to go through an array)
            int counter = 1;
            for (int y = 0; y < 3; y++)
            {
                //for each Y (row)
                for (int x = 0; x < 3; x++)
                {
                    //for each X (column)
                    my2DArray[x, y] = counter;
                    counter++;
                }
            }

            //writing out a grid
            for (int y = 0; y < 3; y++)
            {
                //for each Y (row)
                for (int x = 0; x < 3; x++)
                {
                    //for each x (column)
                    //write to the grid
                    Console.Write("[{0}] ", my2DArray[x,y]);
                }
                //end of row
                Console.WriteLine();
            }

            //create a 2D Array of Points
            Point[,] pointArray = new Point[10, 10];

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //for each column
                    pointArray[x, y] = new Point(x, y);
                }
            }

            //using arrows for movement

            //putting a single keystroke into a variable
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.LeftArrow:
                    //do left arrow stuff
                    break;
                case ConsoleKey.RightArrow:
                    //do right arrow stuff
                    break;
                case ConsoleKey.UpArrow:
                    //do up arrow shenanigans
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down arrow for days");
                    break;
                default:
                    //invalid
                    Console.WriteLine("Not an arrow");
                    break;
               
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Represents a single point on a grid
        /// </summary>
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Point(int x, int y)
            {
                this.X = x; this.Y = y;
            }
            public string Value { get; set; }
        }
    }
}
