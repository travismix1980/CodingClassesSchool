public abstract class Goal : IGoal
{
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get; set; }
  public bool IsComplete { get; set; } = false;

  public Goal(string name, string description, int points){
    GoalName = name;
    GoalDescription = description;
    GoalPoints = points;
  }

  public void RecordGoal()
  {
    throw new NotImplementedException();
  }

  public string SaveToString()
  {
    throw new NotImplementedException();
  }
}
