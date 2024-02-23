namespace FlippingTheMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> A = new List<List<int>> {
            new List<int> {1, 2, 3, 4},
            new List<int> {5, 6, 7, 8},
            new List<int> {9, 10, 11, 12},
            new List<int> {13, 14, 15, 16}
        };

            int result = flippingMatrix(A);
            Console.WriteLine("Result: " + result);
        }
        public static int flippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int n = matrix.Count, m = matrix[0].Count;
            int cur, right, down, diag, ans;
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    cur = matrix[i][j];
                    right = matrix[i][m - j - 1];
                    down = matrix[n - i - 1][j];
                    diag = matrix[n - i - 1][m - j - 1];
                    ans = Math.Max(Math.Max(cur, right), Math.Max(down, diag));
                    sum += ans;
                }
            }
            return sum;
        }
    }
}
