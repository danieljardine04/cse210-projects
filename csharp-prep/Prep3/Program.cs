using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNumber = rnd.Next(0, 101);
        
        Console.WriteLine("What is the Magic Number? Numbers 1-100");
        String guess = Console.ReadLine();
        int guessedNumber = int.Parse(guess);

        if (guessedNumber == magicNumber){
            Console.WriteLine("Great Job you guessed the magic number on the First try! What a boss.");
        }
        else {
            if(guessedNumber < magicNumber){
                Console.WriteLine("The magic number is Higher");
            }
            else if(guessedNumber > magicNumber) {
                Console.WriteLine("The magic number is lower");
            }
            while(guessedNumber != magicNumber){
                Console.Write("What is the Magic Number? Numbers 1 - 100");
                String guess1 = Console.ReadLine();
                guessedNumber = int.Parse(guess1);

                if(guessedNumber == magicNumber){
                    Console.WriteLine("You guessed it!");
                } 
                else if (guessedNumber > magicNumber){
                    Console.WriteLine("The magic number is lower");
                }
                else {
                    Console.WriteLine("The magic number is Higher");
                }
            }
        }
    }  
    
}