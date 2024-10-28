using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _activityName = "Cycling";
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = Math.Round(_speed * _minutes / 60, 2);
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = Math.Round(_minutes / _speed, 2);
        return pace;
    }
}