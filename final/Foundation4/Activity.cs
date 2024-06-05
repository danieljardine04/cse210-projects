using System.Diagnostics.Contracts;

public abstract class Activity {
  private DateOnly _date;
  int _minutes; 

  public Activity(DateOnly date, int minutes){
    _minutes = minutes;
    _date = date;
  }

  public int GetMinutes(){
    return _minutes;
  }

  public DateOnly GetDate(){
    return _date;
  }

  public abstract String GetSummary();

  public abstract Double GetDistance();

  public abstract Double GetSpeed();
  
  public abstract Double GetPace();

}