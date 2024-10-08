using System;

class Program
{
  static void Main(string[] args)
  {
    Journal journal = new Journal();
    bool isRunning = true;

    Console.WriteLine("Welcome to the Journal Program!");

    while (isRunning)
    {
      Console.WriteLine("\nJournal App Menu:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");

      Console.Write("Please select one of the following choices: ");
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          string prompt = PromptGenerator.GetRandomPrompt();
          Console.WriteLine($"Prompt: {prompt}");
          Console.Write("Enter your response: ");
          string response = Console.ReadLine();
          journal.AddEntry(prompt, response);
          break;


        case "2":
          if (journal.EntriesCount() == 0)
          {
              Console.WriteLine("The journal is empty. Add some entries first.");
          }
          else
          {
              journal.DisplayEntries();
          }
          break;

        case "3":
          Console.Write("Enter the file name to load: ");
          string loadFileName = Console.ReadLine();
          journal.LoadFromFile(loadFileName);
          Console.WriteLine("Journal loaded successfully.");
          break;

        case "4":
          Console.Write("Enter the file name to save: ");
          string saveFileName = Console.ReadLine();
          journal.SaveToFile(saveFileName);
          Console.WriteLine("Journal saved successfully.");
          break;

        case "5":
          isRunning = false;
          break;

        default:
          Console.WriteLine("Invalid choice. Please select a valid option (1-5).");
          break;
      }
    }
  }
}