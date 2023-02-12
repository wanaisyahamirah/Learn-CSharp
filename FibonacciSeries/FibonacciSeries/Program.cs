using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            GetFibonacciSeriesWithoutRecursion(7);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static void GetFibonacciSeriesWithoutRecursion(int numOfTerms)
        {
            int prevTerm, currentTerm, sumPrevCurrent, counter;

            prevTerm = 0;
            currentTerm = 1;
            counter = 0;
            List<int> fibonacciSeries = new List<int>();

            while (counter < numOfTerms)
            {
                fibonacciSeries.Add(prevTerm);
                sumPrevCurrent = prevTerm + currentTerm;
                prevTerm = currentTerm;
                currentTerm = sumPrevCurrent;
                counter++;
            }

            PrintSeriesWithComma(fibonacciSeries);

        }

        static void GetFibonacciSeriesWithRecursion(int numOfTerms)
        {

        }

        static void PrintSeriesWithComma (List<int> fibonacciSeries)
        {
            for (int i = 0; i < fibonacciSeries.Count - 1; i++)
            {
                Console.Write(fibonacciSeries[i] + ", ");
            }
            Console.Write(fibonacciSeries[fibonacciSeries.Count - 1]);
        }
    }    
}