public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
       
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            SetScore(Points);
            if (_amountCompleted == _target)
            {
                SetScore(_bonus); // Bonus points on achieving the desired completions
            }
        }
        else 
        {
            Console.WriteLine("Goal is completed.");
        }      
    }

    public override bool IsComplete()
    {
        // Implement check for completion of checklist goal
        return _amountCompleted == _target;
    }

    public override string GetDetailsList()
    {
        return $"{base.GetDetailsList()} - Completed {_amountCompleted}/{_target} times {ProgressBar()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{base.GetDetailsList()},{_target},{_bonus}";
    }

    public string ProgressBar()
    {
        string progress = "[";
        for (int i=0; i <= _target; i++)
        {
            if (i< _amountCompleted)
            progress += "■";
            else {
                progress += " ";
            }
        }
        progress += "]";
        progress += $"{_amountCompleted * 100 / _target}%";
        return progress;

    }
}
