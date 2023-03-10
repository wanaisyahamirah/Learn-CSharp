using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            int[] numbers = GetIntegerUserInput();
            double average = CalculateAverage(numbers);
            Console.WriteLine("The average is: " + average);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static double CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = (double)sum / numbers.Length;
            return average;
        }

        static int[] GetIntegerUserInput()
        {
            int[] numbers = new int[4];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbers;
        }
    }
}
