class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool complete = false) : base(shortName, description, points)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine("Goal Complete");
        }
        else
        {
            Console.WriteLine("This Goal is Already Complete.");
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        string status = _isComplete ? "[X]" : "[ ]";

        return $"{status} {GetShortName()} - {GetDescription()}";
    }
    
}