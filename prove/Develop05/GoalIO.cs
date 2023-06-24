public class GoalIO{
  public void SaveGoals(string filename, List<Goal> saveList, Score score){
    filename = filename + ".txt";
    using (StreamWriter outputFile = new(filename)){
      // save points
      outputFile.WriteLine(score.GetScore());
      for(int i = 0; i < saveList.Count; i++){
        outputFile.WriteLine(saveList[i].SaveString);
      }
    }
  }

  public List<Goal> LoadGoals(string filename, Score score){
    filename = filename + ".txt";
    List<Goal> loadList = new();
    string[] lines = System.IO.File.ReadAllLines(filename);
    score.SetScore(Convert.ToInt32(lines[0]));
    for(int i = 1; i < lines.Length; i++){
      string[] lineParts = lines[i].Split("\\");
      if(lineParts[0] == "SimpleGoal"){
        loadList.Add(new SimpleGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToBoolean(lineParts[4])));
      } else if(lineParts[0] == "EternalGoal"){
        loadList.Add(new EternalGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToBoolean(lineParts[4])));
      } else if(lineParts[0] == "ChecklistGoal"){
        loadList.Add(new ChecklistGoal(lineParts[1], lineParts[2], Convert.ToInt32(lineParts[3]), Convert.ToInt32(lineParts[5]), Convert.ToInt32(lineParts[6]), Convert.ToBoolean(lineParts[7]), Convert.ToInt32(lineParts[4])));
      }
    }
    foreach(var goal in loadList){
      goal.SaveToListString();
      goal.SaveToSaveString();
    }
    return loadList;
  }
}
