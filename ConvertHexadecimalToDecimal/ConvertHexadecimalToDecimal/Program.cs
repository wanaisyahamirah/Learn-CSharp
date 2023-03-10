using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHexadecimalToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            // Get hexadecimal input from user
            string hex = GetHex();

            // Convert hexadecimal to decimal
            int decimalValue = HexToDecimal(hex);

            // Print result
            PrintResult(hex, decimalValue);

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        static String GetHex()
        {
            // Get hexadecimal input from user
            Console.Write("Enter a hexadecimal number: ");
            string hex = Console.ReadLine();
            return hex;
        }

        static int HexToDecimal(string hex)
        {
            int decimalValue = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                // Get the decimal value of the current hexadecimal digit
                int digitValue = HexDigitToDecimal(hex[i]);

                // Multiply the decimal value by the appropriate power of 16 and add to the running total
                decimalValue += digitValue * (int)Math.Pow(16, hex.Length - i - 1);
            }

            return decimalValue;
        }

        static int HexDigitToDecimal(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return int.Parse(hexDigit.ToString());
            }
            else
            {
                hexDigit = char.ToUpper(hexDigit);
                switch (hexDigit)
                {
                    case 'A':
                        return 10;
                    case 'B':
                        return 11;
                    case 'C':
                        return 12;
                    case 'D':
                        return 13;
                    case 'E':
                        return 14;
                    case 'F':
                        return 15;
                    default:
                        throw new ArgumentException($"Invalid hexadecimal digit: {hexDigit}");
                }
            }
        }

        static void PrintResult(String hex, int decimalValue)
        {
            Console.WriteLine($"Decimal value of {hex} is {decimalValue}");
        }
    }
}
