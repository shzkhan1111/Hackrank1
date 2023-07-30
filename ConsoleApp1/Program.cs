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

            //var x = jumpingOnClouds(c , 2);
            //Console.WriteLine(string.Join(", ", permutationEquation(a)));
            //Console.WriteLine(appendAndDelete("y", "yu", 2));

            var x = squares(24, 49);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        public static int squares(int a, int b)
        {
            int c = 0;
            for (int i = a; i <= b; i++ )
            {
                double number = Math.Sqrt(i);
                //var temp = number % 1;
                if(number % 1 ==0)
                {
                    c++;
                }
            }
            return c;
        }


    }
}
