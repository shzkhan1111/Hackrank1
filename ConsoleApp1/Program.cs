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

           
            List<int> a = new List<int> { 5,2,1,3,4};
            List<int> query = new List<int> { 1,2};

            permutationEquation(a);
            Console.WriteLine(string.Join(", ", permutationEquation(a)));

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
        public static List<int> permutationEquation(List<int> p)
        {
            List<int> res = new List<int>();

            for (int i = 0; i < p.Count(); i++)
            {
                int index1 = p.IndexOf(i + 1) + 1;//POS 1 
                int index2 = p.IndexOf(index1) + 1;//POS 2
                

                res.Add(index2);
            }
            return res;

        }


    }
}
