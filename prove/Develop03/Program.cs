using System;

class Program
{

    static void Main()
    {      
        Scripture scripture = new Scripture("3 Nephi ", 12, 16, "Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven.");
        Console.Clear();
        scripture.Display();
        Console.WriteLine();
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("\nNice job! You memeorized the scripture!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }
    }
}

