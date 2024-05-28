using System.Diagnostics.Contracts;

public abstract class Goal {
  private String _shortName;
  private String _description;
  private int _points;

  public Goal(String name, String description, int points){
    _shortName = name;
    _description = description;
    _points = points;
  }
  
  public String GetName(){
    return _shortName;
  }
  public String GetDescription(){
    return _description;
  }

  public int GetPoints(){
    return _points;
  }

  public abstract int RecordEvent();

  public abstract Boolean IsComplete();

  public virtual String GetDetailsString(){
    return _description;
  }
  public abstract String GetStringRepresentation();
}