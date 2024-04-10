using System;
public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, double time, int laps) : base(date, time)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return this.laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / this.time) * 60;
    }

    public override double GetPace()
    {
        return this.time / GetDistance();
    }
}