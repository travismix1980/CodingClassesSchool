public class ShowRules{
  private string _rules;
  public ShowRules(){
    _rules = @"
    In Game Controls
    -----------------------------------------------------
    All in game controls will be signified by a () around
    the key to press.  Example: (h)it press h to hit

    BlackJack Rules
    -----------------------------------------------------
    Goal: To get 21 or as close to 21 as possible.  Cards
    are worth the number on the card.  Jack, Queen, and
    King are all worth 10 points.  Aces are worth 1 or 11.
    The dealer can only hit on a 16 or lower.

    Definitions
    -----------------------------------------------------
    Stand: To say you don't want any more cards.

    Hit: To ask for another card

    Double Down: To take double your bet and get one more
    card and no more after that last card.

    Split: If you are dealt two matching cards you can chose
    to split them and receive a new card for each one.  You
    must also double your bet to do this.  Each hand is then
    played separatly.

    BlackJack: A hand total of 21

    Natural BlackJack: Being dealt a 21 in your first two
    cards.

    Purchase Insurance: If the dealers face up card is an
    Ace you can purchase insurance against the dealers hand
    being a BlackJack. If the dealer has a blackjack then
    if you have purchased insurance you get a 2/1 payout
    instead of losing your bet.

    Payouts
    -----------------------------------------------------
    Blackjack: 3:2
    Beat the Dealer without BlackJack: 1:1
    Tie: Get your original bet back
    Dealer Wins: lose your bet.
    Insurance: 2:1 Payout if Dealer has BlackJack
    ";
  }

  public void ShowTheRules(){
    Console.WriteLine(_rules);
    Console.Write("Please press ENTER to return to the menu: ");
    while(Console.ReadKey(true).Key != ConsoleKey.Enter){}
  }
}
