public class Controller{
  public void RunBlackJack(){
    Console.WriteLine("Running Blackjack Game.");
    // display main menu
    MenuController mc = new();
    mc.DisplayMainMenu();
    switch(mc.GetMainMenuChoice()){
      case 1:
        Console.WriteLine("Play a round of BlackJack");
        break;
      case 2:
        ShowRules sr = new();
        sr.ShowTheRules();
        break;
      case 3:
        Console.WriteLine("Visit the ATM Machine");
        break;
      case 4:
        Console.WriteLine("Save or load a game");
        break;
      case 5:
        Console.WriteLine("Quit the game");
        break;
      default:
        Console.WriteLine("Error Bad Input");
        Console.WriteLine(); // spacing
        RunBlackJack();
        break;
    }
  }
}
