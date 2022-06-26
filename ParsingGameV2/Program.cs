//Read and store the whole text from the source file;

//Using regular expressions find all sequences of numbers that has length 2 or 3;

//Pars every value into an integer;

//Use casting to convert every integer into a char. It will look like that:

//(char)YourValue;
//and just print the result of each cast on the new line;
using System.Collections.Generic;
using System.Text.RegularExpressions;

string[] lines = File.ReadAllLines(@"C:\Users\alexa\Desktop\input2.txt");
List<Char> output = new List<Char> { };
Regex filter = new Regex(@"(\d{2,4})");
foreach (string line in lines)
{
    var match = filter.Match(line);
    if (match.Success)
    {
        int a = Int32.Parse(match.Value);
        char c = (char)a;
        output.Add(c);

    }

    foreach (char item in output)
    {
        Console.Write(item);
    }
}


