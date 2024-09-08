using System;

class PackageExpress
{
    static void Main()
    {
        // Display the welcome message and instructions to the user.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight.
        Console.Write("Please enter the package weight: ");
        int packageWeight = Convert.ToInt32(Console.ReadLine());

        // If the package weight exceeds 50, display an error message and exit.
        if (packageWeight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program here
        }

        // Prompt the user to enter the package width.
        Console.Write("Please enter the package width: ");
        int packageWidth = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the package height.
        Console.Write("Please enter the package height: ");
        int packageHeight = Convert.ToInt32(Console.ReadLine());

        // Prompt the user to enter the package length.
        Console.Write("Please enter the package length: ");
        int packageLength = Convert.ToInt32(Console.ReadLine());

        // Calculate the total dimensions.
        int totalDimensions = packageWidth + packageHeight + packageLength;

        // If the total dimensions exceed 50, display an error message and exit.
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program here
        }

        // Calculate the shipping quote based on the formula.
        int volume = packageWidth * packageHeight * packageLength; // Multiply the dimensions
        decimal shippingCost = (volume * packageWeight) / 100m; // Calculate cost by dividing by 100

        // Display the final quote to the user as a dollar amount.
        Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:F2}");
        Console.WriteLine("Thank you!"); // Thank the user
    }
}
