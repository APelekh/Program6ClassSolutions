using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        
        static Random randomNumberGenerator = new Random();
        static void Main(string[] args)
        {
            List<string> studentList = new List<string>() { "Andrii", "Nate", "Juli", "Eugune", "Linda", "Mike", "Tim", "Andrew", "Nicole" };
            PickGroup(studentList, 2);

            Console.ReadKey();
        }
        /// <summary>
        /// Randomly picks up students from the list and assign them to groups
        /// </summary>
        /// <param name="listOfStudents">list of students</param>
        /// <param name="groupSize">size of the group</param>
        static void PickGroup(List<string> listOfStudents, int groupSize)
        {
            
            //getting initial size of list, so I can use it in the loop
            int intialListSize = listOfStudents.Count;

            //creating new list that hold the current group
            List<string> currentGroupList = new List<string>();
            int groupNumber = 1;

            //looping though entire list
            for (int i = 0; i < intialListSize; i++)
            {
                //getting a random student from the list
                int rng = randomNumberGenerator.Next(0, listOfStudents.Count);
                string currentStudent = listOfStudents[rng];

                //adding random student to current group and removing from the list
                currentGroupList.Add(currentStudent);
                listOfStudents.Remove(currentStudent);

                //checking if group is full or list is empty
                if (currentGroupList.Count == groupSize || listOfStudents.Count == 0)
                {
                    Console.WriteLine("GROUP {0}", groupNumber);

                    //printing out current group content
                    for (int j = 0; j < currentGroupList.Count; j++)
                    {
                        Console.WriteLine(currentGroupList[j]);
                    }
                    Console.WriteLine("\n");

                    //other way for output
                    Console.WriteLine(string.Join("\n", currentGroupList));

                    //clearing current group
                    currentGroupList.Clear();
                    groupNumber++;
                }
            }

        }
    }
}
