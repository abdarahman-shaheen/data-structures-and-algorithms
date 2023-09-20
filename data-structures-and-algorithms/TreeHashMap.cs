using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class TreeHashMap
    {
        public class NodeHash
        {
            public int key;
            public NodeHash left, right;
        }

        public static NodeHash newNode(int ele)
        {
            NodeHash temp = new NodeHash();
            temp.key = ele;
            temp.left = null;
            temp.right = null;
            return temp;
        }

        public static List<int> FindCommonUsingHashMap(NodeHash root1, NodeHash root2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            TraverseAndStore(root1, map);

            return TraverseAndCheck(root2, map);
        }

        private static void TraverseAndStore(NodeHash node, Dictionary<int, int> map)
        {
            if (node == null)
                return;

            if (!map.ContainsKey(node.key))
                map[node.key] = 1;

            TraverseAndStore(node.left, map);
            TraverseAndStore(node.right, map);
        }

        private static List<int> TraverseAndCheck(NodeHash node, Dictionary<int, int> map)
        {
            List<int> commonNodes = new List<int>();

            if (node == null)
                return commonNodes;

            if (map.ContainsKey(node.key))
            {
                commonNodes.Add(node.key);
                map.Remove(node.key);
            }

            commonNodes.AddRange(TraverseAndCheck(node.left, map));
            commonNodes.AddRange(TraverseAndCheck(node.right, map));

            return commonNodes;
        }

        public static void PrintList(List<int> list)
        {
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
        }

        public static void inorder(NodeHash root)
        {
            if (root != null)
            {
                inorder(root.left);
                Console.Write(root.key + " ");
                inorder(root.right);
            }
        }

        public static NodeHash insert(NodeHash node, int key)
        {
            if (node == null)
            {
                return newNode(key);
            }

            if (key < node.key)
            {
                node.left = insert(node.left, key);
            }
            else if (key > node.key)
            {
                node.right = insert(node.right, key);
            }

            return node;
        }
    }
}
