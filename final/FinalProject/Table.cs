public class Table{
  private int _numOfDecks; // number of decks in play
  private int _minBet; // the minimum bet for the table and also plays into difficulty
  private int[] difficulty = new int[2];

  public Table(){

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

  public void PlayBlackJack(){
    Console.WriteLine("Playing BlackJack");
  }

  public int[] SetDifficulty(){
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
    } while(difficulty[0] < 0 && difficulty[0] > 5);

    return difficulty;
  }
}
