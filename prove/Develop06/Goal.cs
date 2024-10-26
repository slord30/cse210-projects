using System;

public abstract class Goal
{   
    private string _goalType;
    private string _goalName;
    private string _description;
    private int _points;

    //Constructor
    public Goal(string type, string name, string description, int points)
    {
        _goalType = type;
        _goalName = name;
        _description = description;
        _points = points;
    }

    //Getters
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    //Methods//

    //method should do whatever is necessary for each kind of goal
    //mark a simple goal complete
    //adding the number of times a checklist goal has been completed
    //return the point value associated with recording the event (also bonus)
    public abstract void RecordEvent(List<Goal> goals);
 
    //method should return true if goal is complete.
    //different for each type of goal
    public abstract bool IsComplete();

    //method returns the details of a goal that is shown in a list.
    //include checkbox, the short name, description
    //checklist goal should be overridden to show # of times the goal has been accomplished so far
    // public virtual string GetGoalDetailsString()
    // {
    //     return $"[ ] {_goalName} - {_description}";
    // }

    //method should provicde all of the details of a goal in a way that is easy to save to file, and then load later
    public abstract string GetStringRepresentation();

    public abstract void ListGoal(int i);

}