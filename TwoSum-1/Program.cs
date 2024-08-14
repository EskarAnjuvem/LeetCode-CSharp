using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = InputArray();
            int[] indexArray;

            Console.WriteLine("Your Input Array is: ");
            for(int i=0; i < intArray.Length; i++)
            {
                Console.Write("{0} ",intArray[i]);
            }
            
            Console.Write("\nInput the Target Sum required:");
            int targetSum = int.Parse(Console.ReadLine());

            indexArray = PositionsTarget(intArray, targetSum);
            Console.Write("The indexes for which Target Sum is met:");
            foreach (int index in indexArray)
            {
                Console.Write(index + " ");
            }



            Console.ReadLine();

        }

        public static int[] InputArray()
        {
            Console.WriteLine("Input the length of Integer array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] integerArray = new int[arrayLength];
            Console.WriteLine("Input a Sequence of Integers, in separate lines: ");
            for (int i = 0; i < arrayLength; i++) 
            {
                integerArray[i] = int.Parse(Console.ReadLine());
            }
            return integerArray;
        }

        public static int[] PositionsTarget(int[] arr, int t)
        {
            int[] indexArray = new int[2];

            for (int i = 0; i< arr.Length-1; i++)
            {
                for(int j= i+1; j<arr.Length; j++)
                {
                    if (arr[j] == (t - arr[i]))
                    {
                        indexArray[0] = i;
                        indexArray[1] = j;
                        return (indexArray);
                    }                    

                }
            }
            indexArray[0] = -1;
            indexArray[1] = -1;
            return indexArray;
            

        }

        
    }
}
