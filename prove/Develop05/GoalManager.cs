using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

public class GoalManager {
  private List<Goal> _goals = new List<Goal>();
  private int _score;

  public GoalManager(){}

  public void Start(){
    String[] menu = ["1. Create New Goal", "2. List Goals", "3. Save Goals", "4. Load Goals", "5. Record Event", "6. Quit"];
    String choice = "";
    while(choice != "6"){
      DisplayPlayerInfo();

      for(int i = 0; i < menu.Length; i++){
        Console.WriteLine($"  {menu[i]}");
      } 
      String answer = Console.ReadLine();

      switch(answer){
        default:
        Console.WriteLine("That was not a valid response please try again.");
        break;
        case "1":
        CreateGoal();
        break;
        case "2":
        ListGoalNames();
        break;
        case "3":
        SaveFile();
        break;
        case "4":
        LoadFile();
        break;
        case "5":
        RecordEvent();
        break;
        case "6":
        choice = answer;
        break;

      }
    }
    
  }
  public void DisplayPlayerInfo(){
    Console.WriteLine($"You have {_score} points");
    Console.WriteLine();
  }

  public void ListGoalNames(){
    foreach(Goal goal in _goals){
      if(goal.GetDetailsString() != null){
        Console.WriteLine($"[ ]{goal.GetName()} {goal.GetDescription()} -- {goal.GetDetailsString()}");

      } else
      if(goal.IsComplete()){
        
        Console.WriteLine($"[ X ]{goal.GetName()} {goal.GetDescription()}");
      }
      else {
        Console.WriteLine($"[  ] {goal.GetName()} {goal.GetDescription()}");

      }
    }
  }
  public void RecordEvent(){
    ListGoalNames();
    Console.WriteLine("Which event would you like to record? (Choose by the name of the Goal) ");
    String response = Console.ReadLine();
    foreach(Goal goal in _goals){
        if(goal.GetName() == response){
          int amount = goal.RecordEvent();
          _score += amount;
        }
    }
  }

  public void CreateGoal(){

    Console.WriteLine("Which type of Goal would you like to create? 1-3");
    Console.WriteLine("   1. Simple Goal");
    Console.WriteLine("   2. Eternal Goal");
    Console.WriteLine("   3. CheckList Goal");

    String answer = Console.ReadLine();

    switch(answer){
      default: 
      Console.WriteLine("That was not a valid response. Please choose a number between 1 and 3.");
      CreateGoal();
      break;
      case "1":

      Console.WriteLine("What is the name of your Simple goal? ");
      String simpleName = Console.ReadLine();
      Console.WriteLine("What is a short description of your goal?");
      String simpleDescription = Console.ReadLine();
      Console.WriteLine("How many points is your goal worth?");
      int simplePoints = int.Parse(Console.ReadLine());
      SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);

      _goals.Add(simpleGoal);
      break;

      case "2":

      Console.WriteLine("What is the name of your Eternal Goal? ");
      String eternalName = Console.ReadLine();
      Console.WriteLine("What is a short description of your eternal goal? ");
      String eternalDescription = Console.ReadLine();
      Console.WriteLine("How many points is this goal worth? ");
      int eternalPoints = int.Parse(Console.ReadLine());
      EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);

      _goals.Add(eternalGoal);
      break;

      case "3":

      Console.WriteLine("Whatis the name of your CheckList goal? ");
      String checkListName = Console.ReadLine();
      Console.WriteLine("What is a description of your CheckList Goal? ");
      String checkListDescription = Console.ReadLine();
      Console.WriteLine("How many points is this goal worth? ");
      int checkListPoints = int.Parse(Console.ReadLine());
      Console.WriteLine("How many times do you need to do this to complete your goal? ");
      int checkListTarget = int.Parse(Console.ReadLine());
      Console.WriteLine("What are the bonus points for completing the CheckList? ");
      int checkListBonus = int.Parse(Console.ReadLine());

      CheckListGoal checkListGoal = new CheckListGoal(checkListName, checkListDescription, checkListPoints, checkListTarget, checkListBonus);

      _goals.Add(checkListGoal);
      break;
       
    }

  }

  public void SaveFile(){

    Console.WriteLine("What would you like the name of your file to be? ");
    String fileName = Console.ReadLine() + ".txt";
    
    using (StreamWriter outputFile = new StreamWriter(fileName)){

      outputFile.WriteLine(_score);
      foreach(Goal goal in _goals){
        outputFile.WriteLine(goal.GetStringRepresentation());
      }
    }
  }

  public void LoadFile(){
    
    Console.WriteLine("What file would you like to load? ");
    String fileName = Console.ReadLine() + ".txt";
    String[] lines = System.IO.File.ReadAllLines(fileName);
    

    foreach(String line in lines){
      
      String[] splitter = line.Split(": ");
      String goalType = splitter[0];
      
      switch(goalType){
        default:
        _score = int.Parse(goalType);
        break;

        case "SimpleGoal":
          String[] simpleParts = splitter[1].Split(", ");
          SimpleGoal simple = new SimpleGoal(simpleParts[0], simpleParts[1], int.Parse(simpleParts[2]));
          _goals.Add(simple);
          break;
        
        case "EternalGoal":
          String[] eternalParts = splitter[1].Split(", ");
          EternalGoal eternal = new EternalGoal(eternalParts[0], eternalParts[1], int.Parse(eternalParts[2]));
          _goals.Add(eternal);
          break;

        case "CheckListGoal":
        String[] parts = splitter[1].Split(", ");
        int points = int.Parse(parts[2]);
        CheckListGoal checkList = new CheckListGoal(parts[0], parts[1], points, int.Parse(parts[3]), int.Parse(parts[4]));
        checkList.SetAmountCompleted(int.Parse(parts[5]));
        _goals.Add(checkList);
        break;
      
      }

    }
  }
  
}