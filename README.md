# Personal Calculator

Personal Calculator is a simple C# console application built as a portfolio project. The goal of this project is to demonstrate clean project setup, disciplined version control, readable code structure, reliable input handling, menu-driven interaction, and step-by-step feature development.

## Project Purpose

This application will provide basic calculator functionality through a console interface. The project starts with a small, reliable foundation and then grows through controlled commits as new features are added.

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
- Identifies the selected operation using `if`, `else if`, and `else`
- Includes version control from the beginning of the project

## Planned Features

- Perform addition
- Perform subtraction
- Perform multiplication
- Perform division
- Perform modulus calculation
- Prevent division and modulus by zero
- Repeated calculations
- Cleaner separation of calculator logic from application startup code

## Technology Used

- C#
- .NET Console Application
- Visual Studio Community
- Git
- GitHub

## Development Approach

This project is being developed in small, professional stages. Each commit should represent one clear improvement to the application.

The first stage established the project structure and confirmed that the application builds and runs successfully. The second stage added reliable input collection by asking the user for two numbers, validating the input, converting valid input into numeric values, and displaying the collected values back to the user.

The current stage adds a user-friendly operation menu. The program now displays five arithmetic choices, validates the selected menu option, and confirms which operation the user selected.

Future stages will add the actual arithmetic calculations, result display, repeated calculations, and cleaner separation between startup code, input handling, menu handling, and calculation logic.

## Repository Status

This project is in active early development. The current version supports validated numeric input collection and validated operation menu selection.