using System.Runtime.CompilerServices;
using System.Xml.XPath;

public class Product{
  private int _id;
  private String _name;
  private Double _price;
  private int _quantity;

  public Product(int id, String name, Double price, int quantity){
    _id = id;
    _name = name;
    _price = price;
    _quantity = quantity;
  }

  public double getPrice(){
    double result = _price * _quantity;
    return result; 
  }

  public String GetName(){
    return _name;
  }
  public int GetId(){
    return _id;
  }
}