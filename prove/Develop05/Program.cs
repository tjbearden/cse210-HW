using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("You have {goalManager.GetPointTotal()} points.");
            Console.WriteLine("Menu Options:");
 
            Console.WriteLine("  1. List Goals");
            Console.WriteLine("  2 Save Goals ");
            Console.WriteLine("  3. Load Goals");
            Console.WriteLine("  4. Create New Goal");
            Console.WriteLine("  5. Record Event ");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if 
            
            (choice == 1)
            {
                goalManager.ListGoals(); 
            }

            else if (choice == 2)
            {
                goalManager.SaveGoals();
            }

            else if (choice == 3)
            {
                goalManager.LoadGoals();
            }

            else if (choice == 4)
            {
            goalManager.CreateGoal();
            }

            else if (choice == 5)
            {
                goalManager.RecordEvent();
            }
        } 
    }
}