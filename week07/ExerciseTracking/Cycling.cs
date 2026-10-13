class Cycling : Activity
{
    public Cycling(float distance, DateTime dateTime, int duration) : base(distance, 0, 0, dateTime, duration){

    }

    public override float Distance()
    {
        return GetDistance();
    }

    public override string GetActivityName()
    {
        return "Stationary Cycling";
    }

    public override float Pace()
    {
        return 60 / Speed();
    }

    public override float Speed()
    {
        return Distance()/ GetDuration() * 60;
    }
}