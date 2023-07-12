# Linked list

## Approach & Efficiency
**Algorithm**
Stack Algorithms:
1. Push: Adds a new element to the top of the stack by creating a new node and updating the top reference to point to the new node.
2. Pop: Removes and returns the top element from the stack by updating the top reference to point to the next node in the stack and returning the value of the removed node.
3. Peek: Returns the value of the top element in the stack without modifying the stack structure. It simply accesses the value of the top node.
4. IsEmpty: Checks if the stack is empty by examining whether the `top` reference is null.

Queue Algorithms:
1. Enqueue: Adds a new element to the rear of the queue by creating a new node and updating the rear reference to point to the new node. If the queue is empty, the front reference is also updated to point to the new node.
2. Dequeue: Removes and returns the front element from the queue by updating the front reference to point to the next node in the queue and returning the value of the removed node. If the queue becomes empty after dequeue, the rear reference is also updated to null.
3. Peek: Returns the value of the front element in the queue without modifying the queue structure. It simply accesses the value of the front node.
4. IsEmpty: Checks if the queue is empty by examining whether the front reference is null.

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)


13. The `peekValueQueue` is printed to the console, so the output will be `10`.

14. The `Dequeue` method is called on the queue and the result is stored in the `dequeueValue` variable. The front value of the queue is 10, so it will be removed from the queue and assigned to `dequeueValue`.

15. The `dequeueValue` is printed to the console, so the output will be `10`.
