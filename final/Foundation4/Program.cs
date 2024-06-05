using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        DateOnly date = new DateOnly(2024, 6, 4);
        

        Swimming swimming = new Swimming(date, 30, 33);
        Cycling cycling = new Cycling(date, 90, 15);
        Running running = new Running(date, 65, 7.2);

        activities.Add(swimming);
        activities.Add(cycling);
        activities.Add(running);

        foreach(Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}