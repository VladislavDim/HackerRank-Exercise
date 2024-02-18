namespace FindMedian
{
    public class Program
    {
        public static int FindMedian(List<int> arr)
        {
            // Sort the list in ascending order
            arr.Sort();

            // Calculate the median
            int middleIndex = arr.Count / 2;

            return arr[middleIndex];
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int median = FindMedian(numbers);
            Console.WriteLine("Median: " + median);
        }
    }
}
