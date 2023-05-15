namespace Week5Encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new();
            Fraction f2 = new(5);
            Fraction f3 = new(3, 4);
            Fraction f4 = new(1, 3);

            Console.WriteLine("Fraction 1");
            Console.WriteLine(f1.GetFractionString());
            Console.WriteLine(f1.GetDecimalValue());

            Console.WriteLine("Fraction 2");
            Console.WriteLine(f2.GetFractionString());
            Console.WriteLine(f2.GetDecimalValue());

            Console.WriteLine("Fraction 3");
            Console.WriteLine(f3.GetFractionString());
            Console.WriteLine(f3.GetDecimalValue());

            Console.WriteLine("Fraction 4");
            Console.WriteLine(f4.GetFractionString());
            Console.WriteLine(f4.GetDecimalValue());
        }
    }
}
