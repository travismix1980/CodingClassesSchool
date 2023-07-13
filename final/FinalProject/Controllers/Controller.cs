public class Controller
{
  MenuController _menuController;
  ShowRules _showRules;
  Table _table;
  ATMController _atmController;
  public Controller()
  {
    _menuController = new();
    _showRules = new();
    _atmController = new();
  }
  public void RunBlackJack()
  {
    // make this process repeat by using a loop
    bool endflag = true;
    while (endflag)
    {
      // Clear the console between each new display of the menu
      Console.Clear();
      // display main menu
      _menuController.DisplayMainMenu();
      switch (_menuController.GetMainMenuChoice())
      {
        case 1:
          Table table = new();
          int[] difficulty = table.SetDifficulty();
          table.SetMinBet(difficulty[0]);
          table.SetNumOfDecks(difficulty[1]);
          table.PlayBlackJack();
          break;
        case 2:
          _showRules.ShowTheRules();
          break;
        case 3:
          _atmController.HandleAtmMenu();
          break;
        case 4:
          Console.WriteLine("Save or load a game");
          break;
        case 5:
          Console.WriteLine("Thanks for playing");
          endflag = false; // set loop to end
          break;
        default:
          Console.WriteLine("Error Bad Input");
          Console.WriteLine(); // spacing
          break;
      }
    }
  }
}
