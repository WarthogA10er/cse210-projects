using System.ComponentModel;

public class ChecklistGoal:Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string isComplete, string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;

        if(isComplete == " ")
        {
            _isComplete = false;
        }

        else if(isComplete == "X")
        {
            _isComplete = true;
        }
    }
    public override int RecordEvent()
    {
        int bonus = 0;
        _amountCompleted += 1;
        if(_amountCompleted == _target)
        {
            bonus = _bonus;
        }
        return (_points + bonus);
    }

    public override string IsComplete()
    {
        string completion = " ";
        if (_amountCompleted >= _target)
        {
            _isComplete = true;
        }

        if(_isComplete == true)
        {
            completion = "X";
        }
        return completion;
    }

    public override string GetDetailsString()
    {
        return ($"[{IsComplete()}] {_shortName}, {_points} [{_amountCompleted}/{_target}]");
    }

    public override string GetStringRepresentation()
    {
        string representation = ($"ChecklistGoal:{IsComplete()}|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}");
        return representation;
    }
}
