class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _targets;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus, int amount = 0) : base(name, description, points)
    {
        _targets = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _targets;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override string GetStringRepresentation()
    {
        string status = IsComplete() ? "[X]" : "[ ]";

        return $"{status} {GetShortName()} - {GetDescription()}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _targets;
    }

    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;

            if (_amountCompleted == _targets)
            {
                Console.WriteLine($"You earned a bonus of 🌟🌟{_bonus}🌟🌟 points!");
            }
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
        }
    }

    public string GetDetailsString()
    {
        return $"{GetStringRepresentation()} -- Completed {_amountCompleted}/{_targets} times";
    }
}