public class Table{
  private int _numOfDecks; // number of decks in play
  private int _minBet; // the minimum bet for the table and also plays into difficulty
  Player _player;
  Dealer _dealer;

  public Table(){
    Console.Write("What is your name: ");
    string name = Console.ReadLine();
    _player = new(100, name);
    _dealer = new(_numOfDecks);
  }

  public int GetNumOfDecks(){
    return _numOfDecks;
  }

  public void SetNumOfDecks(int numOfDecks){
    _numOfDecks = numOfDecks;
  }

  public int GetMinBet(){
    return _minBet;
  }

  public void SetMinBet(int minBet){
    _minBet = minBet;
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

    public void PlayBlackJack(){
      TableInterface();
    // player places bet greater or equal to min bet
    // dealer deals two cards to player and dealer with the first dealer card hidden in a one each then repeat fashion
    // if dealer showing ace card player is offered insurance
    // if player purchases insurance the dealer checks for blackjack and if blackjack then dealer pays insurance
    // dealer checks cards for blackjack and if blackjack all players with less than blackjack lose
    // if both player and dealer have blackjack then we have a push and player gets back initial bet and play restarts
    // if neither player or dealer have blackjack play continues
    // player choses hit stand double down split
    // dealers turn hits with less than 17 otherwise stands
    // play continues till player stand or either player or dealer bust
    // end of round pay winners loser loses bet
  }

  public void TableInterface(){
    Console.WriteLine($"Min Bet: {_minBet} Number of decks in play: {_numOfDecks} Current Bet: {_player.GetCurrentBet()}");
    Console.Write("(h)it (s)tand ");
    if(_player.CanDoubleDown()){
      Console.Write("(d)ouble down ");
    }
    if(_player.CanSplit()){
      Console.WriteLine("s(p)lit ");
    }
    if(_player.CanPurchaseInsurance(new Card("Hearts", "Ace"))){
      Console.WriteLine("(p)urchase insurance");
    }
    Console.WriteLine("\n\n");
  }
}
