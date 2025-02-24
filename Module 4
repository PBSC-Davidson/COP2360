using System;

namespace DivisionWithExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();

            DivideNumbers(input1, input2);
        }

        static void DivideNumbers(string num1, string num2)
        {
            try
            {
                int number1 = Convert.ToInt32(num1);
                int number2 = Convert.ToInt32(num2);

                // Check for divide by zero
                if (number2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                int result = number1 / number2;
                Console.WriteLine($"The result of division is: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: Input values are too large to convert to integers. Details: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error: Input values are too large to convert to integers. Details: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
