/* Write a program that prompts the user for their first name. Then prompt them for their last name. Display the text back all on one line saying, "Your name is last-name, first-name, last-name".
Example: What is your first name?
What is your last name?
Your name is Lord, Sarah Lord */

using System;

class program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");


    }
}


