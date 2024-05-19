using System.Security.Cryptography.X509Certificates;

public class Activity{
  private String _name;
  private String _description;
  private int _duration;

  public Activity(String name, String description){
    _name = name;
    _description = description;
  }
  public Activity(String name, String description, int duration){
    _name = name;
    _description = description;
    _duration = duration;
  }

  public int GetDuration(){
    return _duration;
  }

  public String GetDescription(){
    return _description;
  }

  public void DisplayStartingMessage(){
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine($"This activity will {_description}");
    Console.WriteLine($"How long in seconds would you like this session to last? ");

  }

  public void DisplayEndingMessage(){
    Console.Write("Well Done!!");
    ShowSpinner(5);
    Console.WriteLine();
    Console.Write($"You have completed another {_duration} seconds of {_name}.");
    ShowSpinner(5);
    Console.WriteLine();

  }
  public void ShowSpinner(int seconds){
    List<String> animationStrings = new List<String>();
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    animationStrings.Add("|");
    animationStrings.Add("/");
    animationStrings.Add("-");
    animationStrings.Add("\\");
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;
    
    

    while(DateTime.Now < endTime){
      String s = animationStrings[i];
      Console.Write(s);
      Thread.Sleep(500);
      Console.Write("\b \b");
      i++;
      if(i >= animationStrings.Count){
        i = 0;
      }
    }  
      
    }
  public void ShowCountDown(int seconds){
    for(int i = seconds; i > 0; i--){
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }
  }

  }

  

