
using System;

class Program
{
    static void Main(string[] args)
     {
        Console.Write("Who was the most interesting person I interacted with today?");
        string question1 = Console.ReadLine();

        Console.Write("What was the best part of my day?");
        string question2 = Console.ReadLine();

        Console.Write("How did I see the hand of the Lord in my life today?");
        string question3 = Console.ReadLine();

        Console.Write("What was the strongest emotion I felt today?");
        string question4 = Console.ReadLine();

        Console.Write("If I had one thing I could do over today, what would it be?");
        string question5 = Console.ReadLine();

        Console.Write("Did you read your scriptures today?");
        string question6 = Console.ReadLine();

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();


        Console.WriteLine($"Your name is {theCurrentTime} {question1} {question2}.");
    }
}

