public class Cycling : Activity {
  private Double _speed;

  public Cycling(DateOnly date, int minutes, Double speed) : base(date, minutes){
    _speed = speed;
  }

    public override double GetDistance()
    {
        Double distance = _speed * GetMinutes();
        return distance/60;
    }

    public override double GetPace()
    {
        return 60/ _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min) - Distance: {GetDistance()}, Speed: {GetSpeed()} mph, Pace:{GetPace()} min per mile";
    }
}