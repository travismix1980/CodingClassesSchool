public class Table{
  private int _numOfDecks; // number of decks in play
  private int _minBet; // the minimum bet for the table and also plays into difficulty

  public Table(int minBet, int numOfDecks){
    _minBet = minBet;
    _numOfDecks = numOfDecks;
  }

  public int GetNumOfDecks(){
    return _numOfDecks;
  }

  public void PlayRound(){}
}
