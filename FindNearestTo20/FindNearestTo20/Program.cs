using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestTo20
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            // Get user input
            int num1 = GetInput("Enter the first integer: ");
            int num2 = GetInput("Enter the second integer: ");

            // Check nearest value to 20
            int result = CheckNearestValue(num1, num2);

            // Print result
            Console.WriteLine($"The nearest value to 20 is {result}");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetInput(string prompt)
        {
            Console.Write(prompt);
            int num = GetValidInput();
            return num;
        }

        static int GetValidInput()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Invalid input. Enter an integer: ");
            }
            return num;
        }

        static int CheckNearestValue(int num1, int num2)
        {
            if (num1 == num2)
            {
                return 0;
            }

            int diff1 = Math.Abs(num1 - 20);
            int diff2 = Math.Abs(num2 - 20);

            if (diff1 < diff2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}