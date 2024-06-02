using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the first side: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter the length of the second side: ");
        string input2 = Console.ReadLine();

        Console.Write("Enter the length of the third side: ");
        string input3 = Console.ReadLine();

        // Try to parse the inputs to integers
        if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
        {
            // Check if the sides can form a valid triangle
            if (IsValidTriangle(side1, side2, side3))
            {
                string triangleType;

                // Determine the type of the triangle
                if (side1 == side2 && side2 == side3)
                {
                    triangleType = "Equilateral";
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    triangleType = "Isosceles";
                }
                else
                {
                    triangleType = "Scalene";
                }

                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                Console.WriteLine("The entered sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter numerical values for the sides.");
        }
    }

    // Method to check if three sides can form a valid triangle
    static bool IsValidTriangle(int a, int b, int c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}

