using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static int GetYear()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            return year;
        }

        static int GetCentury(int year)
        {
            int century = year / 100;
            if (year % 100 != 0)
            {
                century++;
            }
            return century;
        }

        static void PrintResult(int year, int century)
        {
            Console.WriteLine("{0} belongs to the {1} century.", year, century);
        }

    }
}
