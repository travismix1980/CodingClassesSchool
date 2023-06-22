interface IGoal{
  public string GoalName { get; set; }
  public string GoalDescription { get; set; }
  public int GoalPoints { get; set; }
  public bool IsComplete { get; set; }
  void RecordGoal();
  string SaveToString();
}
