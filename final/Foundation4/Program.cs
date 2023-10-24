using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities =  new List<Activity>();
        activities.Add(new Running("1 Nov 2023",13,180));
        activities.Add(new Cycling("2 Nov 2023",14,120));
        activities.Add(new Swimming("3 Nov 2023",102,150));

        int index = 1;
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\nACTIVITY N°{index}:\n{activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();    
    }
}