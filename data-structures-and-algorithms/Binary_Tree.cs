using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class BinaryTree<T>
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public List<T> PreOrderTravarsel()
        {
            List<T> result = new List<T>();
            PreOrderTravarsel(Root, result);

            return result;
        }

        public void PreOrderTravarsel(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                result.Add(node.Value);

                PreOrderTravarsel(node.Left, result);

                PreOrderTravarsel(node.Right, result);
            }

        }

        // In-order Traversal
        public List<T> InorderTraversal()
        {
            List<T> result = new List<T>();
            InorderTraversal(Root, result);
            return result;
        }

        private void InorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                InorderTraversal(node.Left, result);
                result.Add(node.Value);
                InorderTraversal(node.Right, result);
            }
        }

        // Post-order Traversal
        public List<T> PostorderTraversal()
        {
            List<T> result = new List<T>();
            PostorderTraversal(Root, result);
            return result;
        }

        private void PostorderTraversal(Node<T> node, List<T> result)
        {
            if (node != null)
            {
                PostorderTraversal(node.Left, result);
                PostorderTraversal(node.Right, result);
                result.Add(node.Value);
            }
        }


        public List<T> BFS(Node<T> root)
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            List<T> results = new List<T>();
            if (root == null) return results;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node<T> newNode = queue.Dequeue();
                results.Add(newNode.Value);
                if (newNode.Left != null)
                {
                    queue.Enqueue(newNode.Left);
                }
                if (newNode.Right != null)
                {
                    queue.Enqueue(newNode.Right);
                }
            }
            return results;

        }
        public void Add(T value)
        {
            Root = AddRecursive(Root, value);
        }

        private Node<T> AddRecursive(Node<T> current, T value)
        {
            if (current == null)
            {
                return new Node<T>(value);
            }


            if (current.Left == null)
            {
                current.Left = new Node<T>(value);
            }

            else if (current.Right == null)
            {
                current.Right = new Node<T>( value);
            }

            else
            {
                current.Left = AddRecursive(current.Left, value);
            }

            return current;
        }

        public BinaryTree<string> FizzBuzzTree()
        {
            BinaryTree<string> fizzBuzzTree = new BinaryTree<string>();

            if (Root == null)
            {
                return fizzBuzzTree;
            }

            Queue<Node<T>> originalNodes = new Queue<Node<T>>();
            Queue<Node<string>> fizzBuzzNodes = new Queue<Node<string>>();

            originalNodes.Enqueue(Root);
            fizzBuzzNodes.Enqueue(new Node<string>(FizzBuzzValue(Root.Value)));

            fizzBuzzTree.Root = fizzBuzzNodes.Peek();

            while (originalNodes.Count > 0)
            {
                Node<T> originalNode = originalNodes.Dequeue();
                Node<string> fizzBuzzNode = fizzBuzzNodes.Dequeue();

                if (originalNode.Left != null)
                {
                    originalNodes.Enqueue(originalNode.Left);
                    fizzBuzzNode.Left = new Node<string>(FizzBuzzValue(originalNode.Left.Value));
                    fizzBuzzNodes.Enqueue(fizzBuzzNode.Left);
                }

                if (originalNode.Right != null)
                {
                    originalNodes.Enqueue(originalNode.Right);
                    fizzBuzzNode.Right = new Node<string>(FizzBuzzValue(originalNode.Right.Value));
                    fizzBuzzNodes.Enqueue(fizzBuzzNode.Right);
                }
            }

            return fizzBuzzTree;
        }

        private string FizzBuzzValue(dynamic value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (value % 3 == 0)
            {
                return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return value.ToString();
            }
        }




    }
}

