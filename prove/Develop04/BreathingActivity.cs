class BreathingActivity: Activity{
  private int _breatheTime;
  const string START_MESSAGE = "Welcome to the Breathing Activity";
  const string END_MESSAGE = "You completed your breathing time. Well Done!";
  private const string DESCRIPTION = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing";

  public BreathingActivity(string startingMessage, string endingMessage):
                      base(startingMessage, endingMessage){

  }

  public BreathingActivity(){
    base.SetStartingMessage(START_MESSAGE);
    base.SetEndingMessage(END_MESSAGE);

  }

  public void BreatheInOut(){
    BreatheIn();
    BreatheOut();
  }

  public void BreatheIn(){
    // display breathe in for 4 seconds
    // with countdown animation
  }

  public void BreatheOut(){
    // display breathe out for 6 seconds
    // with countdown animation
  }

  public void RunBreathe(){
    Console.WriteLine($"\n{base.DisplayStartingMessage()}");
    Console.WriteLine($"\n{DESCRIPTION}");
    // add spinner here for a short time
    BreatheInOut();
    Console.WriteLine($"\n{base.DisplayEndingMessage()}");
  }
}
