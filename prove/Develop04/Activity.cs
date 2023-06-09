class Activity{
  protected string _startingMessage;
  protected string _endingMessage;
  private int _activityTime;

public Activity(){}
  public Activity(string startingMessage, string endingMessage){
    _startingMessage = startingMessage;
    _endingMessage = endingMessage;
  }

  protected void SetStartingMessage(string startingMessage){
    _startingMessage = startingMessage;
  }

  protected void SetEndingMessage(string endingMessage){
    _endingMessage = endingMessage;
  }

  public string DisplayStartingMessage(){
    return _startingMessage;
  }

  public string DisplayEndingMessage(){
    return _endingMessage;
  }

  public void SetActivityTime(){

  }

  public void ShowSpinner(){

  }

  public void ShowCountdown(){

  }
}
