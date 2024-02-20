class Result
{

    public static int[] countingSort(List<int> arr)
    {
        int[] freqArr = new int[arr.Count];

        foreach (int num in arr)
        {
            freqArr[num]++;
        }

        return freqArr;
    }
}



class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int[] result = Result.countingSort(arr);

        Console.WriteLine(String.Join(" ", result));

    }
}
