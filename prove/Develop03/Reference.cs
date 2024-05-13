public class Reference {
  public String _book{get;set;}
  private int _chapter;
  private int _verse;
  private int _endVerse;


public Reference(String book, int chapter, int verse, int endVerse){
  _book = book;
  _chapter = chapter;
  _verse = verse;
  _endVerse = endVerse;
}

public Reference(String book, int chapter, int verse):this(book, chapter, verse, verse){}

public String GetDisplayText(){
  String result = $"{_book} {_chapter}:{_verse}";
  if(_endVerse != _verse){
    result = $"{_book} {_chapter}:{_verse}-{_endVerse}";
  }
  return result;
}
}