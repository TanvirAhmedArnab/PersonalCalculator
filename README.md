# Personal Calculator

Personal Calculator is a simple C# console application built as the capstone project for the Coursera course [C# Programming Fundamentals and Development Environment](https://www.coursera.org/learn/c-sharp-programming-fundamentals-and-development-environment/home/welcome). The goal of this project is to demonstrate clean project setup, disciplined version control, readable code structure, reliable input handling, menu-driven interaction, basic error handling, testing, and step-by-step feature development.

## Course Context

This project was completed as the capstone project for the Coursera course [C# Programming Fundamentals and Development Environment](https://www.coursera.org/learn/c-sharp-programming-fundamentals-and-development-environment/home/welcome).

## Project Purpose

This application provides basic calculator functionality through a console interface. The project starts with a small, reliable foundation and grows through controlled commits as new features are added.

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
- Includes documented AI assistance
- Includes documented testing and debugging reflection

## Technology Used

- C#
- .NET Console Application
- Visual Studio Community
- Git
- GitHub

## Testing Summary

The calculator was tested with positive numbers, negative numbers, decimal numbers, invalid numeric input, invalid menu choices, division by zero, and modulus by zero.

### Manual Test Cases

| Test Case | Example Input | Expected Result |
|---|---:|---|
| Addition | `10`, `5`, choice `1` | `10 + 5 = 15` |
| Subtraction | `10`, `5`, choice `2` | `10 - 5 = 5` |
| Multiplication | `10`, `5`, choice `3` | `10 * 5 = 50` |
| Division | `10`, `5`, choice `4` | `10 / 5 = 2` |
| Modulus | `10`, `3`, choice `5` | `10 % 3 = 1` |
| Decimal addition | `5.5`, `3.2`, choice `1` | `5.5 + 3.2 = 8.7` |
| Negative number calculation | `-10`, `3`, choice `1` | `-10 + 3 = -7` |
| Division by zero | `10`, `0`, choice `4` | Clear divide-by-zero error message |
| Modulus by zero | `10`, `0`, choice `5` | Clear modulus-by-zero error message |
| Invalid number input | `abc` | Program asks for a valid numeric value again |
| Invalid menu choice | `9` or `abc` | Program asks for a number from `1` to `5` again |

## Debugging Summary

During debugging, a breakpoint was set before the call to `TryCalculateResult`. I stepped into the method and watched `firstNumber`, `secondNumber`, `operationChoice`, `result`, `operationSymbol`, and `errorMessage` in the Visual Studio Locals window.

One issue I checked carefully was division by zero. By stepping through the division branch with `secondNumber` set to `0`, I confirmed that the program returned a clear error message instead of calculating an invalid result.

## AI Assistance Disclosure

AI assistance was used during development to review code readability, validation logic, naming clarity, and comment quality.

One implemented suggestion was replacing repeated raw menu numbers with named constants such as `AdditionChoice`, `DivisionChoice`, and `ModulusChoice`. This made the operation-selection logic easier to read and reduced the chance of mismatching menu numbers in future changes.

All AI-generated suggestions were reviewed before being added. Only suggestions that were understandable, useful, and appropriate for the current project stage were implemented.

## Development Reflection

The most challenging part of this project was not the arithmetic itself, but making the program handle user input safely. A simple calculator can fail quickly if the user enters text instead of a number, chooses an invalid menu option, or attempts division by zero. Adding validation made the project more reliable and closer to how a real user-facing tool should behave.

AI assistance helped by suggesting readability improvements, especially named constants and clearer structure around input validation. It was useful as a review tool, but the suggestions still needed to be evaluated before implementation. In the future, this calculator could be improved by adding repeated calculations, calculation history, cleaner separation into multiple classes, and automated unit tests.

## Development Approach

This project was developed in small, meaningful commits. Each commit introduced one clear improvement, such as project setup, validated input collection, menu selection, arithmetic calculation, code cleanup, AI assistance documentation, and final testing.

## Repository Status

This project is complete as the capstone project for the Coursera course [C# Programming Fundamentals and Development Environment](https://www.coursera.org/learn/c-sharp-programming-fundamentals-and-development-environment/home/welcome). The current version supports validated numeric input, validated operation menu selection, arithmetic calculation, formatted result output, basic zero-division protection, documented AI assistance, and documented testing.