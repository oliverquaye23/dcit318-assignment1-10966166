using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out int age))
        {
            // Define ticket prices
            const int regularPrice = 10;
            const int discountedPrice = 7;

            int ticketPrice;

            // Determine the ticket price based on the age
            if (age >= 65 || age <= 12)
            {
                ticketPrice = discountedPrice;
            }
            else
            {
                ticketPrice = regularPrice;
            }

            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical age.");
        }
    }
}

