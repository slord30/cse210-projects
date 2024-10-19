using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //Getter
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());  
        Console.Clear();
        Console.WriteLine("Get Ready...");  
        ShowSpinner(5);   
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5); 
        Console.Clear();     
    }

    public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);



        while (DateTime.Now < endTime)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(seconds - i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
        }
    }
}