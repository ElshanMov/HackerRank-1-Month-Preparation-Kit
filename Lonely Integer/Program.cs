using System.IO;

namespace Lonely_Integer
{
    internal class Program
    {
        public static int lonelyinteger(List<int> a)
        {
            
            return 0;
        }
        //LINQ
        public static int lonelyinteger1(List<int> a)
        {
            
            return a.GroupBy(x => x).Where(a=>a.Count()<2).First().Key;
            
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Program.lonelyinteger(a);

            Console.WriteLine(result);
        }
    }
}