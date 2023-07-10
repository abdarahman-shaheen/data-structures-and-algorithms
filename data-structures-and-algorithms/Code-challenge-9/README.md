# Linked list

## Approach & Efficiency
1. Set the first node of the linked list as the current node and the last node as the tail node of the linked list.
2. Calculate the midpoint of the linked list by dividing the length of the list by 2.
3. Initialize a counter variable to keep track of the number of nodes visited.
4. Iterate through the linked list from the start node to the midpoint node (inclusive).
5. Inside the loop, check if the value of the current first node is equal to the value of the current last node.
- If they are equal:
- Increment the counter.
- Check if the counter is equal to the midpoint.
- If yes, print "the linked list is a palindrome" and return true.
- Move the first node to the next node.
- Move the last node to the previous node.
 -If the loop completes without finding a mismatched pair of nodes, print "the linked list is NOT a palindrome" and return false.

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)
