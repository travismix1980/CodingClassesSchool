using System.Diagnostics;

class ReflectingActivity: Activity{
  private List<string> _prompts = new();
  private List<string> _questions = new();
  private const string START_MESSAGE = "Welcome to the Reflecting Activity";
  private const string END_MESSAGE = "You completed your reflection time. Well Done!";
  private const string DESCRIPTION = "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you to recognize the power you have and how you can use it in other aspects of your life.";

  public ReflectingActivity(){
    string[] promptsArr = {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    };

    string[] questionsArr = {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn form this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };

    _prompts.AddRange(promptsArr);
    _questions.AddRange(questionsArr);

    base.SetStartingMessage(START_MESSAGE);
    base.SetEndingMessage(END_MESSAGE);
  }

  public string GetRandomPrompt(){
    Random rand = new();
    int randNum = rand.Next(_prompts.Count);
    return _prompts[randNum];
  }

  public string GetRandomQuestion(){
    Random rand = new();
    int randNum = rand.Next(_questions.Count);
    return _questions[randNum];
  }

  public void StartReflecting(){
    Console.WriteLine("Consider the following prompt: \n");
    Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    Console.WriteLine("When you have something in mind, press ENTER to continue.");
    Console.ReadLine(); // no need to store this really any input will do.
    Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");
    Console.Write("You may begin in: ");
    ShowCountdown(5);
  }

  public void RunQuestions(){
    Console.Clear();
    Stopwatch sw = new();
    sw.Start();
    while(sw.Elapsed.TotalMilliseconds < _activityTime){
      Console.WriteLine(GetRandomQuestion());
      Thread.Sleep(10000);
    }
    sw.Stop();
  }

  public void RunReflecting(){
    Console.Clear();
    Console.WriteLine($"\n{base.DisplayStartingMessage()}");
    Console.WriteLine($"\n{DESCRIPTION}");
    SetActivityTimeInMilliseconds();  // set timer with base _activityTime
    Console.Clear();
    Console.WriteLine("Get ready...");
    ShowSpinner(500, 5000); // play animation for 5 seconds
    Console.WriteLine(); // spacing
    StartReflecting();
    RunQuestions();
    Console.WriteLine($"\n{base.DisplayEndingMessage()}");
    Thread.Sleep(5000);
    Console.Clear();
  }
}
