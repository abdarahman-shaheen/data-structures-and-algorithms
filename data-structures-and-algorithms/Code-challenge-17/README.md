# Fizz-Buzz-Tree

## Approach & Efficiency
**Algorithm**
- The algorithm for the FizzBuzzTree method is a recursive algorithm that traverses the binary tree using the Inorder traversal technique. During the traversal, it checks each node's value and replaces it with "FizzBuzz," "Buzz," or "Fizz" based on the following conditions:
1- If the node's value is divisible by 15, replace the value with "FizzBuzz."
2- If the node's value is divisible by 5, replace the value with "Buzz."
3- If the node's value is divisible by 3, replace the value with "Fizz."

The steps of the algorithm are as follows:
Start the FizzBuzzTree method by calling the overloaded version with the Root node of the binary tree.
In the recursive FizzBuzzTree method: a. Check if the current node is not null. b. Recursively call FizzBuzzTree for the left subtree of the current node. c. Check the current node's value using the CheckForNode method, and update the value accordingly. d. Recursively call FizzBuzzTree for the right subtree of the current node.
The CheckForNode method is a helper method that takes a node as input, checks its value for divisibility by 15, 5, or 3, and replaces it accordingly. If none of the conditions match, the node's value remains unchanged.
![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
// ![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)
