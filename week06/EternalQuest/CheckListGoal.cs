public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, 
                        int points, int target, int bonus) : base (name, description, points)
    {
         _amountCompleted = 0;
         _target = target;
         _bonus = bonus;
    }

    public CheckListGoal(string name, string description, 
                        int points, int target, int bonus, int amountCompleted) : base (name, description, points)
    {
         _amountCompleted = amountCompleted;
         _target = target;
         _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    } 
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        
        _amountCompleted++;
        int earned = GetPoints();

        if (_amountCompleted == _target)
            {
                earned += _bonus;
            }
            return earned;
          
    }
    public override string GetDetailsString()
    
    {
        string status = IsComplete() ? "X" : " ";
        
        return $"[{status}] {GetName()} ({GetPoints()} points) " +
         $"Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        
        return $" CheckListGoal:{GetName()}|{GetDescription()}|" + $"{GetPoints()}|{_target}|{_bonus}|{_amountCompleted} ";
         
    }
}