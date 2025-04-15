using System;
public class Running : Activity
{
    private double _distanceKilometers;
    public Running(string date, int duration, double distanceKilometers) : base(date, duration)
    {
        _distanceKilometers = distanceKilometers;
    }
    public override double GetDistance()
    {
        return _distanceKilometers;
    }
    public override double GetSpeed()
    {
        double _durationHours = _duration / 60.0;
        return _distanceKilometers / _durationHours;
    }
    public override double GetPace()
    {
        return _duration / _distanceKilometers;
    }
}
