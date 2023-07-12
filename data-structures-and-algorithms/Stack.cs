using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Stack
    {
        public Node Top { get; set; }
        int Count = 0;
        private string s;

        public Stack()
        {
            Top = null;
        }
        public void Push(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Top;
            Top = newNode;
        }
        public int Pop()
        {
            if (isEmpty())
            {
                throw new Exception("The stack is empty");
            }
            int Temp = Top.Item;
            Top = Top.Next;
            return Temp;
        }
        public bool isEmpty()
        {
            return Top == null;
        }
        public int Peek()
        {
            if (isEmpty())
            {
                throw new Exception("The stack is empty");
            }
            return Top.Item;
        }
        public void Prints()
        {
            string s = " ";
            while (Top != null)
            {
                s += $"\n{Top.Item}";
                Top = Top.Next;
            }
            Console.WriteLine(s);
        }
    }
}
