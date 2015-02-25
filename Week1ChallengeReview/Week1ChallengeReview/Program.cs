using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ChallengeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //array with multiple datatypes
            object[] myArray = new object[10];
            myArray[0] = "something";
            myArray[1] = 23;

            //null can be used for all types of data
            myArray[1] = null;

            List<object> myList = new List<object>();

            List<IEnumerable<object>> listOfLists = new List<IEnumerable<object>>();
            listOfLists.Add(myArray);
            listOfLists.Add(myList);
        }
    }
}
