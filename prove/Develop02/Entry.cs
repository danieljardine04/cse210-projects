public class Entry {
  public String prompt;
  public String message;
  public String timeOfMessage;

  public void DisplayMessage(){
    Console.WriteLine($"{prompt}: {message} {timeOfMessage}");
  }

  
}