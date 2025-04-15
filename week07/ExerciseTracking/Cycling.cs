public class Cycling : Activity 
{
    private double  _speedKmH;
    public Cycling( string date, int duration, double speedKmH) : base(date, duration)
    {
        _speedKmH = speedKmH;

    }

    public override double GetDistance()
    {
        double _durationHours = _duration / 60.0;
        return _speedKmH * _durationHours;
    }
    public override double GetSpeed()
    {
        return _speedKmH;
    }
    public override double GetPace()
    {
        return _duration / GetDistance();
    }
}