namespace GuessNumberGame
{
    internal class Game
    {
        public int GuessedNumber { get; set; }
        public int MagicNumber { get; set; }
        public int Guesses { get; set; }

        public Game() {
            MagicNumber = new Random().Next(1, 100);
            Guesses = 0;
            GuessedNumber = 0;
        }

        public int NumberGuess()
        {
            Guesses++;
            Console.Write("What is your guess: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void LowerHigherWin()
        {
            if (GuessedNumber < MagicNumber) { Console.WriteLine("Higher"); }
            else if (GuessedNumber > MagicNumber) { Console.WriteLine("Lower"); }
            else { Console.WriteLine($"You guessed the Magic Number of {MagicNumber} in only {Guesses} guesses"); }
        }

        public static bool Again()
        {
            Console.Write("Would you like to play again ('y'/'n'): ");
            string answer = Console.ReadLine();
            if (answer != null)
            {
                if (answer.ToLower() == "y")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
