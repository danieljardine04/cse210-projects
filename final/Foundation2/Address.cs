public class Address{
  private String _street;
  private String _city;
  private String _state;
  private String _country;

  public Address(String street, String city, String state, String country){
    _street = street;
    _city = city;
    _state = state;
    _country = country;
  }

  public Boolean isUSA(){
    Boolean result = false;
    if(_country.ToLower() == "usa" || _country == "United States of America"){
      result = true;
      return result;
    }
    return result;
  }

  public String GetCompleteAddress(){
    String result = $"{_street} \n {_city} {_state} \n {_country}";
    return result;

  }
}