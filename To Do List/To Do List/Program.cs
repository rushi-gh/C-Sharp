internal class Program
{
    static string[] validInputList = new[] { "S", "A", "U", "R", "E" };
    static List<string> TODOs = new List<string>();

    private static void ShowOptions(List<string> options)
    {
        foreach (var item in options)
        {
            Console.WriteLine(item);
        }
    }

    private static bool HandleInput(string input)
    {
        if (validInputList.Contains(input))
        {
            switch (input)
            {
                case "S":
                    if (TODOs.Count == 0)
                    {
                        Console.WriteLine("TODO List is empty");
                    }
                    else
                    {
                        var todoNum = 1;
                        foreach (var TODO in TODOs)
                        {
                            Console.WriteLine($"{todoNum++}. {TODO}");
                        }
                    }
                    ClearConsole();
                    return true;
                case "A":
                    Console.Write("Enter TODO : ");
                    string? todo = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(todo))
                    {
                        TODOs.Add(todo);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input!");
                    }
                    ClearConsole();
                    return true;
                case "U":
                    if (TODOs.Count > 0)
                    {
                        var todoNum = 1;
                        foreach (var TODO in TODOs)
                        {
                            Console.WriteLine($"{todoNum++}. {TODO}");
                        }
                        Console.WriteLine();
                        Console.Write("Enter Number of TODO to be updated : ");
                        int.TryParse(Console.ReadLine(), out int idx);
                        Console.Clear();
                        if (idx > TODOs.Count)
                        {
                            Console.WriteLine("Index out of bound...");
                            ClearConsole();
                        }
                        else
                        {
                            Console.Write("Enter updated TODO : ");
                            TODOs[--idx] = Console.ReadLine();
                            ClearConsole();
                        }
                    }
                    else
                    {
                        Console.WriteLine("TODO list is empty...");
                        ClearConsole();
                    }
                    return true;
                case "R":
                    if (TODOs.Count > 0)
                    {
                        var todoNum = 1;
                        foreach (var TODO in TODOs)
                        {
                            Console.WriteLine($"{todoNum++}. {TODO}");
                        }
                        Console.WriteLine();
                        Console.Write("Enter Number of TODO to be removed : ");
                        int.TryParse(Console.ReadLine(), out int idx);
                        Console.Clear();
                        if (idx > TODOs.Count)
                        {
                            Console.WriteLine("Index out of bound...");
                            Console.WriteLine("\nPress Any key to continue...");
                            ClearConsole();
                        }
                        else
                        {
                            TODOs.RemoveAt(--idx);
                        }
                    } 
                    else
                    {
                        Console.WriteLine("TODO list is empty...");
                        ClearConsole();
                    }
                    return true;
                case "E":
                    Console.WriteLine("Have Awsome day...");
                    return false;

            }
        }
        Console.WriteLine("Invalid Input");
        ClearConsole();
        return true;
    }

    private static void ClearConsole()
    {
        Console.WriteLine("\nPress Any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to TODOs...");
        ClearConsole();

        List<string> options = new List<string>()
        {
            "What do you want to do?",
            "[S]ee all TODOs",
            "[A]dd TODO",
            "[U]pdate TODO",
            "[R]emove TODO",
            "[E]xit"
        };

        bool appActive = true;
        while (appActive)
        {
            ShowOptions(options);

            string input = Console.ReadLine()?.ToUpper();
            Console.Clear();

            if (!string.IsNullOrWhiteSpace(input))
            {
                appActive = HandleInput(input);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
                Console.WriteLine("Enter any key to Try again...");
                ClearConsole();
            }

        }
    }
}