class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();    // spacing

        MathAssignment ma = new("Roberto Rodrigues", "Fractions", "7.3", "8-19");
        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());
        Console.WriteLine();    // spacing

        WritingAssignment wa = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}
