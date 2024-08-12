using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any Integer: ");
            int x = int.Parse(Console.ReadLine());


            int y = x;
            int reversedNum = 0;

            while (y != 0)
            {
                reversedNum = reversedNum * 10 + (y%10);
                y = y / 10;
            }
                        
            
            Console.WriteLine("The reversed value is {0}", reversedNum);
            if (x < 0)
            {
                Console.WriteLine("Not a Palindrome");
            }
            else if (reversedNum == x)
            {
                Console.WriteLine("{0} is a palindrome.", x);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", x);
            }

            Console.ReadLine();
        }
    }
}
