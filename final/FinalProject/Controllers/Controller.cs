public class Controller
{
  MenuController _menuController;
  ShowRules _showRules;
  Table _table;
  ATMController _atmController;
  Player _player;
  Dealer _dealer;
  int[] _difficulty = new int[2];
  public Controller()
  {
    _menuController = new();
    _showRules = new();
    _atmController = new();
    Console.Write("What is your name: ");
    string name = Console.ReadLine();
    _player = new(100, name);


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
          _difficulty = SetDifficulty();
          _dealer = new(_difficulty[1]);
          Table table = new(_player, _dealer, _difficulty[0]);
          table.PlayBlackJack();
          break;
        case 2:
          _showRules.ShowTheRules();
          break;
        case 3:
          _atmController.HandleAtmMenu(_player);
          break;
        case 4:
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

  public int[] SetDifficulty(){
    int[] difficulty = new int[2];
    Console.Clear();
    do{
      Console.WriteLine("1) $2");
      Console.WriteLine("2) $10");
      Console.WriteLine("3) $50");
      Console.WriteLine("4) $100");
      Console.Write("Please choose a Minimum Bet: ");
      difficulty[0] = Convert.ToInt32(Console.ReadLine());
      if(difficulty[0] == 1){difficulty[0] = 2;}
      else if(difficulty[0] == 2){difficulty[0] = 10;}
      else if(difficulty[0] == 3){difficulty[0] = 50;}
      else if(difficulty[0] == 4){difficulty[0] = 100;}
    } while(difficulty[0] < 0 && difficulty[0] > 5);

    Console.Clear();

    do{
      Console.WriteLine("1) 1");
      Console.WriteLine("2) 2");
      Console.WriteLine("3) 3");
      Console.WriteLine("4) 4");
      Console.Write("Please choose how many decks you want to play with: ");
      difficulty[1] = Convert.ToInt32(Console.ReadLine());
    } while(difficulty[1] < 0 && difficulty[1] > 5);

    return difficulty;
  }
}
