public class Score{
  private int _score;

/// <summary>
/// Constructor sets _score to 0
/// </summary>
  public Score(){
    _score = 0;
  }

/// <summary>
/// Gets the _score and returns it
/// </summary>
/// <returns>_score</returns>
  public int GetScore(){
    return _score;
  }

/// <summary>
/// sets the score by increasing it by scoreIncrease
/// </summary>
/// <param name="scoreIncrease">(int) how much to increase the score by</param>
  public void SetScore(int scoreIncrease){
    _score += scoreIncrease;
  }
}
