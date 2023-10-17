public class SimpleGoal : Goal
{
   private bool _isComplete;
    public SimpleGoal(string name, string description, int basePoints):base(name, description, basePoints)
    {
        _isComplete = false;
    }
    public bool GetIsComplete(){
        return _isComplete;
    }
    public void SetIsComplete(bool isComplete){
        _isComplete = isComplete;
    }
    public override int CompleteGoal()
    {
        if (GetIsComplete())
        {
            return 0;
        }
        else
        {
            _isComplete = true;
            return GetBasePoints();
        }
    }
    public override string GetInfo()
    {
        string checkMark = " ";
        if (GetIsComplete())
        {
            checkMark = "X";
        }
        return $"[{checkMark}] {GetName()} ({GetDescription()})";
    }

    public override string Serialize()
    {
        return $"SimpleGoal | {GetName()} | {GetDescription()} | {GetBasePoints()} | {GetIsComplete()}";
    }

}