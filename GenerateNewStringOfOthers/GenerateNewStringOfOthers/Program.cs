using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateNewStringOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            
            // Get input string
            string input = GetInput();

            // Create new string of every other character
            string result = GetEveryOtherCharacter(input);

            // Print result
            PrintResult(result);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static string GetInput()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            return input;
        }

        static string GetEveryOtherCharacter(string input)
        {
            string result = "";
            for (int i = 0; i < input.Length; i += 2)
            {
                result += input[i];
            }
            return result;
        }

        static void PrintResult(string result)
        {
            Console.WriteLine($"The new string of every other character is: {result}");
        }
    }
}
