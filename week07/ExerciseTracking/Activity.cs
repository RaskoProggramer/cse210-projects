public abstract class Activity
{
    private float _distance;
    private float _speed;
    private float _pace;
    private DateTime _dateTime;
    private int _duration;

    public Activity(float distance, float speed, float pace, DateTime dateTime, int duration)
    {
        _distance = distance;
        _speed = speed;
        _pace = pace;
        _dateTime = dateTime;
        _duration = duration;
    }

    public abstract float Distance();
    public abstract float Speed();
    public abstract float Pace();
    public abstract string GetActivityName();
    public float GetDistance()
    {
        return _distance;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }

    public void GetSummary()
    {
        Console.WriteLine(
            $"{GetDateTime():dd MMM yyyy} {GetActivityName()} " +
            $"({GetDuration()} min) - " +
            $"Distance: {Distance():0.0} miles, " +
            $"Speed: {Speed():0.0} mph, " +
            $"Pace: {Pace():0.0} min per mile"
        );
    }
}