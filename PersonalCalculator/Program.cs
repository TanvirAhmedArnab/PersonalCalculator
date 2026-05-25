// -----------------------------------------------------------------------------
// Program.cs
// -----------------------------------------------------------------------------
// Purpose:
// Defines the application entry point for the Personal Calculator console
// application. This file is responsible for starting the program, displaying the
// initial user-facing messages, collecting numeric input, presenting the
// operation menu, and keeping the console session active until the user presses
// Enter.
//
// Responsibility Boundary:
// Program.cs should remain a small startup file. It should coordinate application
// launch behavior only. Calculator operations, input handling, validation, and
// menu logic should be moved into separate classes as the application grows.
//
// Current Stage:
// This version collects two numeric values from the user, validates that each
// value can be interpreted as a number, displays a menu of available arithmetic
// operations, validates the selected menu option, and displays which operation
// was selected.
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

            int operationChoice = ReadOperationChoiceFromUser();

            Console.WriteLine();

            if (operationChoice == 1)
            {
                Console.WriteLine("You chose Addition.");
            }
            else if (operationChoice == 2)
            {
                Console.WriteLine("You chose Subtraction.");
            }
            else if (operationChoice == 3)
            {
                Console.WriteLine("You chose Multiplication.");
            }
            else if (operationChoice == 4)
            {
                Console.WriteLine("You chose Division.");
            }
            else if (operationChoice == 5)
            {
                Console.WriteLine("You chose Modulus.");
            }
            else
            {
                Console.WriteLine("Invalid operation choice.");
            }

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

        private static int ReadOperationChoiceFromUser()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)");
                Console.Write("Enter your choice (1-5): ");

                // Menu input is also received as text. It must be converted to
                // an integer before the program can compare it to menu options.
                string? userInput = Console.ReadLine();

                bool isValidChoice = int.TryParse(userInput, out int operationChoice);

                if (isValidChoice && operationChoice >= 1 && operationChoice <= 5)
                {
                    return operationChoice;
                }

                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                Console.WriteLine();
            }
        }
    }
}