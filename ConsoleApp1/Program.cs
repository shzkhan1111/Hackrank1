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
            int[] num = new int[] { 1, 2, 3, 1 };
            ContainsDuplicate(num);
            Console.ReadKey();
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            System.Collections.Generic.HashSet<int> set = new System.Collections.Generic.HashSet<int>();
            for (int i = 0;i < nums.Length;i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                set.Add(nums[i]);
            }

            return false;
        }












    }
}
