
using System;

class Grade_Calculator
{
    static void Main()
    {
        // Prompt the user to enter a numerical grade
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();

        // Attempt to parse the input as a double
        
        if (double.TryParse(input, out double grade))
        {
            // Validate that the grade is within the correct range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade;

                if (grade >= 90)
                {
                    letterGrade = "A";
                }
                else if (grade >= 80)
                {
                    letterGrade = "B";
                }
                else if (grade >= 70)
                {
                    letterGrade = "C";
                }
                else if (grade >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                // Display the letter grade
                Console.WriteLine("The letter grade is: " + letterGrade);
            }
            else
            {
                // Grade is outside the valid range
                Console.WriteLine("The grade must be between 0 and 100.");
            }
        }
        else
        {
            // Invalid input
            Console.WriteLine("Invalid input. Please enter a numerical grade.");
        }
    }
}
