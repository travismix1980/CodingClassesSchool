using System;

class Program
{
  static void Main(string[] args)
  {
    Grader grader = new Grader();
    grader.GetStudentGrade();
    grader.GetGradeLetter();
    grader.PlusOrMinus();

    // output student grade letter and if they passed
    Console.WriteLine($"You got a {grader.GradeLetter} and {grader.Passed} the class");
  }


}
