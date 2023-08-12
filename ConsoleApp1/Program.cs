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

            //List<int> query = new List<int> { 1,2,2,3};
            //List<List<int>> obs = new List<List<int>>();

            //obs.Add(new List<int> { 5, 5 });
            //obs.Add(new List<int> { 4, 2 });
            //obs.Add(new List<int> { 2, 3 });
            List<string> query = new List<string> { "10101", "11110", "00010" };
            var dd = taumBday(95677, 39394, 86983, 311224, 311224);
            Console.WriteLine(dd.ToString());
            //Console.WriteLine(dd[1].ToString());

            Console.ReadKey();
        }

        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            long blackCost = Math.Min(bc, wc + z);
            long whiteCost = Math.Min(wc, bc + z);

            return (long)b * blackCost + (long)w * whiteCost;
        }



    }
}
