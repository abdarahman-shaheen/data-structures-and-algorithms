

namespace data_structures_and_algorithms;

    public class UnitTest1
    {
        [Fact]
        public void PushtoMyMyStack()
        {
             
        MyStack MyStack = new MyStack();
        MyStack = new MyStack();

              
            MyStack.Push(5);

            
            Assert.False(MyStack.isEmpty());
            Assert.Equal(5, MyStack.Peek());
        }

        [Fact]
        public void Push_MultipleValuestoMyStack()
        {
             
            MyStack MyStack = new MyStack();

              
            MyStack.Push(5);
            MyStack.Push(10);
            MyStack.Push(15);

            
            Assert.False(MyStack.isEmpty());
            Assert.Equal(15, MyStack.Peek());
        }

        [Fact]
        public void PopMyStack()
        {
             
            MyStack MyStack = new MyStack();
            MyStack.Push(5);
            MyStack.Push(10);
            MyStack.Push(15);

              
            int result = MyStack.Pop();

            
            Assert.Equal(15, result);
            Assert.Equal(10, MyStack.Peek());
        }

        [Fact]
        public void Pop_EmptyMyStack_ThrowsException()
        {
             
            MyStack MyStack = new MyStack();

            
            Assert.Throws<Exception>(() => MyStack.Pop());
        }

        [Fact]
        public void PeekItemOnMyStack()
        {
             
            MyStack MyStack = new MyStack();
            MyStack.Push(5);
            MyStack.Push(10);
            MyStack.Push(15);

              
            int result = MyStack.Peek();

            
            Assert.Equal(15, result);
        }

        [Fact]
        public void Peek_EmptyMyStack_ThrowsException()
        {
             
            MyStack MyStack = new MyStack();

            
            Assert.Throws<Exception>(() => MyStack.Peek());
        }

        [Fact]
        public void EmptyMyStack()
        {
              
            MyStack MyStack = new MyStack();

            
            Assert.True(MyStack.isEmpty());
        }
    }

    public class QueueTests
    {
        [Fact]
        public void EnqueueIntoQueue()
        {
             
            Queue queue = new Queue();

              
            queue.Enqueue(5);

            
            Assert.False(queue.isEmpty());
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void Enqueue_MultipleValuesIntoQueue()
        {
             
            Queue queue = new Queue();

              
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

            
            Assert.False(queue.isEmpty());
            Assert.Equal(5, queue.Peek());
        }

        [Fact]
        public void DequeueQueue()
        {
             
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

              
            int result = queue.Dequeue();

            
            Assert.Equal(5, result);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void Dequeue_EmptyQueue_ThrowsException()
        {
             
            Queue queue = new Queue();

            
            Assert.Throws<Exception>(() => queue.Dequeue());
        }

        [Fact]
        public void PeekInQueue()
        {
             
            Queue queue = new Queue();
            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(15);

              
            int result = queue.Peek();

            
            Assert.Equal(5, result);
        }

        [Fact]
        public void Peek_EmptyQueue_ThrowsException()
        {
             
            Queue queue = new Queue();

            
            Assert.Throws<Exception>(() => queue.Peek());
        }

        [Fact]
        public void InstantiateEmptyQueue()
        {
              
            Queue queue = new Queue();

            
            Assert.True(queue.isEmpty());
        }
    }

