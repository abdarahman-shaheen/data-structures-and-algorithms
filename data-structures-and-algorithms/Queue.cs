using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class Queue
    {
        public Node Front { get; set; }
        public Node Back { get; set; }

        int Count = 0;
        private string s;

        public Queue()
        {
            Front = null;
            Back = null;

        }
        public void Enqueue(int value)
        {
            Node newNode = new Node(value);
           if(isEmpty())
            {
                Front = newNode;
                Back = newNode;

            }
            else
            {
                Back.Previse = newNode;
                Back = newNode;
            }
        }
        public int Dequeue()
        {
            if (isEmpty())
            {
                throw new Exception("The queue is empty");
            }
            int Temp = Front.Item;
            Front = Front.Previse;
            return Temp;
        }
        public bool isEmpty()
        {
            return Front == null;
        }
        public int Peek()
        {
            if (isEmpty())
            {
                throw new Exception("The stack is empty");
            }
            return Front.Item;
        }
        public void Prints()
        {
            string s = " ";
            while (Front != null)
            {
                s += $"\n{Front.Item}";
                Front = Front.Previse;
            }
            Console.WriteLine(s);
        }
    }
}

