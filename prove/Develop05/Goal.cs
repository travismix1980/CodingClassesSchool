public abstract class Goal : IGoal
{
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get; set; }
  public bool IsComplete { get; set; } = false;
  public string SaveString { get; set; }
  public string ListString { get; set; }

  public Goal(string name, string description, int points, bool complete=false)
  {
    GoalName = name;
    GoalDescription = description;
    GoalPoints = points;
    IsComplete = complete;
  }

  public virtual void RecordGoal()
  {
    IsComplete = true;
  }

  public virtual void SaveToSaveString()
  {
    SaveString = $"Goal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{IsComplete}";
  }

  public virtual void SaveToListString(){
    string checkbox = "";
    if(IsComplete){
      checkbox = "[x]";
    } else {
      checkbox = "[ ]";
    }
    ListString = $"{checkbox} {GoalName} ({GoalDescription})";
  }
}
