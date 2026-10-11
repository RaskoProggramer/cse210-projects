class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {GetPoints()} 🌟 points for: {GetShortName()}");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"[ ] {GetShortName()} - {GetDescription()}";
    }
}