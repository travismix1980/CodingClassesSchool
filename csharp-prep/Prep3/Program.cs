namespace GuessNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again)
            {
                Game game = new();
                while (game.GuessedNumber != game.MagicNumber)
                {
                    game.GuessedNumber = game.NumberGuess();
                    game.LowerHigherWin();
                }
                again = Game.Again();
            }
        }
    }
}
