internal class Program
{
    private static void Main()
    {
        List <int> ints = new List <int> ();
        Console.WriteLine($"Size of ints list : {ints.Count}");

        ints.Add(1);
        Console.WriteLine($"Size of ints list : {ints.Count}");


        Console.WriteLine("-----------------------------------");


        var days = new List<string>()
        {
            "Sunday",
            "Monday",
            "Tuesday",
            "Thursday",
            "Friday",
            "Saturday"
        };

        foreach (var item in days)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();


        days.Remove("Monday");
        foreach (var item in days)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        days.RemoveAt(days.Count - 1);
        foreach (var item in days)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        days.AddRange(new[] { "Jan", "Feb", "Mar" });
        foreach (var item in days)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Index of Thursday : {days.IndexOf("Thursday")}");
        Console.WriteLine($"Index of Monday : {days.IndexOf("Monday")}");

        Console.WriteLine("Contains Monday " + days.Contains("Monday"));
        Console.WriteLine("Contains Thursday " + days.Contains("Thursday"));


        days.Clear();
    }
}