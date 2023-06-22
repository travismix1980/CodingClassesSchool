class Program
{
  static void Main(string[] args)
  {
    MainMenu mm = new();
    Score s = new();
    List<IGoal> goalList = new();
    int menuChoice = mm.ShowMenu();
    GotoMenuChoice(menuChoice, s, goalList);
  }

  static void GotoMenuChoice(int choice, Score score, List<IGoal> list)
  {
    switch (choice)
    {
      case 1:
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter a description for your goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points is your goal worth: ");
        int points = Convert.ToInt32(Console.ReadLine());
        list.Add(new SimpleGoal(name, description, points));
        Console.WriteLine($"Name: {list[0].GoalName}, Description: {list[0].GoalDescription}, Points: {list[0].GoalPoints}");
        break;
      case 2:
        Console.WriteLine("You chose List Goals");
        break;
      case 3:
        Console.WriteLine("You chose Save Goals");
        break;
      case 4:
        Console.WriteLine("you chose Load Goals");
        break;
      case 5:
        Console.WriteLine("you chose Record Event");
        break;
      case 6:
        Console.WriteLine($"You have {score.GetScore()} points");
        break;
      case 7:
        Console.WriteLine("You chose quit");
        break;
      default:
        Console.WriteLine("You chose a non existant option");
        break;
    }
  }
}
