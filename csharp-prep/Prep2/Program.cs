using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your gradepoint average");
        string grade = Console.ReadLine();
        int number_grade = int.Parse(grade);
        String letter_grade;

        if (number_grade >= 90) {
            letter_grade = "A";
            
        }
        else if (number_grade >= 80){
            letter_grade = "B";
           
        }
        else if (number_grade >= 70){
            letter_grade = "C";
        }
        else if (number_grade >= 60){
            letter_grade = "D";
        }
        else {
            letter_grade = "F";
            Console.Write(letter_grade);
        }
        
        Console.WriteLine(letter_grade);

        if (number_grade >= 70){
            Console.Write("Congratulations you passed the class. You are going onto bigger and better things!");
        }
        else {
            Console.Write("We regret to inform you that you did not pass the class. BETTER LUCK NEXT YEAR!");
        }
    }
}