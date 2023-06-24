public class ChecklistGoal : Goal
{
  public int AccomplishTimes { get; set; }
  public int AccomplishTimesForBonus { get; set; }
  public int BonusPoints { get; set; }
  public ChecklistGoal(string name, string description, int points, int accomplishTimesForBonus, int bonusPoints) : base(name, description, points)
  {
    AccomplishTimes = 0;
    AccomplishTimesForBonus = accomplishTimesForBonus;
    BonusPoints = bonusPoints;
  }

  public override void SaveToSaveString()
  {
    SaveString = $"ChecklistGoal\\{GoalName}\\{GoalDescription}\\{GoalPoints}\\{AccomplishTimes}\\{AccomplishTimesForBonus}\\{BonusPoints}\\{IsComplete}";
  }

  public override void SaveToListString(){
    string checkbox = "";
    if(IsComplete){
      checkbox = "[x]";
    } else {
      checkbox = "[ ]";
    }
    ListString = $"{checkbox} {GoalName} ({GoalDescription}) -- Currently Completed: {AccomplishTimes}/{AccomplishTimesForBonus}";
  }

  public override void RecordGoal(){
    if(AccomplishTimes < AccomplishTimesForBonus){
      AccomplishTimes++;
    }
    if(AccomplishTimes == AccomplishTimesForBonus) {
      IsComplete = true;
    }
  }
}
