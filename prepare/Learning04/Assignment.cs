using System.Diagnostics.Contracts;

public class Assignment {
  private String _studentName;
  private String _topic;

  public Assignment(String studentName, String topic){
    _studentName = studentName;
    _topic = topic;
  }

  public String GetName(){
    return _studentName;

  }
  public String GetTopic(){
    return _topic;
  }

  public String GetSummary(){
    String summary = _studentName +"'s homework is in " + _topic;
    return summary;
  }
}