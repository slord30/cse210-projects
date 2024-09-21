using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);
    }        

    // create function DisplayWelcomeMessage
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // create function PromptUsername
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
            
        return name;
    }

    // create function PromptUserNumber
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
        
    // create function SquareNumber
    static int SquareNumber(int number)
    {
        int square = number * number;
        Console.WriteLine($"Your favorite number squared is: {square}");

        return square;
    }

    // create function DisplayResult
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}