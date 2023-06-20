/// <summary>
/// This class is for creating simple goals and basically just inherits everything
/// from the base class Goal to work.
/// </summary>
public class SimpleGoal:Goal{

  /// <summary>
  /// The constructor for SimpleGoal that sets the needed parameters in the base class
  /// </summary>
  /// <param name="goalName">(string) this sets the name of the goal</param>
  /// <param name="goalDescription">(string)this sets the goal description</param>
  /// <param name="goalPoints">(int) this sets the amount of points gained for completing the goal</param>
  public SimpleGoal(string goalName, string goalDescription, int goalPoints):base(goalName, goalDescription, goalPoints){}
}
