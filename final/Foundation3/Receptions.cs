public class Receptions : Event {
  private String _email;

  public Receptions(String eventTitle, String description, String date, String time, String type, Address address, String email) : base(eventTitle, description, date, time, type, address){
    _email = email;
  }

  public override void GetFullDetails(){
    Console.WriteLine($"Email to RSVP: {_email}");
    StandardDetails();
  }
}