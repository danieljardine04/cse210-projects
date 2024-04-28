using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        Console.WriteLine("Enter a list of numbers. type 0 when finished");
        while (number != 0){
            Console.WriteLine("Enter number: ");
            string choice = Console.ReadLine();
            number = int.Parse(choice);            
            if(choice == "0"){
                continue;
            }
            numbers.Add(number);
        }
        float sum = 0;
        float largest = 0;
        for(int i = 0; i < numbers.Count; i++) {
            sum += numbers[i];
            if(numbers[i] > largest){
                largest = numbers[i];
            }

        }
        float average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}