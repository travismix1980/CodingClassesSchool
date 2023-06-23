public abstract class Goal : IGoal
{
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get; set; }
  public bool IsComplete { get; set; } = false;
  public string SaveString { get; set; }

  public Goal(string name, string description, int points)
  {
    GoalName = name;
    GoalDescription = description;
    GoalPoints = points;
  }

  public virtual void RecordGoal()
  {
    IsComplete = true;
  }

  public virtual void SaveToString()
  {
    SaveString = $"Goal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{IsComplete}";
  }
}
