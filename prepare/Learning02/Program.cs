using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._JobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._StartYear = 2019;
        job1._EndYear = 2022;

        Job job2 = new Job();
        job2._JobTitle = "Manager";
        job2._company = "Apple";
        job2._StartYear = 2022;
        job2._EndYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}