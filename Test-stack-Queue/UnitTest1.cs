

namespace data_structures_and_algorithms;

    public class UnitTest1
    {
        [Fact]
        public void PushtoStack()
        {
             
            Stack stack = new Stack();

              
            stack.Push(5);

            
            Assert.False(stack.isEmpty());
            Assert.Equal(5, stack.Peek());
        }

        [Fact]
        public void Push_MultipleValuestoStack()
        {
             
            Stack stack = new Stack();

              
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

            
            Assert.False(stack.isEmpty());
            Assert.Equal(15, stack.Peek());
        }

        [Fact]
        public void PopStack()
        {
             
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

              
            int result = stack.Pop();

            
            Assert.Equal(15, result);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void Pop_EmptyStack_ThrowsException()
        {
             
            Stack stack = new Stack();

            
            Assert.Throws<Exception>(() => stack.Pop());
        }

        [Fact]
        public void PeekItemOnStack()
        {
             
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);

              
            int result = stack.Peek();

            
            Assert.Equal(15, result);
        }

        [Fact]
        public void Peek_EmptyStack_ThrowsException()
        {
             
            Stack stack = new Stack();

            
            Assert.Throws<Exception>(() => stack.Peek());
        }

        [Fact]
        public void EmptyStack()
        {
              
            Stack stack = new Stack();

            
            Assert.True(stack.isEmpty());
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

