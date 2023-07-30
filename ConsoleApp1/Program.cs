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
            Console.WriteLine(appendAndDelete("y", "yu", 2));


            Console.ReadKey();
        }
        public static string appendAndDelete(string s, string t, int k)
        {
            int c = 0;
            while (s[c] == t[c])
            {
                c++;
                if (c >= s.Length || c >= t.Length)
                {
                    break;
                }
            }
            int lenToRm = s.Length - c;
            int lenToAdd = t.Length - c;
            int cost = lenToRm + lenToAdd;
            int sum = cost - k;

            if (sum == 0)
            {
                return "Yes";
            }
            else if (sum > 0)
            {
                //cost higher than k
                return "No";
            }
            else
            {
                int opr = Math.Abs(sum);
                int totalStringLen = s.Length + t.Length;
                if (k >= totalStringLen)
                {
                    return "Yes";
                }
                else if (opr %2 == 0)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }





        }


    }
}
