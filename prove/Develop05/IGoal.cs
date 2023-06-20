/// <summary>
/// added this one just to throw in an interface not that it was needed
/// </summary>
interface IGoal
{
  string GoalName { get; set; }
  string GoalDescription { get; set; }
  int GoalPoints { get; set; }

  void CreateGoal();
  void RecordGoal();
  void SaveGoal();
  void LoadGoal();
}
