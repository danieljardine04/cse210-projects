using System.Xml.XPath;

public class Circle : Shape {
  private double _radius;
  
  public Circle(String color, Double radius) :base(color){
    _radius = radius;
  }

    public override double GetArea()
    {
      Double result = _radius * 2 * Math.PI;
      return result;
      
    }
}