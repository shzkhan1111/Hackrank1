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

           
            List<int> a = new List<int> { 3,4,5};
            List<int> query = new List<int> { 1,2};

            var x = circularArrayRotation(a, 2, query);
            //Console.WriteLine(string.Join(", ", circularArrayRotation(a, 2,query)));

            Console.ReadKey();
        }
        public static void rotateRight(List<int> a)
        {
            int lastElement = a[a.Count() - 1];
            for (int i = a.Count() - 1; i > 0; i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = lastElement;


        }
        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
        {
            int count_a = a.Count();

            int rem = k % (count_a);
            List<int> res = new List<int>();
            int sum = 0;
            int index = 0;
            foreach (int q in queries)
            {
                sum = q - rem;
                if (sum >= 0)
                {
                    index = a[sum];
                    res.Add(a[sum]);
                }
                else
                {
                    index = count_a + sum;
                    res.Add(a[index]);
                }
            }
            return res;

            //rotate time out 
            //for (int i = 0; i < k; i++)
            //{
            //    rotateRight(a);
            //}
            //List<int> res = new List<int>();
            //foreach (int q in queries)
            //{
            //    res.Add(a[q]);
            //}

        }



    }
}
