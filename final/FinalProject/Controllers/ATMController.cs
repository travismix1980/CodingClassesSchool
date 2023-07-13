public class ATMController{
  MenuController _menuController;
  ATM _atm;

  public ATMController(){
    _menuController = new();
    _atm = new();
    _atm.DepositMoney(100);
  }

  public void HandleAtmMenu(){
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
