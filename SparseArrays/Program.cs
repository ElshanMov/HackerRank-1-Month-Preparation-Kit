using System.IO;

namespace SparseArrays
{
    internal class Program
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            List<int> result = new();
            int r;
            for (int i = 0; i < queries.Count; i++)
            {
                r = 0;
                for (int j = 0; j < strings.Count; j++)
                {
                    if (queries[i] == strings[j])
                    {
                        r += 1;
                    }
                }
                result.Add(r);
            }
            return result;
        }
        //LINQ
        public static List<int> matchingStrings2(List<string> strings, List<string> queries)
        {
            return queries.Select(query =>
            {
                 return strings.Where(str => query == str).Count();
            }).ToList();
        }
        static void Main(string[] args)
        {
            int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> strings = new List<string>();

            for (int i = 0; i < stringsCount; i++)
            {
                string stringsItem = Console.ReadLine();
                strings.Add(stringsItem);
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> queries = new List<string>();

            for (int i = 0; i < queriesCount; i++)
            {
                string queriesItem = Console.ReadLine();
                queries.Add(queriesItem);
            }

            List<int> res = Program.matchingStrings(strings, queries);

            Console.WriteLine(String.Join("\n", res));
        }
    }
}