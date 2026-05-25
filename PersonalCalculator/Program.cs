// -----------------------------------------------------------------------------
// Program.cs
// -----------------------------------------------------------------------------
// Purpose:
// Defines the application entry point for the Personal Calculator console
// application. This file is responsible for starting the program, displaying the
// initial user-facing messages, and keeping the console session active until the
// user presses Enter.
//
// Responsibility Boundary:
// Program.cs should remain a small startup file. It should coordinate application
// launch behavior only. Calculator operations, input handling, validation, and
// menu logic should be moved into separate classes as the application grows.
//
// Current Stage:
// This version establishes the initial project structure, confirms that the
// application builds and runs successfully, and presents the first user-facing
// console screen.
//
// Portfolio Quality Note:
// Keeping the entry point small improves readability, maintainability, testing,
// and future extension.
//
// Author: Tanvir Ahmed
// Created: 2026-05-25
// Last Updated: 2026-05-25
// -----------------------------------------------------------------------------

using System;

namespace PersonalCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Your Personal Calculator!");
            Console.WriteLine("===================================");
            Console.WriteLine();

            Console.WriteLine("This calculator is being prepared for basic arithmetic operations.");
            Console.WriteLine();

            Console.WriteLine("Thank you for using the calculator!");
            Console.WriteLine("Press Enter to close the application.");

            Console.ReadLine();
        }
    }
}