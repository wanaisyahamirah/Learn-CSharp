using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int num = GetUserInput();
            int result = GetFactorial(num);
            PrintMessage(num, result);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetUserInput()
        {
            Console.Write("Enter any number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int GetFactorial(int inputNumber)
        {
            int result = 1;

            for(int counter = 1; counter <= inputNumber; counter++)
            {
                result = result * counter;
            }

            return result;
        }

        static void PrintMessage(int inputNumber, int result)
        {
            Console.WriteLine("Factorial of " + inputNumber + " is " + result);
        }

    }
}
