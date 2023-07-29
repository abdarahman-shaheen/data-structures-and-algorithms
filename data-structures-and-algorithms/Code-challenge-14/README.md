# Tree
## explanation
The code defines a Node class to represent each node in the Binary Search Tree.
It also defines a BinaryTree class with methods for pre-order, in-order, and post-order traversals.
The BinarySearchTree class extends the BinaryTree class and adds an Add method to insert nodes into the BST and a Contains method to check if a value exists in the tree.
In the Main method, a BinarySearchTree instance is created, and several integer values are added to the tree using the Add method.
The code then performs pre-order, in-order, and post-order traversals and prints the results.
Finally, the code checks if certain values (40 and 90) exist in the tree using the Contains method and prints the results.

## whiteboard:

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-14/SearchTree.jpg)

## walkthrough :

Walkthrough of the Code:


1. Namespace and Class Definitions:
   - The code is placed in the "data_structures_and_algorithms" namespace.
   - It defines a `Program` class containing the `Main` method, which serves as the entry point of the program.

2. Binary Search Tree Implementation:
   - The code defines a generic class `BinarySearchTree<T>`, where `T` represents the type of data the BST will store. This class inherits from another generic class `BinaryTree<T>`.

3. Node Class:
   - The code defines a generic `Node<T>` class to represent individual nodes in the Binary Search Tree. Each node contains a `Value`, `Left`, and `Right` reference pointing to its value and its left and right children, respectively.

4. BinaryTree Class:
   - The `BinaryTree<T>` class provides a basic structure for a binary tree. It contains a `Root` reference pointing to the root node of the tree.
   - The class provides methods for Pre-order, In-order, and Post-order traversals using recursive approaches. These methods fill a list with the node values in the specified order.

5. BinarySearchTree Class:
   - The `BinarySearchTree<T>` class extends the `BinaryTree<T>` class, adding the functionality specific to a Binary Search Tree.
   - It provides an `Add` method to insert nodes into the Binary Search Tree. The method compares the new value with the current node's value to determine whether to insert it in the left or right subtree.
   - It also provides a `Contains` method to check if a given value exists in the Binary Search Tree. The method traverses the tree following a similar comparison process as the `Add` method.

6. Main Method:
   - Inside the `Main` method, a new instance of `BinarySearchTree<int>` is created, representing an integer-based Binary Search Tree.
   - Several integer values are added to the tree using the `Add` method, creating a balanced Binary Search Tree.

7. Traversals and Output:
   - The program then performs three different tree traversals: Pre-order, In-order, and Post-order.
   - The results of each traversal are printed to the console, displaying the node values in the specified order.
   - For example, the Pre-order traversal prints the nodes in the order they are visited (Root, Left, Right), the In-order traversal prints them in ascending order, and the Post-order traversal prints them in the order (Left, Right, Root).

8. Value Existence Check:
   - Finally, the program checks whether certain values (40 and 90) exist in the Binary Search Tree using the `Contains` method.
   - The results of these checks are printed to the console, displaying whether the values are found in the tree or not.

In summary, this code provides an implementation of a Binary Search Tree and demonstrates its functionality by adding nodes, performing different tree traversals, and checking for the existence of specific values in the tree.

```
## test unit:

![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-14/Test-TreeSearch.png)









```
