public class EternalGoal : Goal
{
     public EternalGoal(string name, string description, int basePoints): base(name, description, basePoints)
    {
    }
    public override int CompleteGoal()
    {
        return GetBasePoints();
    }
    public override string GetInfo()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }
    public override string Serialize()
    {
        return $"EternalGoal | {GetName()} | {GetDescription()} | {GetBasePoints()}";
    }
}