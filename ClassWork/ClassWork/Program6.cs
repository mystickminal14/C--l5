using System;

namespace SimpleCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Display menu
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break; // Exit the loop and end the program
                }

                double result = 0;
                bool isFirstNumber = true;

                while (true)
                {
                    Console.Write("Enter a number (or type 'done' to finish): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "done")
                    {
                        break; // Exit the inner loop to finish inputting numbers
                    }

                    if (double.TryParse(input, out double number))
                    {
                        if (isFirstNumber)
                        {
                            result = number; // Initialize result with the first number
                            isFirstNumber = false;
                        }
                        else
                        {
                            switch (choice)
                            {
                                case 1: // Addition
                                    result += number;
                                    break;
                                case 2: // Subtraction
                                    result -= number;
                                    break;
                                case 3: // Multiplication
                                    result *= number;
                                    break;
                                case 4: // Division
                                    if (number != 0)
                                    {
                                        result /= number;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error: Division by zero is not allowed.");
                                        result = double.NaN; // Set result to Not-a-Number
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                // Display the result if valid
                if (!double.IsNaN(result))
                {
                    Console.WriteLine($"The result is: {result}");
                }

                Console.WriteLine(); // Print a blank line for readability
            }
        }
    }
}
