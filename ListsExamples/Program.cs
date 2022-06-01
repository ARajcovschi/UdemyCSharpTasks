using System;
using System.Collections.Generic;

namespace ListsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
           numbers =  Solution();
            foreach (int item in numbers)
            {
                Console.Write(item+"\t");
            }

        }

      
        public static List<int> Solution()
        {
            // TODO: write your solution here
            //create a new list 
            List<int> myList = new List<int>();
            //go thorugh every number beyweem 100 and 170
            for (int i = 100; i <= 170; i++)
            {
                //check if its an even number
                if (i % 2 == 0)
                {
                    //add it to the list
                    myList.Add(i);
                }
            }
            //return the list
            return myList;
        }
    }
}
