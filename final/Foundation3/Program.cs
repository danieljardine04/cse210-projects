using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("81 Nottingham dr.", "Queensbury",  "NY", 12804);
        Address address2 = new Address("36 E Columbia ave", "Millcreek", "UT", 84107);
        Address address3 = new Address("5808 Harrison Blvd.", "South Ogden", "UT", 84403);

        Lectures lecture = new Lectures("Video Games", "Why video game music is the best genre", "July 5th, 2024", "6 PM", "lecture", address1, "Daniel Jardine", 30);
        OutdoorGatherings outdoorGathering = new OutdoorGatherings("Wedding", "My little bro is finally getting married", "September 20th, 2024", "2 PM", "Outdoor Activity", address2, "Sunny at 68 degrees");
        Receptions reception = new Receptions("Christmas Party", "Christmas Party at the Storage!!!", "December 18th 2024", "8 PM", "Reception", address3, "danogaryjardine@gmail.com");

        List<Event> events = new List<Event>();
        events.Add(lecture);
        events.Add(outdoorGathering);
        events.Add(reception);

        foreach(Event name in events){
            Console.WriteLine("Here are the details for the event: ");
            name.StandardDetails();
            Console.WriteLine();
            Console.WriteLine("Now for the full event Details:");
            name.GetFullDetails(); // I made this into an abstract class and abstract methods as to not have to write everything out.

        }

        

    }

}