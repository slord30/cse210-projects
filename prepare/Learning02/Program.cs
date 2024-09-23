using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Office Manager";
        job1._company = "Lord Family Dentistry";
        job1._startYear = 2019;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Web Designer";
        job2._company = "Sarah Lord Graphic Design";
        job2._startYear = 2008;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Sarah Lord";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}