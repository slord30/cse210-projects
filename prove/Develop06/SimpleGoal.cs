using System;
using System.ComponentModel;

public class SimpleGoal : Goal
{
    private string _goalType = "Simple Goal:";
    private bool _isComplete;

    //constructor
    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _isComplete = status;
    }


    //Methods
    public override void ListGoal(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetDescription()})");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetGoalName()} ({GetDescription()})");
        }
    }
    public override void RecordEvent(List<Goal> goals)
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()}!");
    }

    //method should return true if goal is complete.
    //different for each type of goal
    public override bool IsComplete()
    {
        return _isComplete;
    }

     //method should provicde all of the details of a goal in a way that is easy to save to file, and then load later
    public override string GetStringRepresentation()
    {
        return $"{_goalType} | {GetGoalName()} | {GetDescription} | {GetPoints} | {IsComplete()}";
    }
}