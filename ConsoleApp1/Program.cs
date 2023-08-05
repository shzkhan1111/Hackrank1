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
            List<string> query = new List<string> { "10101"  , "11110"  , "00010"};
            var dd = acmTeam(query);
            Console.WriteLine(dd[0].ToString());
            Console.WriteLine(dd[1].ToString());

            Console.ReadKey();
        }

        public static List<int> acmTeam(List<string> topic)
        {
            List<int> longestPair = new List<int>();
            int pairCount = 0;
            List<int> res = new List<int>();
            int count = 0;
            int max = -1;
            for(int i = 0; i < topic.Count(); i++)
            {
                for (int j = i+1; j < topic.Count(); j++)
                {
                    for (int k = 0; k < topic[j].Length; k++)
                    {
                        if (topic[i][k] == '1' || topic[j][k] == '1')
                        {
                            count++;
                        }
                        
                    }
                    //can two form a pair
                   
                    
                    if (count == max)
                    {
                        pairCount++;
                    }
                    if (count > max)
                    {
                        max = count;
                        pairCount = 1;
                    }
                    count = 0;

                }
            }

            res.Add(max);
            res.Add(pairCount);
            return res;
        }



    }
}
