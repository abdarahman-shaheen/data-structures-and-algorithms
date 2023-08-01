# challenge (16) :tree-max

# Algorithm 
 The paragraph describes a recursive depth-first search (DFS) algorithm implemented in the Max_tree method of the BinarySearchTree class. The algorithm is used to find the maximum value in a binary search tree. The method starts the recursive traversal from the root of the tree and follows these steps:
1. If the current node is null (empty subtree), it returns 0 as there is no maximum value in an empty subtree.
2. Otherwise, it initializes a variable max with the value of the current node, considering it as the maximum candidate for the current subtree.
3. Recursively calls itself to find the maximum value in the left subtree and stores the result in lMax.
4. Recursively calls itself to find the maximum value in the right subtree and stores the result in rMax.
5. Compares max with lMax and rMax, updating max to be the largest of the three values.
6. Returns max, representing the maximum value in the current subtree. The DFS traversal ensures all nodes are visited, efficiently identifying the maximum value as it progresses through the tree.
## whiteboard:

![white](white.png)
