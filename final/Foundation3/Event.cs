public abstract class Event{
  private String _eventTitle;
  private String _description;
  private String _date;
  private String _time;
  private String _type;
  private Address _address;

  public Event(String eventTitle, String description, string date, string time, string type, Address address){
    _eventTitle = eventTitle;
    _description = description;
    _date = date;
    _time = time;
    _type = type;
    _address = address;
  }

  public void StandardDetails(){
    Console.WriteLine(_eventTitle);
    Console.WriteLine(_description);
    Console.WriteLine($"Date: {_date}");
    Console.WriteLine($"Time: {_time}");
    Console.WriteLine();
    Console.WriteLine("Address: ");
    Console.WriteLine(_address.GetCompleteAddress());
  }

  public void ShortDescription(){
    Console.WriteLine($"Event Type: {_type}");
    Console.WriteLine(_eventTitle);
    Console.WriteLine($"Date: {_date}");
  }

  public abstract void GetFullDetails();

}

  