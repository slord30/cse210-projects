using System;

class Program
{
    static void Main(string[] args)
    {
        // generate a random number for the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // create global variable guess and set it equal to -1
        int guess = -1;

        // use a while loop to keep asking the user for a number until they guess the magic number
        while (guess != magicNumber)
        {
            // Ask the user to guess a number
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}