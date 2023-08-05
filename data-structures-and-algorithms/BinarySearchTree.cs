using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace data_structures_and_algorithms
{
    public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
    {

        public void Add(T value)
        {
            Root = AddNode(Root, value);
        }
        private Node<T> AddNode(Node<T> node, T value)
        {
            if (node == null)
                return new Node<T>(value);


            if (value.CompareTo(node.Value) < 0)
                node.Left = AddNode(node.Left, value);

            else if (value.CompareTo(node.Value) > 0)
                node.Right = AddNode(node.Right, value);

            return node;
        }



        public bool Contains(T value)
        {
            return ContainsNode(Root, value);
        }

        private bool ContainsNode(Node<T> node, T value)
        {
            if (node == null)
                return false;

            int comparisonResult = value.CompareTo(node.Value);
            if (comparisonResult == 0)
                return true;
            else if (comparisonResult < 0)
                return ContainsNode(node.Left, value);
            else
                return ContainsNode(node.Right, value);

        }
        public T FindMaximumValue()
        {
            if (Root == null)
                throw new InvalidOperationException("The binary tree is empty.");

            T max = default(T);

            Action<Node<T>> inOrderTraversal = null;
            inOrderTraversal = (node) =>
            {
                if (node != null)
                {
                    inOrderTraversal(node.Left);
                    if (Comparer<T>.Default.Compare(node.Value, max) > 0)
                    {
                        max = node.Value;
                    }

                    inOrderTraversal(node.Right);
                }
            };

            inOrderTraversal(Root);

            return max;
        }
    }

}
