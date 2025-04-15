public abstract class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration){
        _date = date;
        _duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary(){
        return $"{_date}, {this.GetType().Name} for ({_duration} min): Distance {GetDistance()}, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km ";
    } 
}