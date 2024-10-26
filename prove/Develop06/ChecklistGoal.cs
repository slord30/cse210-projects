using System;
using System.Net;
using System.Reflection;

public class ChecklistGoal : Goal
{
    private string _goalType = "Checklist Type:";
    private int _amountCompleted;
    private int _bonus;
    private int _target;
    private bool _isComplete;


    //Constructors
    public ChecklistGoal(string type, string name, string description, int points, int amountCompleted, int bonus) : base(type, name, description, points)
    {
        _isComplete = false;
        _amountCompleted = amountCompleted;
        _bonus = bonus;
        _target = 0;
    }

    public ChecklistGoal(string type, string name, string description, int points, bool status, int bonus, int target, int amountCompleted) : base(type, name, description, points)
    {
        _isComplete = status;
        _amountCompleted = amountCompleted;
        _bonus = bonus;
        _target = target;
    }

    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget()
    {
        _target += _target;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountCompleted()
    {

    }
    public int GetBonus()
    {
        return _bonus;
    }

    //Methods
    public override void ListGoal(int i)
    {
        if (IsComplete() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName} ({GetDescription}) -- Currently Completed: {GetAmountCompleted}/{GetTarget}");
        }
        else if (IsComplete() == true)
        {
            Console.WriteLine($"{i}. [X] {GetGoalName} ({GetDescription}) -- Completed: {GetAmountCompleted}/{GetTarget}");
        }
    }

    public override void RecordEvent(List<Goal> goals)
    {
        SetTarget();
        int points = GetPoints();

        if (_target == _amountCompleted)
        {
            _isComplete = true;
            points = points + _bonus;

            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints} points!");
        }
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
        return $"{_goalType} | {GetGoalName} | {GetDescription} | {GetPoints} | {GetBonus} | {GetAmountCompleted()} | {IsComplete()}";
    }

    //method returns the details of a goal that is shown in a list.
    //checklist goal should be overridden to show # of times the goal has been accomplished so far
    // public override string GetGoalDetailsString()
    // {
    //     return $"{_goalType}| {_goalName} - {_description} -- Progress status {GetAmountCompleted()}/{_target}";
    // }

}