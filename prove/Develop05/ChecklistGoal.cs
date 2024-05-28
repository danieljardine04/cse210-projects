public class CheckListGoal : Goal {

  private int _amountCompleted;
  private int _target;
  private int _bonus;

  public CheckListGoal(String name, String description, int points, int target, int bonus) :base(name, description, points){
    _target = target;
    _bonus = bonus;
  }

  public void SetAmountCompleted(int amountCompleted){
    _amountCompleted = amountCompleted;
  }

    public override int RecordEvent()
    {
      int amount = GetPoints();
      _amountCompleted++;
      if(IsComplete()){
        amount += _bonus;
      }
     return amount;
      }

    public override Boolean IsComplete()
    {
        if(_amountCompleted >= _target){
          return true;
        }
        else {
          return false;
        }
    }

    public override String GetDetailsString(){
      String result = $"Currently completed: {_amountCompleted}/{_target}";
      return result;

    }
    public override String GetStringRepresentation()
    {
        String result = $"CheckListGoal: {GetName()}, {GetDescription()}, {GetPoints()}, {_target}, {_bonus}, {_amountCompleted}";
        return result;
    }
   
    }


