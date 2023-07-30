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
            //List<int> query = new List<int> { 1,2};
            int[] c = new int[] { 0, 0, 1, 0 };
                extraLongFactorials(30);

            //var x = jumpingOnClouds(c , 2);
            //Console.WriteLine(string.Join(", ", permutationEquation(a)));

            Console.ReadKey();
        }
        public static void extraLongFactorials(int n)
        {
            var f = BigInteger.One;
            for (int i = n; i > 1;i--)
            {
                f *= i;
            }
            Console.WriteLine(f);
        }


    }
}
