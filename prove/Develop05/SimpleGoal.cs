public class SimpleGoal : Goal
{
  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
  }

  public override void SaveToString(){
    SaveString = $"SimpleGoal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{IsComplete}";
  }
}
