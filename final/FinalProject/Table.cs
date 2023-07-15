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
        _player.AddCardToHand(_dealer.Deal());
        _player.CalcHandValue();
      }
      else if (playerChoice == 's')
      {
        if (_player.GetHasStood())
        {
          bjEndFlag = false;
        }
        // run player stand and break
        _player.SetHasStood(true);
        bjEndFlag = false;
      }
      else if (playerChoice == 'd')
      {
        if (_player.GetHasStood())
        {
          bjEndFlag = false;
          //TODO: REWRITE USING player.DoubleDown()
        } else if (_player.CanDoubleDown())
        {
          if (_player.GetCurrentMoney() >= _player.GetCurrentBet())
          {
            _player.AddCardToHand(_dealer.Deal());
            _player.CalcHandValue();
            _player.SetCurrentMoney(-(_player.GetCurrentBet()));
            _player.SetCurrentBet(_player.GetCurrentBet() * 2);
            Console.WriteLine("You have doubled down");
            _player.CalcHandValue();
            bjEndFlag = false;
          }
        }
      }
      // else if (playerChoice == 'p')
      // {
      //   if(_player.CanSplit()){
      //     if(_player.GetCurrentMoney() >= _player.GetCurrentBet()){
      //       var hand = _player.GetHand();
      //       _player.AddCardToSecondHand(hand[1]);
      //       _player.RemoveCardFromHand(1);
      //       _player.AddCardToHand(_dealer.Deal());
      //       _player.AddCardToSecondHand(_dealer.Deal());
      //     }
      //   }
      // }
      // else if (playerChoice == 'i')
      // {
      //   // run player insurance
      //   if(_player.GetCurrentMoney() >= (_player.GetCurrentBet() / 2)){
      //     double insurance = (_player.GetCurrentBet() / 2);
      //     var dealerHand = _dealer.GetHand();
      //     var dealerHiddenCard = dealerHand[0];
      //     if(dealerHiddenCard.GetPipsValue(dealerHiddenCard) == 10){
      //       _player.SetCurrentMoney(insurance * 2);
      //     }
      //   }
      // }
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

  public void TableInterface(Player player, Dealer dealer)
  {
    Console.WriteLine($"Welcome to BlackJack {_player.GetName()}");
    Console.WriteLine($"Min Bet: ${_minBet}  Number of decks in play: {_numOfDecks}  Current Bet: ${player.GetCurrentBet()}  Current Money on you: ${player.GetCurrentMoney()}");
    Console.Write("(h)it (s)tand ");
    if (player.CanDoubleDown())
    {
      Console.Write("(d)ouble down ");
    }
    // if (_player.CanSplit())
    // {
    //   Console.Write("s(p)lit ");
    // }
    // if (player.CanPurchaseInsurance(dealer.GetHand()[0]))
    // {
    //   Console.WriteLine("purchase (i)nsurance");
    // }
    Console.WriteLine("\n\n");

    // show dealer cards
    Console.WriteLine("Dealers Cards");
    Console.WriteLine($"Dealers Hand Value is: {dealer.CalcHandValue()}");
    foreach(var c in _dealer.GetHand()){
      Console.Write($"*{c.GetCardValue()} of {c.GetCardSuit()}* ");
    }
    Console.WriteLine("\n\n");
    // show player cards
    Console.WriteLine("Players Cards");
    Console.WriteLine($"Your hand value is: {player.CalcHandValue()}");
    foreach(var c in _player.GetHand()){
      Console.Write($"*{c.GetCardValue()} of {c.GetCardSuit()}* ");
    }
    Console.WriteLine("\n");
  }
}
