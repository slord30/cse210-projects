using System;

public class EternalGoal : Goal
{
    private string _goalType = "Eternal Goal:";
    private bool _isComplete;

    //constructor
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }

    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _isComplete = status;
    }


    //Methods
    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetDescription()})");
    }
    public override void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    //method should return true if goal is complete.
    //different for each type of goal
    public override bool IsComplete()
    {
        return false;
    }

    //method should provicde all of the details of a goal in a way that is easy to save to file, and then load later
    public override string GetStringRepresentation()
    {
        return $"{_goalType} | {GetGoalName} | {GetDescription} | {GetPoints} | {IsComplete}";
    }


}