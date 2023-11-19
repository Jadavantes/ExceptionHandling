namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicExceptionHandling();
            MultipleExceptionTypes();
            FinalyBlockUsage();
            CustomExceptionClass();
            ExceptionPropagation();
            UsingThrowAndCatch();
        }

        static void BasicExceptionHandling()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Convert the input to an integer using int.Parse().
            // Use a try-catch block to handle FormatException if the user enters a non-numeric value.
            // Display an error message in case of an exception.
            // Output the input if correct
            try
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine($"You inputted number: {num}");
            }
            catch (FormatException)
            {
                Console.Write("Error occured: FormatException, invalid non-numeric value.");
            }
        }

        static void MultipleExceptionTypes()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Include a catch block for OverflowException to handle cases where the number is too large or small for an int.
            // Display appropriate error messages for different exceptions.
            try
            {
                var num2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"You inputted number: {num2}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error occured: OverflowException, number is too large or small for an int.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error occured: FormatException, invalid non-numberic value.");
            }

        }

        static void FinalyBlockUsage()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Add a finally block to the program.
            // Use the finally block to display a message whether an exception was caught or not.
            try
            {
                var num3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"You inputted number: {num3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error info: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Re-try with a new number");
            }
        }

        // Class for custom exception type
        class NegativeNumberException : ApplicationException
        {
            public NegativeNumberException(string message) : base(message) { }
        }

        static void CustomExceptionClass()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Modify your number input program to throw NegativeNumberException if the user enters a negative number.
            // Handle this exception in a separate catch block and display an appropriate message.ä
            try
            {
                var num4 = int.Parse(Console.ReadLine());

                if (num4 < 0)
                {
                    throw new NegativeNumberException("Negative numbers is not permitted.");
                }
                Console.WriteLine($"You inputted number: {num4}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Re-try with a new number.");
            }
        }

        static void ExceptionPropagation()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumber that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // In this function, call CheckNumber inside a try block and handle the exception.
            try
            {
                var num5 = int.Parse(Console.ReadLine());

                CheckNumber(num5);
                Console.WriteLine($"You inputted number: {num5}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Re-try with a new number.");
            }
        }

        // NOTE: You can implement the CheckNumber here
        static void CheckNumber(int number)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException("Number greater than 100 is not permitted.");
            }
        }

        static void UsingThrowAndCatch()
        {
            Console.Write("Enter a number: ");
            // TODO:
            // Implement BasicExceptionHandling code with following modification
            // Write a function CheckNumberWithLogging that takes an integer and throws ArgumentOutOfRangeException if the number is greater than 100.
            // Modify the CheckNumberWithLogging function to log the exception message before throwing it.
            // In this function, catch the exception in the main program and display the logged message.
            try
            {
                var num5 = int.Parse(Console.ReadLine());

                CheckNumberWithLogging(num5);
                Console.WriteLine($"You inputted number: {num5}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Re-try with a new number.");
            }
        }

        // NOTE: You can implement the CheckNumberWithLogging here
        static void CheckNumberWithLogging (int number)
        {
            if (number > 100)
            {
                Console.WriteLine($"Logging: {number} is greater than 100.");
                throw new ArgumentOutOfRangeException("Number greater than 100 is not permitted.");
            }
        }
    }
}