using System;

class Program
{
    private static String _starter;
    private static List<String> _prompts = new List<String>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private static List<String> _questions = new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private static List<String> _listPrompts = new List<String>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };
    static void Main(string[] args)
    {
        _starter = "";
        
        while(_starter != "4"){

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            _starter = Console.ReadLine();

            switch(_starter){
                default:
                Console.WriteLine("Not a valid response. Please type in a number between 1-4");
                break;

                case "1":
                Activity activity = new Activity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
                activity.DisplayStartingMessage();
                String answer = Console.ReadLine();
                int duration = int.Parse(answer);
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing", duration);
                breathing.ShowSpinner(5);
                breathing.Run();
                break;

                case "2":
                Activity activity1 = new Activity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity1.DisplayStartingMessage();
                String answer1 = Console.ReadLine();
                int duration1 = int.Parse(answer1); 
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", activity1.GetDescription(), duration1, _prompts, _questions);
                reflecting.Run();
                break;

                case "3":
                Activity activity2 = new Activity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity2.DisplayStartingMessage();
                String answer2 = Console.ReadLine();
                int duration2 = int.Parse(answer2);
                ListingActivity listing = new ListingActivity("Listing Activity", activity2.GetDescription(), duration2, 0, _listPrompts);
                listing.Run();

                break;
                
                case "4":
                _starter = "4";
                Console.WriteLine("Thanks for using the activity program!");
                break;
            }



        }
        
    }
}