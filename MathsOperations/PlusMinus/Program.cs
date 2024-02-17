class Result
{

    public static void plusMinus(List<int> arr)
    {
        decimal negativeNumbersCount = arr.Count(n => n < 0);
        decimal positiveNumbersCount = arr.Count(n => n > 0);
        decimal zeroNumbersCount = arr.Count(n => n == 0);

        decimal numbersCount = arr.Count();

        decimal negativeRatio = negativeNumbersCount / numbersCount;
        decimal positiveRatio = positiveNumbersCount / numbersCount;
        decimal zeroRatio = zeroNumbersCount / numbersCount;

        Console.WriteLine(negativeRatio.ToString("0.000000"));
        Console.WriteLine(positiveRatio.ToString("0.000000"));
        Console.WriteLine(zeroRatio.ToString("0.000000"));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
