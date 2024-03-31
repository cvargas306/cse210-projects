public class EternalGoal : Goal
{

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        SetScore(Points);
    }

    public override bool IsComplete()
    {
        
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetDetailsList()}";
    }
}
