using System.Drawing;
public class LevelingSystem
{
  public int CurrentLevel { get; set; }
  public double NextLevelPoints { get; set; }
  public double LastLevelPoints { get; set; }
  const string FILENAME = "levelfile.txt";

  public LevelingSystem(int level)
  {
    CurrentLevel = level;
    LastLevelPoints = (CurrentLevel - 1) * 100 * 1.25;
    NextLevelPoints = (CurrentLevel * 100) * 1.25 + LastLevelPoints;
  }

  public void CheckForLevelUp(Score score)
  {
    if (score.GetScore() >= NextLevelPoints)
    {
      CurrentLevel++;
      LastLevelPoints = ((CurrentLevel - 1) * 100) * 1.25;
      NextLevelPoints = ((CurrentLevel * 100) * 1.25) + LastLevelPoints;
      if(CurrentLevel % 2 == 0){
        TrainAnimation();
      }else{
        PendulumAnimation();
      }
      Console.WriteLine("Congrats, You Leveled up!");
    }
  }

  public void SaveLevel(Score score){
    using(StreamWriter output = new StreamWriter(FILENAME)){
      output.WriteLine($"{CurrentLevel}\\{LastLevelPoints}\\{NextLevelPoints}\\{score.GetScore()}");
    }
  }

  public void LoadLevel(Score score){
    string[] lines = System.IO.File.ReadAllLines(FILENAME);
    string[] lineParts = lines[0].Split("\\");
    CurrentLevel = Convert.ToInt32(lineParts[0]);
    LastLevelPoints = Convert.ToInt32(lineParts[1]);
    NextLevelPoints = Convert.ToInt32(lineParts[2]);
    score.SetScore(Convert.ToInt32(lineParts[3]));
  }

  // borrowed the animations from https://www.michalbialecki.com/en/2018/05/25/how-to-make-you-console-app-look-cool/
  // and shortened them timewise
  public void TrainAnimation()
  {
    for (int i = 0; i < 1; i++)
    {
      for (int j = 0; j < 30; j++)
      {
        Console.Clear();

        // steam
        Console.Write("       . . . . o o o o o o");
        for (int s = 0; s < j / 2; s++)
        {
          Console.Write(" o");
        }
        Console.WriteLine();

        var margin = "".PadLeft(j);
        Console.WriteLine(margin + "                _____      o");
        Console.WriteLine(margin + "       ____====  ]OO|_n_n__][.");
        Console.WriteLine(margin + "      [________]_|__|________)< ");
        Console.WriteLine(margin + "       oo    oo  'oo OOOO-| oo\\_");
        Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+");

        Thread.Sleep(100);
      }
    }
  }

  public void PendulumAnimation()
  {
    var counter = 0;
    for (int i = 0; i < 15; i++)
    {
      Console.Clear();

      switch (counter % 4)
      {
        case 0:
          {
            Console.WriteLine("╔════╤╤╤╤════╗");
            Console.WriteLine("║    │││ \\   ║");
            Console.WriteLine("║    │││  O  ║");
            Console.WriteLine("║    OOO     ║");
            break;
          };
        case 1:
          {
            Console.WriteLine("╔════╤╤╤╤════╗");
            Console.WriteLine("║    ││││    ║");
            Console.WriteLine("║    ││││    ║");
            Console.WriteLine("║    OOOO    ║");
            break;
          };
        case 2:
          {
            Console.WriteLine("╔════╤╤╤╤════╗");
            Console.WriteLine("║   / │││    ║");
            Console.WriteLine("║  O  │││    ║");
            Console.WriteLine("║     OOO    ║");
            break;
          };
        case 3:
          {
            Console.WriteLine("╔════╤╤╤╤════╗");
            Console.WriteLine("║    ││││    ║");
            Console.WriteLine("║    ││││    ║");
            Console.WriteLine("║    OOOO    ║");
            break;
          };
      }

      counter++;
      Thread.Sleep(200);
    }
  }


}
