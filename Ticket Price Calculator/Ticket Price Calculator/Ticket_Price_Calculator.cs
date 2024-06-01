

using System;

class Ticket_Price_Calculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Attempt to parse the input as an integer
        if (int.TryParse(input, out int age))
        {
            // Determine the ticket price based on the age
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            // Display the ticket price
            Console.WriteLine("The ticket price is: GHC" + ticketPrice);
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
