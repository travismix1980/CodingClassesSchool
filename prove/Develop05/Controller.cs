public class Controller{
  MainMenu mm = new();
  GoalMenu gm = new();
  Score s = new();
  GoalIO gio = new();
  private List<Goal> _goalsList = new();

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
      Console.Write("Enter a filename to save your goals as minus any extension(.txt): ");
      string saveFileName = Console.ReadLine();
      gio.SaveGoals(saveFileName, _goalsList, s);
        return true;
      // load goals
      case 4:
        Console.Write("Enter a filename to load minus any extension(.txt): ");
        string loadFileName = Console.ReadLine();
        // clear out our list before we load the new one
        _goalsList.Clear();
        _goalsList.AddRange(gio.LoadGoals(loadFileName, s));
        return true;
      // record goal
      case 5:
        RecordGoal();
        return true;
      // Show Total points
      case 6:
        Console.WriteLine($"Your score is {s.GetScore()}");
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
    Goal goal = new SimpleGoal(name, description, points);
    _goalsList.Add(goal);
    goal.SaveToSaveString();
    goal.SaveToListString();
  }

  public void CreateEternalGoal(){
    Console.Write("What is the name of your Eternal goal: ");
    string name = Console.ReadLine();
    Console.Write("Enter a description for your goal: ");
    string description = Console.ReadLine();
    Console.Write("How many points is your goal worth: ");
    int points = Convert.ToInt32(Console.ReadLine());
    Goal goal = new EternalGoal(name, description, points);
    _goalsList.Add(goal);
    goal.SaveToSaveString();
    goal.SaveToListString();
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
    Goal goal = new ChecklistGoal(name, description, points, accomplishTimesForBonus, bonusPoints);
    _goalsList.Add(goal);
    goal.SaveToSaveString();
    goal.SaveToListString();
  }

  public void ListCurrentGoals(){
    Console.WriteLine(); // spacing
    foreach(IGoal goal in _goalsList){
      Console.WriteLine(goal.ListString);
    }
  }

  public void RecordGoal(){
    int count = 1;
    foreach(IGoal goal in _goalsList){
      Console.WriteLine($"{count} {goal.ListString}");
      count++;
    }
    Console.WriteLine(); // spacing

    Console.Write("Please chose a goal to record complete: ");
    int recordChoice = Convert.ToInt32(Console.ReadLine());
    if(_goalsList[recordChoice -1].IsComplete){
      Console.WriteLine("That goal is already completed and cannot be completed further");
    } else {
      _goalsList[recordChoice - 1].RecordGoal();
      s.SetScore(_goalsList[recordChoice - 1].GoalPoints);
      if(_goalsList[recordChoice - 1].GetType().ToString() == "ChecklistGoal"){
        if(_goalsList[recordChoice - 1].IsComplete){
          ChecklistGoal goal = (ChecklistGoal) _goalsList[recordChoice - 1];
          s.SetScore(goal.BonusPoints);
          Console.WriteLine($"Congrats you earned {goal.BonusPoints} bonus points!");
        }
      }
      _goalsList[recordChoice - 1].SaveToListString();
      _goalsList[recordChoice - 1].SaveToSaveString();
    }
    // show points
    Console.WriteLine($"Total Points: {s.GetScore()}");
  }
}
