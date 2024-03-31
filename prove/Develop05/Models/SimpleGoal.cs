public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        
        if (!_isComplete)
        {
            SetScore(Points);
            _isComplete = true;
        }
        else
        {
            Console.WriteLine("Event already recorded for this goal.");
        }
        
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetDetailsList()}";
    }

    public override string GetDetailsList()
    {
        string IsCompleteStr = IsComplete()?"[x]":"[]";
        return $"{base.GetDetailsList()} {IsCompleteStr}";
    }
}