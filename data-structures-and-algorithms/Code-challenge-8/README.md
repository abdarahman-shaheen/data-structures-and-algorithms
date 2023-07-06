# Linked list

## Approach & Efficiency
**Algorithm**
Algorithm

1. Create a new empty linked list to store the zipped list.
2. Check if either of the input linked lists is empty. If one of them is empty, return the non-empty list as the zipped list.
3. Initialize two pointers, pointer1 and pointer2, to the heads of the input linked lists.
4. Iterate over the two lists simultaneously using the pointers.
5. Inside the loop, perform the following steps:
Append the node pointed to by pointer1 to the zipped list.
If there is a node in the second list pointed to by pointer2, append it to the zipped list.
Move pointer1 and pointer2 to their next nodes.
6. After the loop ends, check if there are any remaining nodes in either of the input lists.
If pointer1 is not null, append the remaining nodes from list 1 to the zipped list.
If pointer2 is not null, append the remaining nodes from list 2 to the zipped list.
7. Return the zipped list.

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-8/Linked-list-Zip.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)
