public class SimpleGoal : Goal
{
  public SimpleGoal(string name, string description, int points, bool complete=false) : base(name, description, points, complete)
  {
  }

  public override void SaveToSaveString(){
    SaveString = $"SimpleGoal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{IsComplete}";
  }
}
