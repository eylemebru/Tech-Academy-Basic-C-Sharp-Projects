using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Weight check
        Console.WriteLine("Please enter the package weight:");
        decimal weight = decimal.Parse(Console.ReadLine());

        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get dimension details
        Console.WriteLine("Please enter the package width:");
        decimal width = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        decimal length = decimal.Parse(Console.ReadLine());

        // Total size check
        if ((width + height + length) > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping cost
        decimal quote = (width * height * length * weight) / 100;

        // Display the result
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
