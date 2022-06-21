using System;
using System.IO;

namespace ParsingGame
{

    //Create a class Program with the Main method with code that will read from the input.txt line by line;

    //If one of the lines contains "split", you have to split it(use the split method from string class)

    //Take the return from the split and write the element with index 4 into the output.txt ;

    //You have to add a space between each element to make it readable;
    class Program
    {

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\alexa\Desktop\input.txt");

            using (StreamWriter file = new StreamWriter(@"C:\Users\alexa\Desktop\output.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("split"))
                    {
                        string[] subs = line.Split();
                        if (subs.Length>=5)
                        {
                            file.Write(" " + subs[4]);

                        }
                    }
                }
            }

        }
    }
}
