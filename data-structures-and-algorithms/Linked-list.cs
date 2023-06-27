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
        public Node Next { get; set; }

        public Node(int item) {
        Item = item;
            Next = null;
        }
    }
    public class Linked_List
    {
        public Node Head { get; set; }
        public Node tail { get; set; }

        int Length = 0;
        public Linked_List()
        {
            Head = null;
            tail = null;
        }
        public void InsertFirst(int item)
        {
            Node newNode = new Node(item);
            if(Length == 0)
            {
                Head = newNode;
                tail = newNode;
                newNode.Next = null;

            }
            else
            {
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

            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                newNode.Next = null;

            }
            Length++;


        }
        public void InsertPosition(int pos,int item)
        {
            Node newNode = new Node(item);
            if (pos == 0)
            {
                InsertFirst(item);

            }
            else if (pos==Length)
            {
                InsertLast(item);
            }
            else
            {
                Node current = Head;
                for(int i = 1;i<pos;i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            Length++;


        }
      
        public string PrintList()
        {
            string nodes="";
            Node curr = Head;
          while(curr != null)
            {
                nodes +="{"+ curr.Item.ToString()+"}=>";
                curr=curr.Next;
            }
          nodes += "NUll";
          return "Linked List :"+nodes;

        }
        public bool SerchNode(int item)
        {
            Node curr = Head;
            while (curr != null)
            {
                if (curr.Item == item)
                {
                    Console.WriteLine($"the value {item} is exsiting in linked list");
                    return true; }    
                    
                curr = curr.Next;
            }
            Console.WriteLine($"the value {item} is Not exsiting in linked list");

            return false;

        }
    }
    
  
}
