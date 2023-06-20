interface IChecklist: IGoal{
  int AccomplishedTimes {get; set;}
  int AccomplishTimesForBonus{get; set;}
  int BonusPoints{get; set;}
  void CheckForBonus();
  void ApplyBonus();
}
