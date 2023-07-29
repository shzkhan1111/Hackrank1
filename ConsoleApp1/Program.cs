using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class A
    {

    }
    public class B : A
    {

    }
    public class C : A
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            A a = new A();
            B b = new B();
            A c = new B();
            C d = new C();
            climbingLeaderboard(a);
            climbingLeaderboard(b);
            climbingLeaderboard(c);
            climbingLeaderboard(d);
            int[] arr = new int[1];
            climbingLeaderboard(arr, arr);

            List<int> ranked = new List<int> { 100, 90, 90, 80 };
            List<int> player = new List<int> { 70, 80, 105 };
            Console.WriteLine(string.Join(", ", climbingLeaderboard(ranked, player)));

            Console.ReadLine();
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> result = new List<int>();
            List<int> Unique = new List<int>();
            //remove duplicates
            for (int i = 0; i < ranked.Count(); i++)
            {
                if (i == 0 || ranked[i] != ranked[i - 1])
                {
                    Unique.Add(ranked[i]);
                }
            }

            int index = Unique.Count();

            foreach (int p in player)
            {

                if (index > 0)
                {
                    while (index > 0 && p >= Unique[index - 1])
                    {
                        index--;
                    }
                    
                }

                if (index == 0)
                {
                    if (Unique[index] > p)
                    {
                        //second
                        result.Add(2);

                    }
                    else
                    {
                        //first
                        result.Add(1);
                    }
                }
                else
                {
                    if (p < Unique[index - 1])
                    {
                        result.Add(index + 1);
                    }
                }


            }


            return result;

        }
        public static List<int> climbingLeaderboard(int[] a, int[] b)
        {

            return null;
        }
        public static List<int> climbingLeaderboard(A a)
        {

            return null;
        }
        public static List<int> climbingLeaderboard(B b)
        {

            return null;
        }

    }
}
