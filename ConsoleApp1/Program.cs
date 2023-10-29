using LanguageExt;
using LanguageExt.Pretty;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int?> { 1, null, 3, 2, 4, null, 5, 6 };
            var root = InitializeNaryTree(list);
            var res = Postorder(root);

            Console.ReadKey();
        }
        public static IList<int> Postorder(Node root)
        {
            List<int> outArray = new List<int>();
            Stack<Node> stack = new Stack<Node>();
            Node t = new Node();
            if (root == null)
            {
                return outArray;
            }
            stack.Push(root);
            while (stack.Any())
            {
                t = stack.Pop();
                for(int i = 0; i < t.children.Count; i++)
                {
                    stack.Push(t.children[i]);
                }
                outArray.Insert(0 , t.val);
            }
            return outArray;

        }
        public static Node InitializeNaryTree(List<int?> list)
            {
                Node root = new Node();
                Node temp = new Node();
                Queue<Node> q = new Queue<Node>();
                root.val = list[0].Value;
                q.Enqueue(root);
                for (int i = 1; i < list.Length(); i++)
                {
                    //temp = q.Peek();
                    if (list[i] == null)
                    {
                        //fill the next node
                        temp = q.Dequeue();
                    }
                    else
                    {
                        Node node = new Node(list[i].Value);
                        q.Enqueue(node);
                        temp.children.Add(node);
                    }
                }

            return root;

            }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() {
                children = new List<Node>();
            }

            public Node(int _val)
            {
                val = _val;
                children = new List<Node>();    
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }












    }
}
