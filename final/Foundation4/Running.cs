using System;
public class Running : Activity
{
    private double distance;

    public Running(DateTime date, double time, double distance) : base(date, time)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return this.distance;
    }

    public override double GetSpeed()
    {
        return (this.distance / this.time) * 60;
    }

    public override double GetPace()
    {
        return this.time / this.distance;
    }
}