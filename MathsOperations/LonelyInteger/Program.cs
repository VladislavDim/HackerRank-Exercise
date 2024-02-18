class Result
{
    public static int lonelyinteger(List<int> numbers)
    {
        int uniqueNumber = 0;

        // Perform bitwise XOR on all numbers in the list
        foreach (int number in numbers)
        {
            uniqueNumber ^= number;
        }

        return uniqueNumber;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> a = Console.ReadLine()
            .TrimEnd()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);

    }
}
