public class Controller
{
  MenuController _menuController;
  ShowRules _showRules;
  Table _table;
  public Controller()
  {
    _menuController = new();
    _showRules = new();
    //TODO: Move creation of table to case 1 and allow the user to chose num of decks and min bet
    _table = new(2, 4);
  }
  public void RunBlackJack()
  {
    // make this process repeat by using a loop
    bool endflag = true;
    while (endflag)
    {
      // display main menu
      _menuController.DisplayMainMenu();
      switch (_menuController.GetMainMenuChoice())
      {
        case 1:
          _table.PlayBlackJack();
          break;
        case 2:
          _showRules.ShowTheRules();
          break;
        case 3:
          Console.WriteLine("Visit the ATM Machine");
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
