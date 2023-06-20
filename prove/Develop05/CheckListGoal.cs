public class ChecklistGoal : IChecklist
{
  private int _goalPoints;
  private int _accomplishedTimes;
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get => _goalPoints; set => _goalPoints += value; }
  public int AccomplishedTimes { get => _accomplishedTimes; set => ++_accomplishedTimes; }
  public int AccomplishTimesForBonus { get; set; }
  public int BonusPoints { get; set; }

  public void ApplyBonus()
  {
    throw new NotImplementedException();
  }

  public void CheckForBonus()
  {
    throw new NotImplementedException();
  }

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
