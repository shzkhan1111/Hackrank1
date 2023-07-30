using LanguageExt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //List<int> a = new List<int> { 5,2,1,3,4};
            //int[] c = new int[] { 5,4,4,2,2,8};

            //var x = jumpingOnClouds(c , 2);
            //Console.WriteLine(string.Join(", ", permutationEquation(a)));
            //Console.WriteLine(appendAndDelete("y", "yu", 2));

            List<int> query = new List<int> { 5, 4, 4, 2, 2, 8 };
            var x = cutTheSticks(query);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        //public static int squares(int a, int b)
        //{
        //    int c = 0;
        //    int x =(int) Math.Ceiling(Math.Sqrt(a));
        //    int y = (int)Math.Floor(Math.Sqrt(b));

        //    c =  y - x + 1;
        //    return c;
        //}

        //public static int getMin(List<int> arr)
        //{
        //    if (arr.Count >= 0)
        //    {
        //        int min = arr[0];
        //        for (int i = 1; i < arr.Count(); i++)
        //        {
        //            if (min > arr[i] )
        //            {
        //                min = arr[i];
        //            }
        //        }
        //        return min;
        //    }
        //    else
        //    {
        //        return 0;
        //    }

        //}
        public static void sort(List<int> arr)
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = i; j < arr.Count(); j++)
                {
                    if (arr[i] > arr[j])
                    {
                        arr[i] = arr[i] + arr[j];
                        arr[j] = arr[i] - arr[j];
                        arr[i] = arr[i] - arr[j];
                    }
                }
            }
        }
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> res = new List<int>();
            sort(arr);
            int index = 0;
            int min = 0;
            int removed = 0;
            int count = arr.Count();
            res.Add(count);
            while (index < count)
            {
                min = arr[index];
                for (int i = index; i < count; i++)
                {
                    arr[i] = arr[i] - min;
                    if (arr[i] == 0)
                    {
                        removed++;
                    }
                }
                int x = count - removed;
                if (x > 0)
                {
                    res.Add(x);
                }
                index = removed;
            }

            return res;
        }


    }
}
