
class GoalData
{
    private string _type;
    private string _name;
    private string _description;
    private string _points;
    private bool _isComplete;
    private int _target;
    private int _bonus;
    private int _amountCompleted;

    public GoalData(string type, string name, string description, string points,
                    bool isComplete, int target, int bonus, int amountCompleted)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public string GetGoalType()
    {
        return _type;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
}