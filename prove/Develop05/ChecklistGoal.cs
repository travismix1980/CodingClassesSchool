public class ChecklistGoal : Goal
{
  public int AccomplishTimes { get; set; }
  public int AccomplishTimesForBonus { get; set; }
  public int BonusPoints { get; set; }
  public ChecklistGoal(string name, string description, int points, int accomplishTimes, int accomplishTimesForBonus, int bonusPoints) : base(name, description, points)
  {
    AccomplishTimes = accomplishTimes;
    AccomplishTimesForBonus = accomplishTimesForBonus;
    BonusPoints = bonusPoints;
  }


  public override void RecordGoal(){
    if(AccomplishTimes < AccomplishTimesForBonus){
      AccomplishTimes = AccomplishTimes + 1;
    } else {
      IsComplete = true;
    }
  }

/// <summary>
/// Checks to see if goal qualifies for bonus points
/// </summary>
  public void CheckForBonus(){
    if(AccomplishTimes >= AccomplishTimesForBonus){
      ApplyBonus();
    }
  }

/// <summary>
/// returns true if we need to add bonus points to score
/// </summary>
/// <returns>bool</returns>
  public bool ApplyBonus(){
    return true;
  }
}
