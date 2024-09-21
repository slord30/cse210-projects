using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        // Ask the user for a series of numbers and append each one to a list. Stop when the user enters 0.
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // Part 2: Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        // Part 3: Find the largest number in the list
        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                // if this number is greater than the largest number, we found the new largest number
                largest = number;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}