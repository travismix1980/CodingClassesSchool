interface IGoal{
  string GoalName { get; set; }
  string GoalDescription { get; set; }
  int GoalPoints { get; set; }
  bool IsComplete { get; set; }
  string SaveString { get; set; }
  void RecordGoal();
  void SaveToString();
}
