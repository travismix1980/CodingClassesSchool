class Activity{
  protected string _startingMessage;
  protected string _endingMessage;
  protected int _activityTime;

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
    Console.Write("\nHow long would you like to do this activity in seconds? ");
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
