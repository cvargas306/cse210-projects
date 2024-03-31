public abstract class Goal
{
    private string _shortName;
    private string _description;
    public int Points;

    private int _score;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        Points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsList()
    {
        return $"{_shortName},{_description},{Points}";
    }

    public abstract string GetStringRepresentation();

    public virtual string ShortName()
    {
        return _shortName;
    }

    public virtual int GetScore()
    {
        return _score;
    }

    public virtual void SetScore(int points)
    {
        _score += points;
    }
}