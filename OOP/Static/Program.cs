namespace Static {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(Calculator.Add(2, 4));
        }
    }
}

static class Calculator {
    public static string name;

    public static int Add(int x, int y) => x + y;

    public static int Subtract (int  x, int y) => x - y;

    public static int Multiply(int x, int y) => x * y;

    public static int Divide(int x, int y) => x / y;
}