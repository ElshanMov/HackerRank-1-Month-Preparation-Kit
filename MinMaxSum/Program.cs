namespace MinMaxSum
{
    internal class Program
    {
        public static void miniMaxSum(List<int> arr)
        {
            int min = arr[0];
            int max = arr[0];
            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i]<min)
                {
                    min= arr[i];
                }
                if (arr[i]>max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }

            Console.WriteLine($"{sum-max} {sum-min}");
        }
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Program.miniMaxSum(arr);
        }
    }
}