public class Word{
  private String _text;
  private Boolean _isHidden;

 public Word(String text){
      _text = text;
 }
 
  public String GetDisplayText(){
    String result = "";
    if(_isHidden){
      for(int i = 0; i < _text.Length; i++){
        result += "_";
      }
    }
    else{result = _text;}
    return result;
  }
  public void Hide(){
    _isHidden = true;
  }
  public void Show(){
    _isHidden = false;
  }

  public Boolean IsHidden(){
    if(_isHidden == true){
      return true;
    }
    else{
      return false;
    }
  }
}