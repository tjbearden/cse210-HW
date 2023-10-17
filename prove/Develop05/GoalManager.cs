public class GoalManager
{
    private List<Goal> _goals;
    private int _pointTotal;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _pointTotal = 0;
    }
    public List<Goal> GetGoals(){
        return _goals;
    }
    public void SetGoals(List<Goal> goals){
        _goals = goals;
    }
    public int GetPointTotal(){
        return _pointTotal;
    }
    public void SetPointTotal(int pointTotal){
        _pointTotal = pointTotal;
    }
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;

            SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
            GetGoals().Add(simpleGoal);
        }

        else if (choice == 2)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;

            EternalGoal eternalGoal = new EternalGoal(name, description, basePoints);
            GetGoals().Add(eternalGoal);
        }

        else if (choice == 3)
        {
            Tuple<string, string, int> userInput = GetUserInput();
            string name = userInput.Item1;
            string description = userInput.Item2;
            int basePoints = userInput.Item3;
            Console.Write("How many times does this goal need to be accomplished?");
            int timesRequired = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for completing it that many time?");
            int bonusPoints = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, basePoints, bonusPoints, timesRequired);
            GetGoals().Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Incorrect choice. Trying again!");
        }
    }

    private Tuple<string, string, int> GetUserInput()
    {
        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        int basePoints = int.Parse(Console.ReadLine());
        return new Tuple<string, string, int>(name, description, basePoints);
    }

    public void ListGoals()
    {
        Console.WriteLine("\nThe goals are:");
        int lineNumber = 1;
        foreach (Goal goal in GetGoals())
        {
            Console.WriteLine($"{lineNumber}. {goal.GetInfo()}");
            lineNumber++;
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(GetPointTotal());
            
            foreach (Goal goal in GetGoals())
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine($"**********- Load from '{fileName}' -**********"); 
       
        // GetGoals().Clear();
       _pointTotal = int.Parse(lines[0]);

        foreach (string line in lines.Skip(1)) 
        {
            string[] parts = line.Split("|");
            string type = parts[0];
            // string details = parts[1];
            string name = parts[1];
            string description = parts[2];
            int basePoints = int.Parse(parts[3]);    
            
            if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, basePoints);
                simpleGoal.SetIsComplete(bool.Parse(parts[4]));
                _goals.Add(simpleGoal);
                Console.WriteLine(GetGoals());
                Console.WriteLine($"Point Total: {_pointTotal}");
                Console.WriteLine($"{name} - {description} - {basePoints} " );   
            }

            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, basePoints);
                _goals.Add(eternalGoal);
                Console.WriteLine($"Point Total: {_pointTotal}");
                Console.WriteLine($"{name} - {description} - {basePoints}");  
            }

            else if (type == "ChecklistGoal")
            {
                int bonusPoints = int.Parse(parts[4]);
                int timesRequired = int.Parse(parts[5]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, basePoints, bonusPoints, timesRequired);
                checklistGoal.SetTimesCompleted(int.Parse(parts[6]));
                _goals.Add(checklistGoal);
            }
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe goals are:");
        int lineNumber = 1;
        foreach (Goal goal in GetGoals())
        {
            Console.WriteLine($"{lineNumber}. {goal.GetName()}");
            lineNumber++;
        }

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        int pointsReceived = GetGoals()[goalNumber].CompleteGoal();
        _pointTotal += pointsReceived;
        
        if (pointsReceived == 0){
            Console.WriteLine("This goal is already completed. You have earned 0 points.");
        }
        else{
            Console.WriteLine($"Congratulations! You have earned {pointsReceived} points!");
        }        
        Console.WriteLine($"You now have {GetPointTotal()} points.");
    }
}