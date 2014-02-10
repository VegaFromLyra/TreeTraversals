using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversals
{
    class Node
    {
        public Node(int Data)
        {
            this.Data = Data;
        }

        public int Data;

        public Node Left;

        public Node Right;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(2);
            root.Left = new Node(3);
            root.Right = new Node(4);
            root.Left.Left = new Node(5);
            root.Left.Right = new Node(6);

            Console.WriteLine("Inorder Traversal Iterative:");
            InorderIterative(root);

            Console.WriteLine();

            Console.WriteLine("Inorder Traversal recursive:");
            InorderRecursive(root);

            Console.WriteLine();

            Console.WriteLine("Preorder Traversal Iterative");
            PreOrderIterative(root);

            Console.WriteLine();

            Console.WriteLine("Preorder Traversal recursive");
            PreOrderRecursive(root);

            Console.WriteLine();

            Console.WriteLine("Postorder Travesal iterative");
            PostOrderIterative(root);

            Console.WriteLine();

            Console.WriteLine("Postorder Travesal recursive");
            PostOrderRecursive(root);

            Console.WriteLine();
        }

        static void InorderIterative(Node root)
        {
            Stack<Node> stack = new Stack<Node>();

            bool done = false;

            while (!done)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }

                if (stack.Count == 0)
                {
                    done = true;
                }
                else
                {
                    Node topNode = stack.Pop();

                    Console.Write(topNode.Data + " ");

                    if (topNode.Right != null)
                    {
                        root = topNode.Right;
                    }
                }
            }
        }

        static void PreOrderIterative(Node root)
        {
            Stack<Node> stack = new Stack<Node>();

            if (root != null)
            {
                stack.Push(root);
            }

            while (stack.Count > 0)
            {
                Node n = stack.Pop();

                Console.Write(n.Data + " ");

                if (n.Right != null)
                {
                    stack.Push(n.Right);
                }

                if (n.Left != null)
                {
                    stack.Push(n.Left);
                }
            }
        }

        static void PostOrderIterative(Node root)
        {
            Stack<Node> s1 = new Stack<Node>();

            Stack<Node> s2 = new Stack<Node>();

            if (root != null)
            {
                s1.Push(root);
            }

            while (s1.Count > 0)
            {
                Node n = s1.Pop();

                s2.Push(n);

                if (n.Left != null)
                {
                    s1.Push(n.Left);
                }

                if (n.Right != null)
                {
                    s1.Push(n.Right);
                }
            }

            while (s2.Count > 0)
            {
                Console.Write(s2.Pop().Data + " ");
            }
        }

        static void InorderRecursive(Node root)
        {
            if (root == null)
            {
                return;
            }

            InorderRecursive(root.Left);
            Console.Write(root.Data + " ");
            InorderRecursive(root.Right);
        }

        static void PreOrderRecursive(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.Data + " ");
            PreOrderRecursive(root.Left);
            PreOrderRecursive(root.Right);
        }

        static void PostOrderRecursive(Node root)
        {
            if (root == null)
            {
                return;
            }

            PostOrderRecursive(root.Left);
            PostOrderRecursive(root.Right);

            Console.Write(root.Data + " ");
        }
    }

}
