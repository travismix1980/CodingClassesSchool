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
    bool gameLoopFlag = true;
    while (gameLoopFlag)
    {
      Console.WriteLine("\n\nNew Round");
      // clear player and dealer hands
      _player.GetHand().Clear();
      _player.GetSecondHand().Clear();
      _dealer.GetHand().Clear();
      _player.SetHasStood(false);
      _dealer.SetHasStood(false);
      _player.SetHasBusted(false);
      _dealer.SetHasBusted(false);
      _player.SetCurrentBet(0);
      Console.WriteLine($"The minimum bet is ${_minBet}");
      _player.Bet(_minBet);
      _player.AddCardToHand(_dealer.Deal());
      _dealer.AddCardToHand(_dealer.Deal());
      _player.AddCardToHand(_dealer.Deal());
      _dealer.AddCardToHand(_dealer.Deal());
      TableInterface(_player, _dealer);

      bool bjEndFlag = true;
      while (bjEndFlag)
      {
        Console.Clear();
        TableInterface(_player, _dealer);
        // have dealer deal starting cards
        Console.WriteLine("What would you like to do? ");
        char playerChoice = Convert.ToChar(Console.ReadLine().ToLower());
        if (playerChoice == 'h')
        {
          if (_player.GetHasStood())
          {
            bjEndFlag = false;
          }
          _player.Hit(_dealer);
          _player.HasBusted(_player.GetHandValue());
          if (_player.GetHasBusted())
          {
            bjEndFlag = false;
            TableInterface(_player, _dealer);
            Console.Write("You have busted, please press ENTER to continue: ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
          }
        }
        else if (playerChoice == 's')
        {
          if (_player.GetHasStood())
          {
            bjEndFlag = false;
          }
          // run player stand and break
          _player.Stand();
          _player.HasBusted(_player.GetHandValue());
          bjEndFlag = false;
          if (_player.GetHasBusted())
          {
            bjEndFlag = false;
            TableInterface(_player, _dealer);
            Console.Write("You have busted, please press ENTER to continue: ");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
          }
        }
        else if (playerChoice == 'd')
        {
          if (_player.GetHasStood())
          {
            bjEndFlag = false;
          }
          else if (_player.CanDoubleDown())
          {
            _player.DoubleDown(_dealer);
            _player.HasBusted(_player.GetHandValue());
            if (_player.GetHasBusted())
            {
              bjEndFlag = false;
              TableInterface(_player, _dealer);
              Console.Write("You have busted, please press ENTER to continue: ");
              while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            }
          }
        }
      }
      //handle dealer turn
      bool dealerEndFlag = true;
      while(dealerEndFlag){
        TableInterface(_player, _dealer);
        if(_dealer.GetHandValue() < 17){
          _dealer.Hit(_dealer);
          Console.WriteLine("Dealer Hits");
        } else{
          Console.WriteLine("Dealer Stands");
          dealerEndFlag = false;
        }
      }
      // process payouts
    }
  }

  public void TableInterface(Player player, Dealer dealer)
  {
    Console.WriteLine($"Welcome to BlackJack {_player.GetName()}");
    Console.WriteLine($"Min Bet: ${_minBet}  Number of decks in play: {_numOfDecks}  Current Bet: ${player.GetCurrentBet()}  Current Money on you: ${player.GetCurrentMoney()}");
    Console.Write("(h)it (s)tand ");
    if (player.CanDoubleDown())
    {
      Console.Write("(d)ouble down ");
    }
    Console.WriteLine("\n\n");

    // show dealer cards
    Console.WriteLine("Dealers Cards");
    Console.WriteLine($"Dealers Hand Value is: {dealer.CalcHandValue()}");
    foreach (var c in _dealer.GetHand())
    {
      Console.Write($"*{c.GetCardValue()} of {c.GetCardSuit()}* ");
    }
    Console.WriteLine("\n\n");
    // show player cards
    Console.WriteLine("Players Cards");
    Console.WriteLine($"Your hand value is: {player.CalcHandValue()}");
    foreach (var c in _player.GetHand())
    {
      Console.Write($"*{c.GetCardValue()} of {c.GetCardSuit()}* ");
    }
    Console.WriteLine("\n");
  }
}
