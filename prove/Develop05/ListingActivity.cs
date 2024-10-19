using System;
using System.Diagnostics;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"************** {GetRandomPrompt()} **************");
        Console.Write("You may being in: ");
        ShowCountDown(5);
        Console.WriteLine();
        GetListFromUser();
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        _count = 0;      
       
        while (DateTime.Now < endTime)
        { 
            Console.Write("> ");
            string listResponse = Console.ReadLine();
            _count = _count + 1;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
}