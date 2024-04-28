using System;

class Program
{
        static void DisplayMessage(){
            String message = "Welcome to the program!";
            Console.WriteLine(message);
        }

         static String PromptUserName(){
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(){
            Console.Write("Please enter your favorite number: ");
            string choice = Console.ReadLine();
            int number = int.Parse(choice);
            return number;
        }

        static int SquareNumber(int number){
            int result = (int)Math.Pow(number, 2);
            return result;
        }

        static void DisplayResult(int sq, string name){
            Console.WriteLine($"{name}, the square of your favorite number is {sq}");
        }

    static void Main(string[] args)
    {
        DisplayMessage();
        String name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int numbersquared = SquareNumber(favoriteNumber);
        DisplayResult(numbersquared, name);
    }
}