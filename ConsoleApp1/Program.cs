using System;
using System.Collections.Generic;
using System.Linq;

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

            var x = jumpingOnClouds(c , 2);
            //Console.WriteLine(string.Join(", ", permutationEquation(a)));

            Console.ReadKey();
        }
        static int jumpingOnClouds(int[] c, int k)
        {
            int e = 100;
            int i = 0;
            do
            {
                i = (i+k)%c.Length;
                e--;
                if (c[i] == 1)
                {
                    e -= 2;
                }
            } while (i != 0);

            return e;
        }

    }
}
