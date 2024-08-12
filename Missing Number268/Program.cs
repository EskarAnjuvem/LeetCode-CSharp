using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number268
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] nums = { 3, 1, 2, 5, 4 };

            int totalSum = nums.Length * (nums.Length + 1) / 2;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }

            if (sum != totalSum)
            {
                Console.WriteLine("Missing Number is {0}", (totalSum - sum));
            }
            else
            {
                Console.WriteLine("Missing Number is 0");
            }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Time Elapsed: {0} ms", ts.TotalMilliseconds);

            Console.ReadLine();
        }
    }
}
