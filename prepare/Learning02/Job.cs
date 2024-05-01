public class Job {
  public String _company;
  public String _jobTitle;
  public int _startYear;
  public int _endYear;

   public void DisplayMessage(Job job){
        Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear} {job._endYear}");
       
    }

}