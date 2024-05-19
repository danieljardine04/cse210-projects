using System.Dynamic;

public class ListingActivity : Activity {
  private int _count;
  private List<String> _prompts;

  public ListingActivity(String name, String description, int duration, int count, List<String> prompts) : base(name, description, duration){
    _count = count;
    _prompts = prompts;
  }

  public void Run(){
    Console.Clear();
    GetRandomPrompt();
    GetListFromUser();
    Console.WriteLine($"You were able to list {_count} items");
    Thread.Sleep(3000);
    DisplayEndingMessage();
  }

  public void GetRandomPrompt(){
    Random rand = new Random();
    int randomPrompt = rand.Next(_prompts.Count);
    String chosenPrompt = _prompts[randomPrompt];
    Console.WriteLine(chosenPrompt);
  }
  
  public List<String> GetListFromUser(){
    List<String> result = new List<String>();
    int duration = GetDuration();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);
    Console.WriteLine("List as many items as you can.");
    while(endTime > DateTime.Now){
      String newItem = Console.ReadLine();
      result.Add(newItem);
      _count++;
    }
    return result;
  }
}