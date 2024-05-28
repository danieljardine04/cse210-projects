public class EternalGoal : Goal {

  public EternalGoal(String name, String description, int points) :base(name, description, points){}

    public override int RecordEvent()
    { 
        return GetPoints(); 
    }

    public override bool IsComplete()
    {
     Boolean result = false;
     return result; 
    }

    public override string GetStringRepresentation()
    {
       String result = $"EternalGoal: {GetName()}, {GetDescription()}, {GetPoints()}";
       return result;
    }

}