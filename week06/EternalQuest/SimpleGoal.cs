public class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {

        if (! _isComplete)
        {
            _isComplete = true;
            return GetPoints();
        }
        return 0;
    }
    public override string GetDetailsString()
    {
        string status = _isComplete ? "X" : " ";
        return $"[{status}] {GetName()} ({GetPoints()} points)";
    }

    public override string GetStringRepresentation()
    {
     
        return $" SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete} ";  
    }

}