class Result
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int a = 0;
        int b = 0;


        for (int i = 0; i < arr.Count; i++)
        {
            a += arr[i][i];
            b += arr[arr.Count - i - 1][i];
        }

        return Math.Abs(a - b);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine()
                .TrimEnd()
                .Split(' ')
                .Select(int.Parse)
                .ToList());
        }

        Console.WriteLine(Result.diagonalDifference(arr));
    }
}
