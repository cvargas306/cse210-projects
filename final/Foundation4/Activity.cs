using System;
public abstract class Activity
{
    protected DateTime date;
    protected double time;

    public Activity(DateTime date, double time)
    {
        this.date = date;
        this.time = time;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({time} min) - Distance: {GetDistance()} units, Speed: {GetSpeed()} units per hour, Pace: {GetPace()} min per unit";
    }
}