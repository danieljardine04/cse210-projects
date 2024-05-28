using System.Diagnostics.Contracts;

public class SimpleGoal : Goal {
  private Boolean _isComplete;

  public SimpleGoal(String name, String description, int points) :base(name, description, points){

  }

    public override int RecordEvent(){
      _isComplete = true;
       
      return  GetPoints();
    }

    public override Boolean IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        String result = $"SimpleGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
        return result;
    }
}