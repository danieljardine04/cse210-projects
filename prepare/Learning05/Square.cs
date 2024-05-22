public class Square : Shape {
  private double _side;

  public Square(String color, Double side) :base(color){
    _side = side;
  }

  public override double GetArea(){
    Double result = _side * _side;
    return result;
  }
}