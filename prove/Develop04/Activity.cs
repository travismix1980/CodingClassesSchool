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

  public void SetActivityTimeInMilliseconds(){
    Console.Write("How long would you like to do this activity in minutes? ");
    double minutes = Convert.ToDouble(Console.ReadLine());
    int milliseconds = Convert.ToInt32(minutes * 60) * 1000;
    _activityTime = milliseconds;
  }

  public void ShowSpinner(){

  }

  public void ShowCountdown(){

  }
}
