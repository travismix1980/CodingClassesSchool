class Program
{
  static void Main(string[] args)
  {
    Controller c = new();
    bool flag = true;
    while (flag)
    {
      flag = c.RunMainMenu();
    }
  }
}
