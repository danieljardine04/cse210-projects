using System;
using System.Net;
using System.Security.Cryptography;

class Program

{
    static String answer = "";
    static void Main(string[] args)
    {
        String[] yourChoices = ["1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"];
        String[] prompters = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was my greatest accomplishment today?",
            "What are you most looking forward to after today?"
            ];
        Random rand = new Random();
        int index = rand.Next(prompters.Length);
        
        Journal journal = new Journal();


        while(answer != "5"){
            Console.WriteLine("Please select one of the following Choices");
            for(int i = 0; i < yourChoices.Length; i++){
                Console.WriteLine($"{yourChoices[i]}");
            }
            answer = Console.ReadLine();
            switch(answer){
                case "1":
                    Entry entry = new Entry();
                    
                    entry.prompt = prompters[index];
                    Console.WriteLine(entry.prompt);
                    entry.message = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    entry.timeOfMessage = theCurrentTime.ToShortDateString();
                    journal.Save(entry);
                    
                break;
                case "2":
                journal.DisplayJournal();
                break;
                case "3":
                Console.WriteLine("What is the name of the file you would like to load? ");
                String response = Console.ReadLine();
                String result = response + ".txt";
                journal.LoadFile(result);
                break;
                case "4":
                Console.WriteLine("What would you like to have the name of your file be?");
                String response1 = Console.ReadLine();
                String result1 = response1 + ".txt";
                journal.CreateFile(result1);
                break;
                case "5":
                case "quit":
                answer = "5";
                Console.WriteLine("Thanks for using the Journal application");
                break;
                default:
                Console.WriteLine("That was an invalid response please try again.");
                break;
                

            }


        }
    }
}