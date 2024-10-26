using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest Goal Tracking App");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}