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
            Console.WriteLine(repeatedString("a" , 1000000000000).ToString());
            Console.ReadKey();
        }

        public static int findA(string s, long n)
        {
            int c = 0;
            for (int i = 0; i < (int) n; i++)
            {
                if (s[i] == 'a')
                {
                    c++;
                }
            }
            return c;
        }
        public static long repeatedString(string s, long n)
        {
            long res = 0;
            string subs = "";
            if (s.Length >= n)
            {
                subs = s.Substring(0, (int)n);
                int x = findA(s, n);
                return x;
            }
            else
            {
                int a = findA(s, s.Length);
                long rem = n %  s.Length;
                int b = findA(s, rem);

                double times = Math.Floor((double)n / (long)s.Length);
                return a * (long)times + b;
                //get string count org
            }
        }

    }
}
