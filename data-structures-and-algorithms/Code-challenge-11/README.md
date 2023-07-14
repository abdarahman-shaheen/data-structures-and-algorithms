# PeSudeQueue

## Approach & Efficiency
**Algorithm**
1. Initialize two stacks, `stack1` and `stack2`, which will be used to implement the queue.

2. To enqueue an element:
   - Transfer all elements from `stack2` to `stack1` by repeatedly popping elements from `stack2` and pushing them to `stack1`.
   - Push the new element onto `stack1`.

3. To dequeue an element:
   - Transfer all elements from `stack1` to `stack2` by repeatedly popping elements from `stack1` and pushing them to `stack2`.
   - Pop the topmost element from `stack2` and return it as the dequeued value.

The key idea behind this algorithm is to maintain the order of elements in the queue by using the two stacks. The elements are first enqueued onto `stack1` in the reverse order, and when dequeuing, the elements are transferred to `stack2` to reverse the order and retrieve the front element.

Here is the step-by-step breakdown of the algorithm:

1. Enqueue operation:
   - Transfer all elements from `stack2` to `stack1` by popping elements from `stack2` and pushing them to `stack1`. This ensures that the most recently enqueued elements are at the top of `stack1`.
   - Push the new element onto `stack1`.
   - The order of elements in `stack1` will be reversed, with the newly enqueued element at the bottom and the oldest element at the top.

2. Dequeue operation:
   - Transfer all elements from `stack1` to `stack2` by popping elements from `stack1` and pushing them to `stack2`. This reverses the order of elements, making the oldest element the topmost in `stack2`.
   - Pop the topmost element from `stack2` and return it as the dequeued value.
   - The order of elements in `stack2` will be reversed, with the second oldest element at the top and the newest element at the bottom.

By using this approach, the algorithm achieves the desired FIFO behavior of a queue using two stacks.
![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
