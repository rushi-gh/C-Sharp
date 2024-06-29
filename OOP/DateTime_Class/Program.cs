internal class Program
{
    private static void ShowDetails(DateTime date)
    {
        Console.WriteLine($"Day of Independance : {date.Day}");
        Console.WriteLine($"Month of Independance : {date.Month}");
        Console.WriteLine($"Year of Independance : {date.Year}");
        Console.WriteLine($"Weekday of Independance : {date.DayOfWeek}");
        Console.WriteLine($"Weekday of Independance : {date.DayOfYear}");
        Console.WriteLine($"Independance day : {date.Day}-{date.Month}-{date.Year}");
        Console.WriteLine("-------------------------------------------------------");
    }
    private static void Main(string[] args)
    {
        DateTime independanceDay = new DateTime(1947, 8, 15);
        ShowDetails(independanceDay);
        ShowDetails(independanceDay.AddYears(1));

    }
}