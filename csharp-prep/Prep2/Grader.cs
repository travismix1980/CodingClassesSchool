
internal class Grader
{
  #nullable enable
  public string? Grade { get; set; }
  public string? GradeLetter { get; set; }

  public string? Passed { get; set; }
  #nullable disable

  /// <summary>
  /// Gets grade from student in numerical form
  /// </summary>
  public void GetStudentGrade()
  {
    Console.Write("Please Enter your Grade in Numeric Form: ");
    Grade = Console.ReadLine();
  }

  /// <summary>
  /// Gets the students Grade letter
  /// </summary>
  public void GetGradeLetter()
  {
    if (Grade != null)
    {
      int grade = Convert.ToInt32(Grade);
      if (grade >= 90)
      {
        GradeLetter = "A";
        Passed = "passed";

      }
      else if (grade >= 80)
      {
        GradeLetter = "B";
        Passed = "passed";
      }
      else if (grade >= 70)
      {
        GradeLetter = "C";
        Passed = "passed";
      }
      else if (grade >= 60)
      {
        GradeLetter = "D";
        Passed = "failed";
      }
      else
      {
        GradeLetter = "F";
        Passed = "failed";
      }
    }

  }

  /// <summary>
  /// figures out if students grade gets a + or -
  /// added to their grade letter
  /// </summary>
  public void PlusOrMinus()
  {
    int lastDigit;

    // get the last digit
    if (Grade != null)
    {
      lastDigit = Int32.Parse(Grade[^1].ToString());
    }
    else
    {
      Console.WriteLine("Error!!! A grade was not entered yet");
      return;
    }

    // is last digit >= 7 or < 3
    switch (lastDigit)
    {
      case >= 7:
        GradeLetter += "+";
        break;
      case < 3:
        GradeLetter += "-";
        break;
    }
  }
}
