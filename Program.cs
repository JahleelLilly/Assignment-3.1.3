using System;
using System.Reflection.Metadata.Ecma335;

//Counting String Spaces


namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a string: ");
            string input = Console.ReadLine();

            int spaceCount = CountSpaces(input);

            Console.WriteLine("\"" + input + "\" contains " + spaceCount + " spaces");
        }
        static int CountSpaces(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
