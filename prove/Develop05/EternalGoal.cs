public class EternalGoal : Goal
{
  public EternalGoal(string name, string description, int points, bool complete=false) : base(name, description, points, complete)
  {
  }

  public override void SaveToSaveString()
  {
    SaveString = $"EternalGoal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{IsComplete}";
  }

  public override void RecordGoal()
  {
    // this method will never do anything as the goal is not
    // completable so just incase it is called it will just
    // set to fall
    IsComplete = false;
  }
}
