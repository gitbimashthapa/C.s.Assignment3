using System;

class Task6Program
{
    static void Main()
    {
        // Part 1: Try-Catch-Finally
        try
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }

        // Part 2: Throw custom exception
        try
        {
            Console.Write("Enter password: ");
            string? password = Console.ReadLine();

            if (password == null || password.Length < 6)
                throw new Exception("Password must be at least 6 characters.");

            Console.WriteLine("Password satisfied the requirement.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
