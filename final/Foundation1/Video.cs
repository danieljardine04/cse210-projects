public class Video{
  public String _author;
  public string _title;
  public int _length;
  public List<Comment> _comments = new List<Comment>();

  public void DisplayInformation(){
    Console.WriteLine($"Author: {_author}, Title: {_title}, Seconds:{_length} ");
    Console.WriteLine($"Comments: {NumberOfComments()}");
    ListComments();
  }

  public int NumberOfComments(){
    int result = 0;
    foreach(Comment comment in _comments){
      result++;
    }
    return result;
  }

  public void addComment(Comment comment){
    _comments.Add(comment);
  }

  public void ListComments(){
    foreach(Comment comment in _comments){
      Console.WriteLine();
      Console.WriteLine(comment.name);
      Console.WriteLine(comment.text);
      Console.WriteLine();
    }
  }


}

