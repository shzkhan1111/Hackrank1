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

            var x = libraryFine(2,7,1014,1,1,1015);
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
        public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            if (y1 > y2)
            {
                return (y1 - y2) * 10000;
            }
            else if (y1 == y2 && m1 > m2)
            {
                return (m1 - m2) * 500;
            }
            else if (y1 == y2 && m1 == m2 && d1 > d2)
            {
                return (d1 - d2) * 15;
            }
            else
            {
                return 0;
            }
        }


    }
}
