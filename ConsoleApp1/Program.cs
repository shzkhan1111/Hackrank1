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

            var list1 = new int?[] { 4, null, 2, 7 ,null , 1 , 3 , null , 6 , 9};
            //var list2 = new int?[] { 1, null, 3, 2, null, 5 };

            //var root = InitializeNaryTree(list);
            //var res = Postorder(root);
            //var t1 = InitializeTree(list1);
            //var t2 = InitializeTree(list2);
            var t2 = InitializeTree(list1);

            InvertTree(t2); 

            //MergeTrees(t1 , t2);    

            //var x = t;

            Console.ReadKey();
        }


        public static TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            
            var left = InvertTree(root.left);   
            var rig = InvertTree(root.right);
            root.left = rig;
            root.right = left;

            return root;

        }

        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
         {
            if (root1 == null)
            {
                return root2;
            }
            if (root2 == null)
            {
                return root1;
            }
            root1.val += root2.val;
            root1.left = MergeTrees(root1.left, root2.left);
            root1.right  = MergeTrees(root1.right   , root2.right);

            return root1;

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
        static TreeNode InitializeTree(int? [] inputList)
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
