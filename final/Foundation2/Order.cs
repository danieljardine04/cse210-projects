using System.Xml.XPath;

public class Order{
  private List<Product> _products = new List<Product>();
  private Customer _customer;

  public Order(Customer customer){
    _customer = customer;
  }

  public Double totalCost(){
    Double result = 0.00;
    foreach(Product product in _products){
      result += product.getPrice();
      
    }
    if(_customer.liveUSA()){
      result += 5;
    } else {
      result += 35;
    }
    return result;
  }

  public String getPackingLabel(){
    String packingLabel = "";
    foreach(Product product in _products){
      String pName = product.GetName();
      int pId = product.GetId();
      packingLabel += $"product id: {pId}, product Name: {pName} \n";

    }
    return packingLabel;
  }

  public String getShippingLabel(){
    return $"{_customer.GetName()} \n {_customer.GetAddress()}";
  }

  public void addItem(Product product){
    _products.Add(product);
  }

}