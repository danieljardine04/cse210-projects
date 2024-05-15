public class MathAssignment : Assignment {
  private String _textbookSection;
  private String _problems;

  public MathAssignment(String name, String topic, String textbookSection, String problems) : base(name, topic){
    _textbookSection = textbookSection;
    _problems = problems;
  }

  public String GetHomeworkList(){
    String name = GetName();
    String topic = GetTopic();
    String HomeworkList = name + " " + topic + " " + _textbookSection + " " + _problems;
    return HomeworkList;
  }
}