internal class Program
{
    private static void Main(string[] args)
    {
        bool @continue = true;
        while (@continue)
        {
            Console.Write("Enter first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int ans = 0;
            Console.WriteLine("For Addition Press 1");
            Console.WriteLine("For Substraction Press 2");
            Console.WriteLine("For Multiplication Press 3");
            Console.WriteLine("For Division Press 4");
            Console.WriteLine();
            
            int opr = int.Parse(Console.ReadLine());
            switch (opr)
            {
                case 1:
                    ans = num1 + num2;
                    break;
                case 2:
                    ans = num1 - num2;
                    break;
                case 3:
                    ans = num1 * num2;
                    break;
                case 4:
                    ans = num1 / num2;
                    break;
            }

            Console.WriteLine($"Ans = {ans}");
            Console.WriteLine();

            Console.WriteLine("Press 1 for another opration");
            Console.WriteLine("Else press 0");
            Console.WriteLine();

            int inp = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (inp == 0)
            {
                @continue = false;
            }
            Console.Clear();
        }
    }
}