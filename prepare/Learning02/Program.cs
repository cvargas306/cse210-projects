using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "BYU";
        job1._startYear = 2018;
        job1._endYear = 2022;

        Job job2 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Intel";
        job1._startYear = 2020;
        job1._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Carlos Vargas";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}