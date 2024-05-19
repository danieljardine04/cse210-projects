using System.ComponentModel;

public class ReflectingActivity : Activity {
  private List<String> _prompts;
  private List<String> _questions;

  public ReflectingActivity(String name, String description, int duration, List<String> prompts, List<String> questions) :base(name, description, duration){
    _prompts = prompts;
    _questions = questions;
  }

  public void Run(){
    Console.Write("Get Ready...");
    ShowSpinner(5);
    DisplayPrompt();
    int duration = GetDuration();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    while(DateTime.Now < endTime){
      // TimeSpan t = endTime - DateTime.Now;
      // int secondsLeft = int.Parse((t.Seconds.ToString()));
      DisplayQuestions();
      ShowSpinner(10);
      Console.WriteLine();

    }
    DisplayEndingMessage();

  }

  public String GetRandomPrompt(){
    Random rand = new Random();
    int randomPrompt = rand.Next(_prompts.Count);
    String chosenPrompt = _prompts[randomPrompt];
    return chosenPrompt;
  }

  public String GetRandomQuestion(){
     Random rand = new Random();
    int randomQuestion = rand.Next(_questions.Count);
    String chosenQuestion = _questions[randomQuestion];
    return chosenQuestion;
  }

  public void DisplayPrompt(){
    Console.WriteLine("Consider the Following Prompt");
    Console.WriteLine();

    Console.WriteLine($"--- {GetRandomPrompt()} ---");
    Console.WriteLine();
    Console.WriteLine("When you have something in mind, press enter to continue.");
    Console.ReadLine();
  }

  public void DisplayQuestions(){
    Console.Write(GetRandomQuestion());
   
  }
}