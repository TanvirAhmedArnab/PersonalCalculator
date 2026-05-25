// -----------------------------------------------------------------------------
// Program.cs
// -----------------------------------------------------------------------------
// Purpose:
// Defines the application entry point for the Personal Calculator console
// application. This file is responsible for starting the program, displaying the
// initial user-facing messages, collecting the first numeric values from the
// user, and keeping the console session active until the user presses Enter.
//
// Responsibility Boundary:
// Program.cs should remain a small startup file. It should coordinate application
// launch behavior only. Calculator operations, input handling, validation, and
// menu logic should be moved into separate classes as the application grows.
//
// Current Stage:
// This version collects two numeric values from the user, validates that each
// value can be interpreted as a number, stores the values as double variables,
// and displays the collected values back to the user.
//
// Portfolio Quality Note:
// Keeping the entry point readable while using reliable input validation makes
// the project easier to maintain, test, review, and extend in later commits.
//
// Author: Tanvir Ahmed
// Created: 2026-05-25
// Updated: 2026-05-25
// -----------------------------------------------------------------------------

using System;
using System.Globalization;

namespace PersonalCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your Personal Calculator!");
            Console.WriteLine("===================================");
            Console.WriteLine();

            double firstNumber = ReadNumberFromUser("Please enter your first number:");
            double secondNumber = ReadNumberFromUser("Please enter your second number:");

            Console.WriteLine();
            Console.WriteLine($"You entered: {firstNumber} and {secondNumber}");
            Console.WriteLine();

            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press Enter to close the application.");

            Console.ReadLine();
        }

        private static double ReadNumberFromUser(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);

                // Console input is received as text. The program must validate
                // and convert that text before it can be used as a numeric value.
                string? userInput = Console.ReadLine();

                bool isValidNumber = double.TryParse(
                    userInput,
                    NumberStyles.Float,
                    CultureInfo.CurrentCulture,
                    out double parsedNumber);

                if (isValidNumber)
                {
                    return parsedNumber;
                }

                Console.WriteLine("Invalid number. Please enter a valid numeric value.");
                Console.WriteLine();
            }
        }
    }
}