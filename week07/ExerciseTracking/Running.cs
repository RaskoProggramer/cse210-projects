class Running : Activity
{
    public Running(float distance, DateTime dateTime, int duration) : base(distance, 0, 0, dateTime, duration){

    }
    public override float Distance()
    {
        return GetDistance();
    }

    public override string GetActivityName()
    {
        return "Running";
    }

    public override float Pace()
    {
        return GetDuration() / Distance();
    }

    public override float Speed()
    {
        return Distance() / GetDuration() * 60;
    }
}