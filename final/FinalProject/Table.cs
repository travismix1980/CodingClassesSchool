public class Table
{
  private int _numOfDecks; // number of decks in play
  private int _minBet; // the minimum bet for the table and also plays into difficulty
  Player _player;
  Dealer _dealer;

  public Table(Player player, Dealer dealer, int minBet)
  {
    _player = player;
    _dealer = dealer;
    _minBet = minBet;
    SetNumOfDecks(dealer.GetNumOfDecks());
  }

  public int GetNumOfDecks()
  {
    return _numOfDecks;
  }

  public void SetNumOfDecks(int numOfDecks)
  {
    _numOfDecks = numOfDecks;
  }

  public int GetMinBet()
  {
    return _minBet;
  }

  public void SetMinBet(int minBet)
  {
    _minBet = minBet;
  }

  public void PlayBlackJack()
  {
    _player.SetCurrentBet(0);
    TableInterface();
    _player.Bet(_minBet);
    bool bjEndFlag = true;
    while (bjEndFlag)
    {
      Console.Clear();
      TableInterface();
      // have dealer deal starting cards
      Console.WriteLine("What would you like to do? ");
      char playerChoice = Convert.ToChar(Console.ReadLine().ToLower());
      if (playerChoice == 'h')
      {
        // run player hit
      }
      else if (playerChoice == 's')
      {
        // run player stand and break
      }
      else if (playerChoice == 'd')
      {
        // run player double down and break
      }
      else if (playerChoice == 'p')
      {
        // run player split
      }
      else if (playerChoice == 'i')
      {
        // run player insurance
      }
    }
    // handle dealer turn

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

  public void TableInterface()
  {
    Console.WriteLine($"Min Bet: {_minBet}  Number of decks in play: {_numOfDecks}  Current Bet: ${_player.GetCurrentBet()}  Current Money on you: ${_player.GetCurrentMoney()}");
    Console.Write("(h)it (s)tand ");
    if (_player.CanDoubleDown())
    {
      Console.Write("(d)ouble down ");
    }
    if (_player.CanSplit())
    {
      Console.Write("s(p)lit ");
    }
    if (_player.CanPurchaseInsurance(new Card("Hearts", "Ace")))
    {
      Console.WriteLine("purchase (i)nsurance");
    }
    Console.WriteLine("\n\n");

    // show dealer cards
    // show player cards
  }
}
