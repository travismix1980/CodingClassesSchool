class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new();
        _shapes.Add(new Square("blue", 3));
        _shapes.Add(new Rectangle("green", 2, 4));
        _shapes.Add(new Circle("red", 2));

        foreach(Shape s in _shapes){
            Console.WriteLine(s.GetType());
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}
