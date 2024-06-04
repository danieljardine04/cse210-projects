public class Lectures : Event {
  
  private String _speakerName;
  private int _capacity;

  public Lectures(String eventTitle, String description, String date, String time, String type, Address address, String speakerName, int capacity) : base(eventTitle, description, date, time, type, address){
    _speakerName = speakerName;
    _capacity = capacity;
  }

  public override void GetFullDetails(){
    Console.WriteLine($"Speaker: {_speakerName}");
    Console.WriteLine($"Capacity: {_capacity}");
    StandardDetails();
  }
}