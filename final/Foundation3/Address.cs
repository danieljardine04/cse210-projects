public class Address {
  private String _street;
  private String _city;
  private String _state;
  private int _zip;

  public Address(String street, String city, String state, int zip){
    _street = street;
    _city = city;
    _state = state;
    _zip = zip;
  }


  public String GetCompleteAddress(){
    return $"{_street} \n {_city} {_state}, {_zip}";
  }

}