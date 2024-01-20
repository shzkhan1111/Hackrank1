using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1.Service
{
    public class HelperCode
    {

       


        public  static async Task<List<Repository>> ProcessRepositoriesAsync(HttpClient client)
        {
            //var json = await client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            await using Stream stream = 
                await client.GetStreamAsync("https://api.github.com/orgs/dotnet/repos");
            var repositories =
    await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
            //Console.Write(json);
           

            return repositories ?? new();

        }
        public static void WriteSomething(string  message)
        {
            Console.WriteLine(message);
        }
        public static int IsPalindrome(int x)
        {

            bool neg = x < 0;

            x = Math.Abs(x);
            int rem = 0;
            double res = 0;
            int revInt = x;
            while (revInt >= 1)
            {
                rem = revInt % 10;
                res = res * 10 + rem;

                revInt /= 10;
            }
            res = neg ? res * -1 : res;
            if (res >= int.MaxValue || res <= int.MinValue)
            {
                return 0;
            }

            return (int)res;
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

        public static async Task  HttpREquest(TreeNode root)
        {
            using HttpClient client = new();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");



            var repositories = await ProcessRepositoriesAsync(client);
            foreach (var repo in repositories)
            {
                Console.WriteLine($"Name: {repo.Name}");
                Console.WriteLine($"Homepage: {repo.Homepage}");
                Console.WriteLine($"GitHub: {repo.GitHubHomeUrl}");
                Console.WriteLine($"Description: {repo.Description}");
                Console.WriteLine($"Watchers: {repo.Watchers:#,0}");
                Console.WriteLine($"Last push: {repo.LastPush}");

                Console.WriteLine();
            }

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
            root1.right = MergeTrees(root1.right, root2.right);

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
        static TreeNode InitializeTree(int?[] inputList)
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
