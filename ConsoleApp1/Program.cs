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
            var dd = minimumDistances(new List<int> { 1,1});
            Console.WriteLine(dd.ToString());
            //Console.WriteLine(dd[1].ToString());

            Console.ReadKey();
        }

        public static int minimumDistances(List<int> a)
        {
            var dic = new Dictionary<int, List<int>>();
            int c = 1;
            foreach (int n in a)
            {
                if (dic.ContainsKey(n))
                {
                    if (dic[n][0] == 0)
                    {
                        dic[n][0] = c;
                    }
                    else if (dic[n][1] == 0)
                    {
                        dic[n][1] = c;
                    }
                }
                else
                {
                    dic.Add(n, new List<int> { c, 0 });
                }


                c++;
            }

            int min = int.MaxValue;
            int sub = 0;
            bool flag = false;
            foreach (var x in dic)
            {
                if (x.Value[1] != 0)
                {
                    sub = x.Value[1] - x.Value[0];
                    if (sub < min)
                    {
                        min = sub;
                        flag = true;
                    }
                }
            }
            min = flag ? min : -1;

            return min;
        }



    }
}
