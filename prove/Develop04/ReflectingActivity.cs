class ReflectingActivity: Activity{
  private List<string> _prompts;
  private List<string> _questions;
  private int _questionDisplayTime;

  public ReflectingActivity(string startingMessage, string endingMessage,  int activityTime):
                      base(startingMessage, endingMessage, activityTime){

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
