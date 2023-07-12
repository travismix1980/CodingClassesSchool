public class Controller
{
  MenuController _menuController;
  ShowRules _showRules;
  Table _table;
  ATM _atm;
  public Controller()
  {
    _menuController = new();
    _showRules = new();
    _atm = new();
    _atm.DepositMoney(100.00);

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
          HandleAtmMenu();
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

  private void HandleAtmMenu(){
    bool atmEndFlag = true;
    while(atmEndFlag){
      Console.Clear();
      _menuController.DisplayATMMenu();
      switch(_menuController.GetATMMenuChoice()){
        case 1: // check balance
          Console.WriteLine($"You have ${_atm.GetMoneyStored()}");
          Console.WriteLine("Press ENTER to continue...");
          while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
          break;
        case 2: // deposit funds
          // TODO: Make sure the money leaves the player and isnt more than what they have
          Console.Write("How much would you like to deposit $");
          _atm.DepositMoney(Convert.ToDouble(Console.ReadLine()));
          break;
        case 3: // withdraw funds
          //TODO: Make sure the money leaves the atm and isnt more than what is in the atm
          Console.Write("How much would you like to withdraw $");
          _atm.WithdrawMoney(Convert.ToDouble(Console.ReadLine()));
          break;
        case 4: // leave atm
          Console.WriteLine("Thanks for using the atm machine");
          atmEndFlag = false;
          break;
        default: // oops
          Console.WriteLine("Invalid Input");
          break;
      }
    }
  }
}
