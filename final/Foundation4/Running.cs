public class Running : Activity {
  private Double _distance;

  public Running(DateOnly date, int minutes, Double distance) : base(date, minutes){
    _distance = distance;
  }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        Double result = GetMinutes()/ _distance;
        return result;
      
    }

    public override double GetSpeed()
    {
         Double timeSpent = _distance / GetMinutes();
         Double result = timeSpent * 60;
         return result;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetMinutes()} min) - Distance: {GetDistance()}, Speed: {GetSpeed()} mph, Pace:{GetPace()} min per mile";
    }
}