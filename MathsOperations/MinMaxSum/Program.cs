using System.Numerics;

class Result
{
    public static void miniMaxSum(List<int> arr)
    {
        long minSum = 0;
        long maxSum = 0;

        long totalSum = arr.Sum(n => (long)n);

        minSum = totalSum - arr.Max();
        maxSum = totalSum - arr.Min();

        Console.WriteLine($"{minSum} {maxSum}");

        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
