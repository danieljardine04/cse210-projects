public class OutdoorGatherings : Event {
  private String _weather;

  public OutdoorGatherings(String eventTitle, String description, String date, String time, String type, Address address, String weather) : base(eventTitle, description, date, time, type, address){
    _weather = weather;
  }

  public override void GetFullDetails(){
    Console.WriteLine($"Weather: {_weather}");
    StandardDetails();
  }
}