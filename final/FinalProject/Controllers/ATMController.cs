public class ATMController{
  MenuController _menuController;
  ATM _atm;

  public ATMController(){
    _menuController = new();
    _atm = new();
    _atm.DepositMoney(100);
  }

  public void HandleAtmMenu(Player player){
    bool atmEndFlag = true;
    while(atmEndFlag){
      Console.Clear();
      _menuController.DisplayATMMenu();
      switch(_menuController.GetATMMenuChoice()){
        case 1: // check balance
          Console.WriteLine($"You have ${_atm.GetMoneyStored()} available in the ATM");
          Console.WriteLine($"You have ${player.GetCurrentMoney()} on you.");
          Console.WriteLine("Press ENTER to continue...");
          while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
          break;
        case 2: // deposit funds
          // TODO: Make sure the money leaves the player and isnt more than what they have
          Console.Write($"How much would you like to deposit you have ${player.GetCurrentMoney()} on you and ${_atm.GetMoneyStored()} in the ATM. $");
          double depositAmount = Convert.ToDouble(Console.ReadLine());
          if(depositAmount <= player.GetCurrentMoney()){
            _atm.DepositMoney(depositAmount);
            player.SetCurrentMoney(-depositAmount);
          }else{
            Console.WriteLine($"You don't have enough money to deposit ${depositAmount}");
          }
          Console.WriteLine("Press ENTER to continue...");
          while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
          break;
        case 3: // withdraw funds
          //TODO: Make sure the money leaves the atm and isnt more than what is in the atm
          Console.Write($"How much would you like to withdraw you have {player.GetCurrentMoney()} on you and ${_atm.GetMoneyStored()} in the ATM. $");
          double withdrawAmount = Convert.ToDouble(Console.ReadLine());
          if(withdrawAmount <= _atm.GetMoneyStored()){
            player.SetCurrentMoney(withdrawAmount);
            _atm.WithdrawMoney(withdrawAmount);
          } else {
            Console.WriteLine($"Your ATM balance is not enough to withdraw the amount of ${withdrawAmount}");
          }
          Console.WriteLine("Press ENTER to continue...");
          while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
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
