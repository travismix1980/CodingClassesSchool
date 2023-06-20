/// <summary>
/// This class is for creating simple goals and basically just inherits everything
/// from the base class Goal to work.
/// </summary>
public class SimpleGoal : IGoal
{
  private int _goalPoints;
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get => _goalPoints; set => _goalPoints += value; }

  public void CreateGoal()
  {
    throw new NotImplementedException();
  }

  public void LoadGoal()
  {
    throw new NotImplementedException();
  }

  public void RecordGoal()
  {
    throw new NotImplementedException();
  }

  public void SaveGoal()
  {
    throw new NotImplementedException();
  }
}
