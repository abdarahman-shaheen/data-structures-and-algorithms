using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Node
    {
        public int Item { get; set; }
        public string Value { get; set; }
        public Node Next { get; set; }
        public Node Previse { get; set; }

        public Node(int item)
        {
            Item = item;
            Next = null;
            Previse = null;
        }
        public Node(string item)
        {
            Value = item;
            Next = null;
            Previse = null;
        }
    }
    public class Linked_List
    {
        public Node Head { get; set; }
        public Node tail { get; set; }

        public int Length = 0;
        public Linked_List()
        {
            Head = null;
            tail = null;
        }
        public void InsertFirst(int item)
        {
            Node newNode = new Node(item);
            if (Length == 0)
            {
                Head = newNode;
                tail = newNode;
                newNode.Next = null;
                newNode.Previse = null;

            }
            else
            {
                Head.Previse = newNode;
                newNode.Next = Head;
                Head = newNode;
            }
            Length++;


        }
        public void InsertFirstString(string value)
        {
            Node newNode = new Node(value);
            if (Length == 0)
            {
                Head = newNode;
                tail = newNode;
                newNode.Next = null;
                newNode.Previse = null;

            }
            else
            {
                Head.Previse = newNode;
                newNode.Next = Head;
                Head = newNode;
            }
            Length++;


        }
        public void InsertLast(int item)
        {
            Node newNode = new Node(item);
            if (Length == 0)
            {
                Head = newNode;
                tail = newNode;
                newNode.Next = null;
                newNode.Previse = null;

            }
            else
            {
                newNode.Previse = tail;
                tail.Next = newNode;
                tail = newNode;
                newNode.Next = null;
            }
            Length++;


        }
        public void InsertPosition(int pos, int item)
        {
            Node newNode = new Node(item);
            if (pos == 0)
            {
                InsertFirst(item);

            }
            else if (pos == Length)
            {
                InsertLast(item);
            }
            else
            {
                Node current = Head;
                for (int i = 1; i < pos; i++)
                {
                    current = current.Next;
                }
                newNode.Previse = current;
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            Length++;
        }

        public string PrintList()
        {
            string nodes = "";
            Node curr = Head;
            while (curr != null)
            {
                nodes += "{" + curr.Item.ToString() + "}=>";
                curr = curr.Next;
            }
            nodes += "NUll";
            return "Linked List :" + nodes;

        }
        public string PrintListString()
        {
            string nodes = "";
            Node curr = Head;
            while (curr != null)
            {
                nodes += "{" + curr.Value + "}=>";
                curr = curr.Next;
            }
            nodes += "NUll";
            return "Linked List :" + nodes;

        }
        public bool SerchNode(int item)
        {
            Node curr = Head;
            while (curr != null)
            {
                if (curr.Item == item)
                {
                    Console.WriteLine($"the value {item} is exsiting in linked list");
                    return true;
                }

                curr = curr.Next;
            }
            Console.WriteLine($"the value {item} is Not exsiting in linked list");

            return false;

        }
        public string SerchTailNode(int k)
        {
            Node curr = tail;

            try
            {
                if (k < 0)
                {
                    return "negative number";
                }
                if (k == 0)
                {
                    return $"{curr.Item}";


                }
                while (k > 0)
                {

                    curr = curr.Previse;


                    k--;
                }
                return $"{curr.Item}";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return "out of range";
            }
        }
        public static Linked_List zipList(Linked_List list1, Linked_List list2)
        {
            Node pointer1 = list1.Head;
            Node pointer2 = list2.Head;

            Linked_List list3 = new Linked_List();

            while (pointer1 != null || pointer2 != null)
            {
                if (pointer1 != null)
                {
                    list3.InsertLast(pointer1.Item);
                    pointer1 = pointer1.Next;
                }

                if (pointer2 != null)
                {
                    list3.InsertLast(pointer2.Item);
                    pointer2 = pointer2.Next;
                }
            }
            return list3;
        }

        public static bool LinkedPindromd(Linked_List l1)
        {
            Node First = l1.Head;
            Node Last = l1.tail;
            int mid = l1.Length / 2;
            int counter = 0;

            for (int i = 0; i <= mid; i++)
            {
                if (First.Value == Last.Value)
                {
                    counter++;

                    if (counter == mid)
                    {
                        Console.WriteLine("the linked list pindrom");
                        return true;
                    }
                    First = First.Next;
                    Last = Last.Previse;
                }
            }
            Console.WriteLine("the linked list NOT pindrom");
            return false;
        }
    }
}
