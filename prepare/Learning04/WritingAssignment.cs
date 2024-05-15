using System.Security.Cryptography.X509Certificates;

public class WritingAssignment : Assignment{
  private String _title;

  public WritingAssignment(String name, String topic, String title) :base(name, topic){
    _title = title;
  }

  public String GetWritingInformation(){
    String name = GetName();
    String topic = GetTopic();
    String writingInformation = name = " " + topic + " " + _title;
    return writingInformation;
  }
}