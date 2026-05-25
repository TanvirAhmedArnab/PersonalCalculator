// -----------------------------------------------------------------------------
// Program.cs
// -----------------------------------------------------------------------------
// Purpose:
// Defines the application entry point for the Personal Calculator console
// application. This file is responsible for starting the program, displaying the
// initial user-facing messages, collecting numeric input, presenting the
// operation menu, calculating the selected operation, displaying the result, and
// keeping the console session active until the user presses Enter.
//
// Responsibility Boundary:
// Program.cs currently coordinates the full console workflow for this early
// version of the project. As the application grows, calculator operations, input
// handling, validation, and menu behavior should be moved into separate classes
// with clear responsibilities.
//
// Current Stage:
// This version collects two numeric values from the user, validates each value,
// displays a menu of available arithmetic operations, validates the selected
// menu option, performs the selected calculation, handles division and modulus
// by zero, and displays the result as a formatted equation.
//
// AI Assistance Documentation:
// AI Tool Used:
// ChatGPT was used to review the code for readability, validation quality,
// naming clarity, and beginner-friendly maintainability.
//
// Implemented AI Suggestion:
// Named constants were added for operation menu choices instead of using raw
// numeric values throughout the program. For example, AdditionChoice is used
// instead of repeatedly comparing directly against the number 1.
//
// Evaluation:
// This suggestion was implemented because it makes the if/else calculation logic
// easier to read, reduces the risk of accidental number mismatches, and keeps the
// menu options easier to update in future commits. The suggestion was reviewed
// before implementation and only kept because its behavior is simple,
// understandable, and appropriate for the current project stage.
//
// Portfolio Quality Note:
// Keeping the entry point readable while using reliable validation and clear
// calculation flow makes the project easier to maintain, test, review, and
// extend in later commits.
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
        private const int AdditionChoice = 1;
        private const int SubtractionChoice = 2;
        private const int MultiplicationChoice = 3;
        private const int DivisionChoice = 4;
        private const int ModulusChoice = 5;

        private static void Main(string[] args)
        {
            WriteWelcomeMessage();

            double firstNumber = ReadNumberFromUser("Please enter your first number:");
            double secondNumber = ReadNumberFromUser("Please enter your second number:");

            Console.WriteLine();
            Console.WriteLine($"You entered: {firstNumber} and {secondNumber}");

            int operationChoice = ReadOperationChoiceFromUser();

            Console.WriteLine();

            bool calculationSucceeded = TryCalculateResult(
                firstNumber,
                secondNumber,
                operationChoice,
                out double result,
                out string operationSymbol,
                out string errorMessage);

            if (calculationSucceeded)
            {
                Console.WriteLine($"{firstNumber} {operationSymbol} {secondNumber} = {result}");
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            WriteClosingMessage();

            Console.ReadLine();
        }

        private static void WriteWelcomeMessage()
        {
            Console.WriteLine("Welcome to Your Personal Calculator!");
            Console.WriteLine("===================================");
            Console.WriteLine();
        }

        private static void WriteClosingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press Enter to close the application.");
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
                WriteOperationMenu();

                string? userInput = Console.ReadLine();

                bool isValidChoice = int.TryParse(userInput, out int operationChoice);

                if (isValidChoice && operationChoice >= AdditionChoice && operationChoice <= ModulusChoice)
                {
                    return operationChoice;
                }

                Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                Console.WriteLine();
            }
        }

        private static void WriteOperationMenu()
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine($"{AdditionChoice}. Addition (+)");
            Console.WriteLine($"{SubtractionChoice}. Subtraction (-)");
            Console.WriteLine($"{MultiplicationChoice}. Multiplication (*)");
            Console.WriteLine($"{DivisionChoice}. Division (/)");
            Console.WriteLine($"{ModulusChoice}. Modulus (%)");
            Console.Write("Enter your choice (1-5): ");
        }

        private static bool TryCalculateResult(
            double firstNumber,
            double secondNumber,
            int operationChoice,
            out double result,
            out string operationSymbol,
            out string errorMessage)
        {
            result = 0;
            operationSymbol = string.Empty;
            errorMessage = string.Empty;

            if (operationChoice == AdditionChoice)
            {
                result = firstNumber + secondNumber;
                operationSymbol = "+";
                return true;
            }
            else if (operationChoice == SubtractionChoice)
            {
                result = firstNumber - secondNumber;
                operationSymbol = "-";
                return true;
            }
            else if (operationChoice == MultiplicationChoice)
            {
                result = firstNumber * secondNumber;
                operationSymbol = "*";
                return true;
            }
            else if (operationChoice == DivisionChoice)
            {
                // Division by zero is blocked so the calculator displays a clear
                // user-facing message instead of showing an invalid result.
                if (secondNumber == 0)
                {
                    errorMessage = "Cannot divide by zero. Please run the program again with a non-zero second number.";
                    return false;
                }

                result = firstNumber / secondNumber;
                operationSymbol = "/";
                return true;
            }
            else if (operationChoice == ModulusChoice)
            {
                // Modulus uses the second number as the divisor, so zero must be
                // blocked for the same reason as division.
                if (secondNumber == 0)
                {
                    errorMessage = "Cannot calculate modulus by zero. Please run the program again with a non-zero second number.";
                    return false;
                }

                result = firstNumber % secondNumber;
                operationSymbol = "%";
                return true;
            }
            else
            {
                errorMessage = "Invalid choice. Please run the program again.";
                return false;
            }
        }
    }
}