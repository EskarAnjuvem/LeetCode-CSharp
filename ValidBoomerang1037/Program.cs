using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ValidBoomerang1037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            
            int[,] points =
            {
                {-1 , -248},
                {100 , 8},
                {6 , -12}
            };

            int x = (points[1, 0] - points[0, 0]);
            int y = (points[2, 1] - points[0, 1]);
            int z = (points[1, 1] - points[0, 1]);
            int w = (points[2, 0] - points[0, 0]);

            if ((( x * y) - ( z * w)) == 0)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Time Elapsed: {0} ms", ts.TotalMilliseconds);

            Console.ReadLine();
        }
    }
}
