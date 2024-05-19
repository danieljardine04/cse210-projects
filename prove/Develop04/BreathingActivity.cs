public class BreathingActivity : Activity{

  public BreathingActivity(String name, String description, int duration) : base(name, description, duration){}

  public void Run(){
    int duration = GetDuration();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while(DateTime.Now < endTime){
        Console.Write("Breathe in...");
        ShowCountDown(4);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountDown(6);
        Console.WriteLine();
      }
      DisplayEndingMessage();
    }
  }
