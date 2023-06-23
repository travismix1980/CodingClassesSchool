public class Controller{
  MainMenu mm = new();
  GoalMenu gm = new();
  private List<IGoal> _goalsList = new();

  public bool RunMainMenu(){
    mm.ShowMenu();
    int menuChoice = mm.GetMenuChoice();
    return GoToMainMenuChoice(menuChoice);
  }

  public void RunGoalMenu(){
    gm.ShowMenu();
    int goalMenuChoice = gm.GetMenuChoice();
    GoToGoalMenuChoice(goalMenuChoice);
  }

  public bool GoToMainMenuChoice(int choice){
    switch(choice){
      // create new goal
      case 1:
        RunGoalMenu();
        return true;
      // list goals
      case 2:
        ListCurrentGoals();
        return true;
      // save goals
      case 3:
        return true;
      // load goals
      case 4:
        return true;
      // record goal
      case 5:
        return true;
      // Show Total points
      case 6:
        return true;
      // quit
      case 7:
      Console.WriteLine("Thanks for using the Eternal Goal Tracker");
        return false;
      default:
        Console.WriteLine("Invalid choice please try again");
        RunMainMenu();
        return true;
    }
  }

  public void GoToGoalMenuChoice(int choice){
    switch(choice){
      // Simple Goal
      case 1:
        CreateSimpleGoal();
        break;
      // Eternal Goal
      case 2:
        CreateEternalGoal();
        break;
      // Checklist Goal
      case 3:
        CreateChecklistGoal();
        break;
      default:
        Console.WriteLine("Invalid choice please try again");
        RunGoalMenu();
        break;
    }
  }

  public void CreateSimpleGoal(){
    Console.Write("What is the name of your Simple goal: ");
    string name = Console.ReadLine();
    Console.Write("Enter a description for your goal: ");
    string description = Console.ReadLine();
    Console.Write("How many points is your goal worth: ");
    int points = Convert.ToInt32(Console.ReadLine());
    IGoal goal = new SimpleGoal(name, description, points);
    _goalsList.Add(goal);
    goal.SaveToString();
  }

  public void CreateEternalGoal(){
    Console.Write("What is the name of your Eternal goal: ");
    string name = Console.ReadLine();
    Console.Write("Enter a description for your goal: ");
    string description = Console.ReadLine();
    Console.Write("How many points is your goal worth: ");
    int points = Convert.ToInt32(Console.ReadLine());
    IGoal goal = new EternalGoal(name, description, points);
    _goalsList.Add(goal);
    goal.SaveToString();
  }

  public void CreateChecklistGoal(){
    Console.Write("What is the name of your Checklist goal: ");
    string name = Console.ReadLine();
    Console.Write("Enter a description for your goal: ");
    string description = Console.ReadLine();
    Console.Write("How many points is your goal worth each time you complete it: ");
    int points = Convert.ToInt32(Console.ReadLine());
    Console.Write("How many times would you like to complete the goal: ");
    int accomplishTimesForBonus = Convert.ToInt32(Console.ReadLine());
    Console.Write($"How many bonus points is the goal worth if you complete it all {accomplishTimesForBonus} times: ");
    int bonusPoints = Convert.ToInt32(Console.ReadLine());
    IGoal goal = new ChecklistGoal(name, description, points, accomplishTimesForBonus, bonusPoints);
    _goalsList.Add(goal);
    goal.SaveToString();
  }

  public void ListCurrentGoals(){
    foreach(IGoal goal in _goalsList){
      Console.WriteLine(goal.SaveString);
      Console.WriteLine(); // spacing
    }
  }
}
