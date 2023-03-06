namespace PlusMinus
{
    internal class Program
    {
        static void PlusMinus(List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0)
                {
                    positive += 1;
                }
                else if (arr[i] == 0)
                {
                    zero += 1;
                }
                else
                {
                    negative += 1;
                }
            }
            Console.WriteLine(positive / arr.Count);
            Console.WriteLine(negative / arr.Count);
            Console.WriteLine(zero / arr.Count);
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> list = new();
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Program.PlusMinus(list);
        }
    }
}