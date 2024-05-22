public abstract class Shape {
  private string _color;
  
  public String getColor(){
    return _color;
  }

  public void setColor(String color){
    _color = color;
  }

  public Shape(String color){
    _color = color;
  }

  public abstract Double GetArea();
}