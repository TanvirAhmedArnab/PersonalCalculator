# Personal Calculator

Personal Calculator is a simple C# console application built as a portfolio project. The goal of this project is to demonstrate clean project setup, disciplined version control, readable code structure, reliable input handling, menu-driven interaction, basic error handling, and step-by-step feature development.

## Project Purpose

This application provides basic calculator functionality through a console interface. The project starts with a small, reliable foundation and then grows through controlled commits as new features are added.

## Current Features

- Displays a welcome message
- Displays a closing message
- Keeps the console open until the user presses Enter
- Uses a clean `Program.cs` entry point
- Collects two numbers from the user
- Converts valid text input into `double` values
- Validates numeric input using `double.TryParse`
- Repeats number prompts when invalid numeric values are entered
- Displays a menu with five arithmetic operation choices
- Collects and validates the user's menu selection
- Performs addition
- Performs subtraction
- Performs multiplication
- Performs division
- Performs modulus calculation
- Prevents division by zero
- Prevents modulus by zero
- Displays the result as a formatted equation
- Includes version control from the beginning of the project

## Planned Features

- Repeated calculations
- Cleaner separation of calculator logic from application startup code
- Improved result formatting
- Automated tests for calculator behavior
- More structured error messages
- Optional calculation history

## Technology Used

- C#
- .NET Console Application
- Visual Studio Community
- Git
- GitHub

## Development Approach

This project is being developed in small, professional stages. Each commit should represent one clear improvement to the application.

The first stage established the project structure and confirmed that the application builds and runs successfully. The second stage added reliable input collection by asking the user for two numbers, validating the input, converting valid input into numeric values, and displaying the collected values back to the user.

The third stage added a user-friendly operation menu. The program displayed five arithmetic choices, validated the selected menu option, and confirmed which operation the user selected.

The current stage implements the actual arithmetic behavior. The program now performs the selected operation, displays a formatted equation, and handles invalid division or modulus by zero cases gracefully.

Future stages will add repeated calculations, cleaner separation between startup code and calculator logic, improved output formatting, and automated tests.

## Repository Status

This project is in active early development. The current version supports validated numeric input, validated operation menu selection, arithmetic calculation, formatted result output, and basic zero-division protection.