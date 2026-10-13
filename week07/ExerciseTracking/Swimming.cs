
public class Swimming : Activity
{
    private int _laps;
    private float _poolLength;

    public Swimming(
        int laps,
        float poolLength,
        DateTime dateTime,
        int duration)
        : base(0, 0, 0, dateTime, duration)
    {
        _laps = laps;
        _poolLength = poolLength;
    }

    public override float Distance()
    {
        return (_laps * _poolLength) / 1609.34f;
    }

    public override float Speed()
    {
        return Distance() / GetDuration() * 60;
    }

    public override float Pace()
    {
        return GetDuration() / Distance();
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}
