using System.Xml.XPath;

public class Rectangle : Shape {
  private double _length;
  private double _width;

  public Rectangle(String color, Double length, Double width) : base(color){
    _length = length;
    _width = width;
  }

    public override double GetArea()
    {
      Double result = _length * _width;
      return result;
        
    }
}