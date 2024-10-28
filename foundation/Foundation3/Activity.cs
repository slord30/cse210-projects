using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{
    protected string _date;
    protected string _activityName;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

       public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        string summary = $"{_date} {_activityName} ({_minutes}) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        return summary;
    }
}