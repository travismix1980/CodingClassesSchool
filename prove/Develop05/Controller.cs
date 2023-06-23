public class Controller{
  Menu mm = new MainMenu();
  Menu gm = new GoalMenu();
  IGoal simpleGoal;
  IGoal eternalGoal;
  IGoal checklistGoal;

  public void RunMainMenu(){

    mm.ShowMenu();
    int menuChoice = mm.GetMenuChoice();
    GoToMainMenuChoice(menuChoice);
  }

  public void RunGoalMenu(){
    gm.ShowMenu();
    int goalMenuChoice = gm.GetMenuChoice();
    GoToGoalMenuChoice(goalMenuChoice);
  }

  public void GoToMainMenuChoice(int choice){
    switch(choice){
      // create new goal
      case 1:
        RunGoalMenu();
        break;
      // list goals
      case 2:
        break;
      // save goals
      case 3:
        break;
      // load goals
      case 4:
        break;
      // record goal
      case 5:
        break;
      // Show Total points
      case 6:
        break;
      // quit
      case 7:
        break;
      default:
        Console.WriteLine("Invalid choice please try again");
        RunMainMenu();
        break;
    }
  }

  public void GoToGoalMenuChoice(int choice){
    switch(choice){
      // Simple Goal
      case 1:
        break;
      // Eternal Goal
      case 2:
        break;
      // Checklist Goal
      case 3:
        break;
      default:
        Console.WriteLine("Invalid choice please try again");
        RunGoalMenu();
        break;
    }
  }
}
