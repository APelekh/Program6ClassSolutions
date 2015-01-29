using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //fixed length array
            string[] foodArray = new string[5];
            foodArray[0] = "quinoa";
            foodArray[1] = "grapes";
            Console.WriteLine(foodArray[0]);

            //converting array to list
            List<string> foodList = foodArray.ToList();

            //two dimensional array
            int[,] twoD = new int[5, 5];
            twoD[1, 1] = 7;
            Console.WriteLine(twoD[1,1]);

            //LISTS
            List<string> teams = new List<string>();
            teams.Add("broncos");
            teams.Add("tigers");
            teams.Add("eagles");

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            
            teams.Sort();

            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            //inserting new element at 0 index
            teams.Insert(0, "49ers");

            Console.WriteLine(teams[0]);
            Console.WriteLine(teams[1]);
            Console.WriteLine(teams.Count());

            //resorting
            Console.WriteLine("Resorted");
            teams.Sort();
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            
            //using Contains
            if (teams.Contains("broncos"))
            {
                Console.WriteLine("has broncos");
            }

            Console.WriteLine("Tigers is located at " + teams.IndexOf("tigers"));

            //deleting from list
            teams.Remove("eagles");
            teams.RemoveAt(0);
            teams.RemoveAll();

            Console.ReadKey();
        }
    }
}
