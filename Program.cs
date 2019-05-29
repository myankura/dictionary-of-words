using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
    /*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
    */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#.");
            wordsAndDefinitions.Add("Success", "The accomplishment of an aim or purpose.");
            wordsAndDefinitions.Add("Happiness", "A feeling of joy.");
            wordsAndDefinitions.Add("Sadness", "Feeling down.");
            wordsAndDefinitions.Add("Failure", "The opposite of Success.");


            /*
                Use square bracket lookup to get the definitions to
                words and output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Success"]);
            Console.WriteLine(wordsAndDefinitions["Happiness"]);

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine("=============================================");
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
