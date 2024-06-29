class Rectangle
{
    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void PrintDimensions()
    {
        Console.WriteLine($"Width of Rectangle : {Width}");
        Console.WriteLine($"Height of Rectangle : {Height}");
        Console.WriteLine("--------------------------------");
    }

    public int GetCircumference() => 2 * (Height + Width);

    public int GetArea() => (Height * Width);

    public void Print()
    {
        PrintDimensions();
        Console.WriteLine($"Area of Rectangle : {GetArea()}");
        Console.WriteLine($"Circumference of Rectangle : {GetCircumference()}");
        Console.WriteLine("================================");
    }
}


internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle one = new Rectangle(2, 9);
        Rectangle two = new Rectangle(3, 5);

        one.Print();
        two.Print(); 
    }
}