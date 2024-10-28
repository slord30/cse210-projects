using System;

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base (date, minutes)
    {
        _activityName = "Swimming";
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = Math.Round(_laps * 50 / 1000 * 0.62, 2);
         return distance;
    }

    public override double GetSpeed()
    {
        double speed = Math.Round(GetDistance() / _minutes * 60, 2);
        return speed;
    }

    public override double GetPace()
    {
        double pace = Math.Round(_minutes / GetDistance(), 2);
        return pace;
    }
}