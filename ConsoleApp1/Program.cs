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
            var dd = encryption("chillout");
            Console.WriteLine(dd.ToString());
            //Console.WriteLine(dd[1].ToString());

            Console.ReadKey();
        }

        public static string encryption(string s)
        {
            int length = s.Length;
            var row = (int) Math.Floor(Math.Sqrt(length));
            var col = (int) Math.Ceiling(Math.Sqrt(length));
            int st = 0;
            char temp = new char();
            string res = "";
            for (int j = 0; j < col; j++)
            {
                st = j;
                for (int i = 0; i < col; i++)
                {
                    if (st < length)
                    {
                        temp = s[st];
                        res = res + temp;
                    }
                    st = st + col;
                }
                res = res + ' ';
            }

            res = res.Substring(0,res.Length - 1);
            return res;
        }




    }
}
