class ReflectingActivity: Activity{
  private List<string> _prompts;
  private List<string> _questions;
  private int _questionDisplayTime;
  const string START_MESSAGE = "Welcome to the Reflecting Activity";
  const string END_MESSAGE = "You completed your reflection time. Well Done!";

  public ReflectingActivity(string startingMessage, string endingMessage):
                      base(startingMessage, endingMessage){

  }

  public string GetRandomPrompt(){
    return string.Empty;
  }

  public string GetQuestion(){
    return string.Empty;
  }

  public void RunReflecting(){

  }
}
