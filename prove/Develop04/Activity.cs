class Activity{
  protected string _startingMessage;
  protected string _endingMessage;
  protected string _description;
  protected int _activityTime;

public Activity(){}
  public Activity(string startingMessage, string endingMessage, string description){
    _startingMessage = startingMessage;
    _endingMessage = endingMessage;
    _description = description;
  }

  protected void SetStartingMessage(string startingMessage){
    _startingMessage = startingMessage;
  }

  protected void SetEndingMessage(string endingMessage){
    _endingMessage = endingMessage;
  }

  protected void SetDescriptionMessage(string description){
    _description = description;
  }

  public string DisplayStartingMessage(){
    return _startingMessage;
  }

  public string DisplayEndingMessage(){
    return _endingMessage;
  }

  public string DisplayDescriptionMessage(){
    return _description;
  }

  public void SetActivityTimeInMilliseconds(){
    Console.Write("\nHow long would you like to do this activity in seconds?(using increments of 10 seconds) ");
    int seconds = Convert.ToInt32(Console.ReadLine());
    int milliseconds = seconds * 1000;
    _activityTime = milliseconds;
  }

  public void ShowSpinner(int frameTime, int animationTime){
    Animation a = new();
    a.PlaySpinnerAnimation(frameTime, animationTime);
  }

  public void ShowCountdown(int maxCount){
    Animation a = new();
    a.PlayCountdownAnimation(maxCount);
  }
}
