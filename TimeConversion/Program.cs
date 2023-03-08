using System.Globalization;
using System.IO;

namespace TimeConversion
{
    internal class Program
    {
        //String Manipulation
        public static string timeConversion(string s)
        {
            string process = s.Substring(8, 2);
            s = s.Substring(0, 8);
            int processPM= Convert.ToInt32(s.Substring(0, 2));
            if (process=="AM")
            {
                if (s.Contains("12"))
                {
                    s = s.Replace("12", "00");
                }
            }
            else
            {
                if (!s.Contains("12"))
                {
                    processPM += 12;
                    s = s.Insert(0, processPM.ToString());
                    s = s.Remove(2, 2);
                }
                
            }
            return s;
        }

        //Parse to DateTime
        public static string timeConversion2(string s) {
            // tt=> AM|PM      CultureInfo.InvariantCulture=>provide to globalization
            var dt = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
            return $"{dt:HH:mm:ss}";
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = Program.timeConversion(s);

            Console.WriteLine(result);
        }
    }
}