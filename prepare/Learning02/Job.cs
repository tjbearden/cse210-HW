using System;

public class Job
{   
    public string _company;
    public string _JobTitle;
    public string _StartYear;
    public string _EndYear;

    public void Display()
    {
        Console.WriteLine($"{_JobTitle} ({_company}) {_StartYear}-{_EndYear}");
       

        }

}

