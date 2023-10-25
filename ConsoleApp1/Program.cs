using LanguageExt;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {

            int[] n = new int[] { 2, 7, 11 };
            TwoSum(n, 9);
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int [] result = new int[2];
            int p1 = 0, p2 = numbers.Length - 1;
            int s = 0;

            while (p1 < p2)
            {
                s = numbers[p2] + numbers[p1];
                if (s > target)
                {
                    p2--;
                }
                else if (s < target)
                {
                    p1++;
                }
                else if (s == target)
                {
                    result[0] = p1+1;
                    result[1] = p2+1;
                    return result;
                }

            }
            return result;
        }











    }
}
