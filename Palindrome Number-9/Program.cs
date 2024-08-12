using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any Integer: ");
            int x = int.Parse(Console.ReadLine());

            int y = x;
            int digits = 1;
            for (int i = 0; y/10 != 0; i++)
            {
                digits = digits + 1;
                y = y / 10;
            }

            y = x;
            int reversedNum = 0;
            for (int i = 1; i <= digits; i++)
            {
                int multiple = 1;
                for (int j = 1; j <= digits-i; j++)
                {
                    multiple = multiple*10;
                }
                reversedNum = reversedNum + (y%10)*(multiple);
                y = y/10;
            }

            Console.WriteLine("{0} is a {1} digit number",x,digits);
            Console.WriteLine("The reversed value is {0}", reversedNum);
            if (x < 0)
            {
                Console.WriteLine("Not a Palindrome");
            }
            else if(reversedNum == x)
            {
                Console.WriteLine("{0} is a palindrome.",x);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", x);
            }

            Console.ReadLine();
        }
    }
}
