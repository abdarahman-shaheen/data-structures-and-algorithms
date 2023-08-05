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


        public List<int> BFS(Node<int> root)
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            List<int> results = new List<int>();
            if (root == null) return results;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node<int> newNode = queue.Dequeue();
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




    }
}

