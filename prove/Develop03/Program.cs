using System;

class Program
{
    static String _input = "";
    static void Main(string[] args)
    {
       Reference reference = new Reference("2 Nephi", 2, 25);
       Reference reference1 = new Reference("Alma", 5, 12, 14);

       Console.Clear();
       Scripture scripture = new Scripture(reference, "Adam fell that men might be, and men are that they might have joy.");
       Console.WriteLine(scripture.GetDisplayText());

       while(!scripture.IsCompletelyHidden() && _input != "quit"){
        Console.WriteLine("Press ENTER key to continue or type QUIT to end program");
        _input = Console.ReadLine();
        switch(_input.ToLower()){
            case "":
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            break;
            case "quit":
            _input = "quit";
            break;
            default:
            Console.WriteLine("That is not a valid input, please try again.");
            break;
        }

       }
    }
}