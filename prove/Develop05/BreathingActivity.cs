using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int seconds = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int breatheTime = 6;

        do {
            Console.Write("\nBreathe IN...");
            ShowCountDown(breatheTime);
            Console.Write("Now breath OUT...");
            ShowCountDown(breatheTime);
            Console.WriteLine();
        }
        while (DateTime.Now < endTime);

        DisplayEndingMessage();
    }
}
