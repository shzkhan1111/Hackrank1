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

            var list = new int?[] { 1, null, 3, 2 };
            //var root = InitializeNaryTree(list);
            //var res = Postorder(root);
            var t = new Tree(list);
            var x = t.root;

            Console.ReadKey();
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public class Tree
        {
            public TreeNode root;

            public Tree(int?[] input)
            {
                root = InitializeTree(input);
            }

            public TreeNode InitializeTree(int?[] inputList)
            {
                if (inputList.Length == 0)
                {
                    return null;
                }

                Queue<TreeNode> queue = new Queue<TreeNode>();
                TreeNode root = new TreeNode(inputList[0].Value);
                queue.Enqueue(root);

                int i = 1;
                while (queue.Count > 0 && i < inputList.Length)
                {
                    TreeNode currentNode = queue.Dequeue();
                    if (inputList[i] == null)
                    {
                        i++;
                    }
                    if (inputList[i] != null)
                    {
                        currentNode.left = new TreeNode(inputList[i].Value);
                        queue.Enqueue(currentNode.left);
                    }

                    i++;

                    if (i < inputList.Length && inputList[i] != null)
                    {
                        currentNode.right = new TreeNode(inputList[i].Value);
                        queue.Enqueue(currentNode.right);
                    }

                    i++;
                }

                return root;
            }















        }
    }
    }
