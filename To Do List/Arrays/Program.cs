internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[5];

        int[] nums = new int[] { 1, 2, 3, 4, 5, 6 };
        int sum = 0;
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);

        int[,] twoDim = new int[2, 3]
        {
            {1, 2, 3 },
            {4, 5, 6 }
        };
    }
}