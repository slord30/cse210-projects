using System;

class Program
{
    static void Main(string[] args)
    {

        // //test code
        // Entry e = new Entry();
        // e._date = "6/30/2025";
        // e._promptText = "How was your day?";
        // e._entryText = "Really tired.";
        // e.Display();

        //read code
        Console.WriteLine("Welcome to the Journal Program!");
        String choice;
        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            if (choice == "1")
            {

            }
            else if (choice == "2")
            {
                //create an entry object to pass to the journal for storage
            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            Console.WriteLine();
        }
        while (choice != "5");
    }
}