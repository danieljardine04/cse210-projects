using System.Xml.XPath;

public class Scripture{
  private Reference _reference;
  private List<Word> _words;

  public Scripture(Reference reference, String verse){
    _reference = reference;
    _words = new List<Word>();
    String[] strWords = verse.Split(" ");
    for(int i = 0; i < strWords.Length; i++){
      Word word = new Word(strWords[i]);
      _words.Add(word);
    }
  }

  public String GetDisplayText(){
    String result;
    String verse = "";
    foreach(Word word in _words){
      verse += word.GetDisplayText() + " ";
    }
    result = $"{_reference.GetDisplayText()} {verse}";
    return result;
  }

  public void HideRandomWords(int numberToHide){
    Random rand = new Random();
    List<Word> visableWords = new List<Word>();
    for(int i = 0; i < _words.Count; i++){
      if(!_words[i].IsHidden()){
        visableWords.Add(_words[i]);
      }
    }
    int hiddenWords = visableWords.Count >= numberToHide ? numberToHide : visableWords.Count;
    for(int i = 0; i < hiddenWords; i++){
      int randomWord = rand.Next(visableWords.Count);
      Word chosenWord = visableWords[randomWord];
      visableWords.Remove(chosenWord);
      chosenWord.Hide();
    }
  }
  
  public Boolean IsCompletelyHidden(){
    foreach(Word word in _words){
      if(!word.IsHidden()){
        return false;
      }
    }
    return true;
  }
}
