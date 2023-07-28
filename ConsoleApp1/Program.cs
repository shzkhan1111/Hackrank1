using System;
using System.Collections.Generic;

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
            List<int> ranked = new List<int> { 100, 90, 90, 80 };
            List<int> player = new List<int> { 70, 80, 105 };
            int[] arr = new int[1];
            climbingLeaderboard(ranked, player);
            climbingLeaderboard(arr, arr);

            A a = new A();
            B b = new B();
            A c = new B();
            C d = new C();
            climbingLeaderboard(a);
            climbingLeaderboard(b);
            climbingLeaderboard(c);
            climbingLeaderboard(d);

            Console.ReadLine();
        }
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {

            return null;
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
