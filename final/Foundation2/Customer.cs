public class Customer{
  private String _name;
  private Address _address;


public Customer(String name, Address address){
  _name = name;
  _address = address;

}

public Boolean liveUSA(){
  Boolean result = _address.isUSA();
  return result;

}

public String GetName(){
  return _name;
}

public String GetAddress(){
  return _address.GetCompleteAddress();
}

}
