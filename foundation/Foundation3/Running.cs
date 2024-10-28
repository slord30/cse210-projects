using System;

public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, int distance) : base (date, minutes)
    {
        _activityName = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = Math.Round((_distance / _minutes) * 60, 2);
        return speed;
    }

    public override double GetPace()
    {
        double pace = Math.Round(_minutes / GetSpeed(), 2);
        return pace;
    }
}