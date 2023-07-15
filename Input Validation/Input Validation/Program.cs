using System;

namespace InputValidation
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a numeric value:");
            string input = Console.ReadLine();

            try
            {
                int numericValue = int.Parse(input);

                Console.WriteLine("Valid input");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input! The value entered is too large or too small for an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

}