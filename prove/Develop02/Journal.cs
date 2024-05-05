public class Journal {
  public String fileName;
  public List<Entry> entries = new List<Entry>();

  public void Save(Entry entry){
    entries.Add(entry);
  }

  public void CreateFile(String fileName){
    using(StreamWriter outputFile = new StreamWriter(fileName)){
      foreach(Entry entry in entries){
        outputFile.WriteLine($"{entry.prompt}~ {entry.message}~ {entry.timeOfMessage}");
      }
    }
  }

public void LoadFile(String fileName){
  if(fileName == null){
    Console.WriteLine("That file does not exist");
  }
  entries.Clear();
  String[] lines = System.IO.File.ReadAllLines(fileName);
  foreach(String line in lines){
    Entry entry = new Entry();
    String[] parts = line.Split("~");
    entry.prompt = parts[0];
    entry.message = parts[1];
    entry.timeOfMessage = parts[2];
    entries.Add(entry);
  }

}

public void DisplayJournal(){
  foreach(Entry entry in entries){
    Console.WriteLine($"{entry.DisplayMessage}");
  }
}

}