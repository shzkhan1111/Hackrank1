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

            List<int> query = new List<int> { 0, 1   , 0, 0, 0, 1, 0 };
            Console.WriteLine(jumpingOnClouds(query).ToString());
            Console.ReadKey();
        }


        public static int jumpingOnClouds(List<int> c)
        {
            int res = 0;
            int indexer = 0;
            do
            {
                if (indexer == c.Count() - 2)
                {
                    res++;
                    indexer++;
                    break;
                }
                if (indexer == c.Count() - 3)
                {
                    res++;
                    indexer += 2;
                    break;
                }
                else if (c[indexer + 2] == 0)
                {
                    res++;
                    indexer += 2;
                }
                else if (c[indexer + 1] == 0)
                {
                    res++;
                    indexer++;
                }
                else
                {
                    res = 0;
                    break;
                }

            } while (indexer < c.Count());

            return res;
        }

    }
}
