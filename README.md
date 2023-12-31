## Table of Contents
 ## 1. [Challenge1 (Array-reverse)](data-structures-and-algorithms/Code-Challenge-1/README.md)
  - Feature Tasks
  Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array 
  with elements in reversed order.

 ## 2. [Challenge2 (Array-insert-shift)](data-structures-and-algorithms/Code-Challenge-2/README.md)
  - Feature Tasks
  Write a function called insertShiftArray which takes in an array and a value to be added. Without utilizing any of the built-in methods available to your language, 
  return an array with the new value added at the middle index.

 ## 3. [Challenge3 (Binary Search)](data-structures-and-algorithms/Code-Challenge-3/README.md)
 - Feature Tasks
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the value of the search key, or -1 if the element is not in the array.
NOTE: The search algorithm used in your function should be a binary search.
Check the Resources section for details

## 4. [Challenge5 (Linked-List)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/README.md)
- Features
Node
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
Linked List
Create a Linked List class
Within your Linked List class, include a head property.
Upon instantiation, an empty Linked List should be created.
The class should contain the following methods
insert
Arguments: value
Returns: nothing
Adds a new node with that value to the head of the list with an O(1) Time performance.
includes
Arguments: value
Returns: Boolean
Indicates whether that value exists as a Node’s value somewhere within the list.
to string
Arguments: none
Returns: a string representing all the values in the Linked List, formatted as:
"{ a } -> { b } -> { c } -> NULL"
## 5. [Challenge6 (Linked-List-Insertion)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/README.md)
- Features
  Write the following methods for the Linked List class:

append
arguments: new value
adds a new node with the given value to the end of the list
insert before
arguments: value, new value
adds a new node with the given new value immediately before the first node that has the value specified
insert after
arguments: value, new value
adds a new node with the given new value immediately after the first node that has the value specified

## 6. [Challenge7 (Linked-List-Search)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-7/README.md)
- Features
-  Write the following method for the Linked List class:
kth from end
argument: a number, k, as a parameter.
Return the node’s value that is k places from the tail of the linked list.
You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.





## 7. [Challenge8 (Linked-List-Zip)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-8/README.md)
- Features
 domain here is to implement a function called zipLists that takes two linked lists as arguments and returns a new linked list by zipping the two lists together. Zipping the lists means that the nodes from the two input lists will alternate in the resulting list.


## 8. [Challenge10 (Stack&&Queue)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-10/README.md)
Features
Using a Linked List as the underlying data storage mechanism, implement both a Stack and a Queue

## 9. [Challenge11 (PesudoQueue)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-11/README.md)
- Feature
Create a new class called pseudo queue.
Do not use an existing Queue.
Instead, this PseudoQueue class will implement our standard queue interface (the two methods listed below),
Internally, utilize 2 Stack instances to create and manage the queue
Methods:
enqueue
Arguments: value
Inserts a value into the PseudoQueue, using a first-in, first-out approach.
dequeue
Arguments: none
Extracts a value from the PseudoQueue, using a first-in, first-out approach.


## 10. [Challenge12 (stack-queue-animal-shelter)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-12/README.md)
- Feature
Feature Tasks
Create a class called AnimalShelter which holds only dogs and cats.
The shelter operates using a first-in, first-out approach.

## 11. [Challenge13 (stack-Bracket)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-13/README.md)
- Feature Tasks
Write a function called validate brackets
Arguments: string
Return: boolean
representing whether or not the brackets in the string are balanced


## 12. [Challenge14 (Tree)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-14/README.md)
Features
Node
Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Binary Tree
Create a Binary Tree class
Define a method for each of the depth first traversals:
pre order
in order
post order
Each depth first traversal method should return an array of values, ordered appropriately.
Binary Search Tree
Create a Binary Search Tree class
This class should be a sub-class (or your languages equivalent) of the Binary Tree Class, with the following additional methods:
Add
Arguments: value
Return: nothing
Adds a new node with that value in the correct location in the binary search tree.
Contains
Argument: value
Returns: boolean indicating whether or not the value is in the tree at least once.


## 13. [Challenge15 (MaxTree)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-15/README.md)
Find the Maximum Value in a Binary Tree

## 14. [Challenge16 (tree-breadth-first)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-16/README.md)
Write a function called breadth first
Arguments: tree
Return: list of all values in the tree, in the order they were encountered

## 13. [Challenge15 (tree-fizz-buzz)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-17/README.md)
Feature Tasks
Write a function called fizz buzz tree
Arguments: k-ary tree
Return: new k-ary tree
Determine whether or not the value of each node is divisible by 3, 5 or both. Create a new tree with the same structure as the original, but the values modified as follows:

If the value is divisible by 3, replace the value with “Fizz”
If the value is divisible by 5, replace the value with “Buzz”
If the value is divisible by 3 and 5, replace the value with “FizzBuzz”
If the value is not divisible by 3 or 5, simply turn the number into a String.

## 13. [Challenge19 (Merge-sort-araay)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-19/README.md)

## 14. [Challenge20 (Hash Table)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-21/README.md)
## 15. [Challenge21 (Hash Map word)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-22/README.md)
Feature Tasks
Write a function called repeated word that finds the first word to occur more than once in a string
Arguments: string
Return: string

## 16. [Challenge22 (Hash Map Tree)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-23/README.md)
Feature Tasks
Find common values in 2 binary trees.

## 17. [Challenge23 (Graph)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-25/README.md)
Feature Tasks
Implementation Graph.

## 17. [Challenge24 (Graph-breadth)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-28/README.md)
Feature Tasks
Implement a breadth-first traversal on a graph.

## 18. [Challenge25 (Graph-Trip)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-27/README.md)
Feature Tasks
Implement a graph-trip.

## 19. [Challenge26 (Graph-Depth)](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-28/README.md)
Feature Tasks

Conduct a depth first pre-order traversal on a graph


