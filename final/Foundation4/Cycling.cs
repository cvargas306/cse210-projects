using System;
public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, double time, double speed) : base(date, time)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (this.speed * this.time) / 60;
    }

    public override double GetSpeed()
    {
        return this.speed;
    }

    public override double GetPace()
    {
        return 60 / this.speed;
    }
}