using System.Diagnostics;

class BreathingActivity: Activity{
  private const string START_MESSAGE = "Welcome to the Breathing Activity";
  private const string END_MESSAGE = "You completed your breathing time. Well Done!";
  private const string DESCRIPTION = "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing";

  public BreathingActivity(){
    base.SetStartingMessage(START_MESSAGE);
    base.SetEndingMessage(END_MESSAGE);
  }

  public void BreatheInOut(){
    // the timer seems to not end till full cycle
    // of the activity has finished not sure at the
    // moment how to fix that and its probably a good
    // idea to let the user finish the activity or they may
    // get stuck holding their breath as nothing told them
    // to breath out and I don't want anyone passing out
    Stopwatch sw = new();
    sw.Start();
    while(sw.Elapsed.TotalMilliseconds < _activityTime){
      BreatheIn();
      BreatheOut();
    }
    sw.Stop();
  }

  public void BreatheIn(){
    // display breathe in for 4 seconds
    // with countdown animation
    Console.Write("Breathe In...");
    ShowCountdown(4);
    Console.WriteLine(); // spacing
  }

  public void BreatheOut(){
    // display breathe out for 6 seconds
    // with countdown animation
    Console.Write("Now breathe out...");
    ShowCountdown(6);
    Console.WriteLine("\n"); // spacing
  }

  public void RunBreathe(){
    Console.WriteLine($"\n{base.DisplayStartingMessage()}");
    Console.WriteLine($"\n{DESCRIPTION}");
    SetActivityTimeInMilliseconds();  // set timer with base _activityTime
    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(500, 5000); // play animation for 5 seconds
    Console.WriteLine(); // spacing
    BreatheInOut();
    Console.WriteLine($"\n{base.DisplayEndingMessage()}");
  }
}
