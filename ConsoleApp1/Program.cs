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

            List<int> query = new List<int> { 19 , 10 , 12 ,10 ,24 , 25, 22};
            Console.WriteLine(nonDivisibleSubset(4 , query).ToString());
            Console.ReadKey();
        }

        public static int nonDivisibleSubset(int k, List<int> s)
        {
            Dictionary<int,int> d = new Dictionary<int,int>();
            int counter = 0;
            foreach (int p in s)
            {
                int x = p % k;
                if (d.ContainsKey(x))
                {
                    d[x]++;
                }
                else
                {
                    d.Add(x, 1);
                }
            }

            if (d.ContainsKey(0))
            {
                counter++;
            }
            int te = 0 , s1 = 0, s2 = 0;
            for (int i = 1; i <= k/2; i++)
            {
                te = k - i;
                if (te == i)
                {
                    if (d.TryGetValue(i, out s1))
                    {
                        counter++;
                    }
                    else
                    {
                        
                    }

                }
                else {
                    if (d.TryGetValue(i, out s1))
                    {

                    }
                    else
                    {
                        s1 = 0;
                    }

                    if (d.TryGetValue(te, out s2))
                    {

                    }
                    else
                    {
                        s2 = 0;
                    }

                    int max = s1 >= s2 ? s1 : s2;
                    counter += max;

                }

            }

            return counter;
        }

    }
}
