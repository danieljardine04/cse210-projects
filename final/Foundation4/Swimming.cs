public class Swimming : Activity {

  int _numberLaps;

  public Swimming(DateOnly date, int minutes, int numberLaps) : base(date, minutes){
    _numberLaps = numberLaps;
  }

  public override Double GetDistance(){
    int lapDistance = _numberLaps * 50;
    Double miles = 1000 * 1.62;
    double result = lapDistance / miles;
    return result;
  }

    public override Double GetPace(){
      return GetMinutes() / GetDistance();
    }

    public override Double GetSpeed(){
        Double Pace = GetDistance() / GetMinutes();
        Double result = Pace * 60;
        return result;
    }

    public override string GetSummary(){
      String result = $"{GetDate()} Swimming ({GetMinutes()} min) - Distance: {GetDistance()}, Speed: {GetSpeed()} mph, Pace:{GetPace()} min per mile";
      return result; 
    }

}