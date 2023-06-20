public abstract class Goal : IGoal
{
/// <summary>
/// holds the name of the goal
/// </summary>
  private string _goalName;

  /// <summary>
  /// holds the description of the goal
  /// </summary>
  private string _goalDescription;

  /// <summary>
  /// holds the points for completing the goal
  /// </summary>
  private int _goalPoints;

/// <summary>
/// empty constructor at this stage it doesnt need to do anything
/// </summary>
  public Goal(){}

/// <summary>
/// This constructor sets our goal parameters
/// </summary>
/// <param name="goalName">(string) this sets the name of the goal</param>
/// <param name="goalDescription">(string)this sets the goal description</param>
/// <param name="goalPoints">(int) this sets the amount of points gained for completing the goal</param>
  public Goal(string goalName, string goalDescription, int goalPoints){
    _goalName = goalName;
    _goalDescription = goalDescription;
    _goalPoints = goalPoints;
  }

  /// <summary>
  /// in child classes it will be used to create new goals
  /// </summary>
  public virtual void CreateGoal()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// in child classes this will be used to load goals
  /// </summary>
  public virtual void LoadGoal()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// in child classes this will record goal completion
  /// </summary>
  public virtual void RecordGoal()
  {
    throw new NotImplementedException();
  }

  /// <summary>
  /// in child classes this will save goals
  /// </summary>
  public virtual void SaveGoal()
  {
    throw new NotImplementedException();
  }
}
