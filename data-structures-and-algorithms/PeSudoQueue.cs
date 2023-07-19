using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class PeSudoQueue
    {

        private MyStack stack1;
        private MyStack stack2;
        public PeSudoQueue()
        {
             stack2 = new MyStack();
             stack1 = new MyStack();
        }
        public void Enqueue(int value)
        {
            while (!stack2.isEmpty())
            {
                stack1.Push(stack2.Pop());
            }
            stack1.Push(value);
        }
        public int Dequeue()
        {
            if (stack1.isEmpty() && stack2.isEmpty())
            {
                throw new InvalidOperationException("PseudoQueue is empty");
            }
            while (!stack1.isEmpty())
            {
                stack2.Push(stack1.Pop());
            }
            return stack2.Pop();
        }
        public void Prints()
        {
            string s = " ";
            while (stack1.Top != null)
            {
                s += $"{stack1.Top.Item}=>";
                stack1.Top = stack1.Top.Next;
            }
            Console.WriteLine(s);
        }
    }
}