# tree-breadth-first

## Approach & Efficiency
**Algorithm**
1. Start by initializing an empty queue data structure, where we will store the nodes to be visited.
2. Enqueue the root node of the graph (or a specified starting node) into the queue to start the traversal.
3. Create an empty result list (or array) that will store the values of the nodes visited in BFS order.
4. Begin a loop that runs as long as the queue is not empty. Inside the loop:
   a. Dequeue a node from the front of the queue. This node becomes the "current" node we are processing.
   b. Visit the "current" node and process it (e.g., add its value to the result list or perform any desired operation on the node).
   c. Enqueue all the unvisited neighbors (children) of the "current" node into the queue, if they exist. This ensures that we explore all immediate neighbors of the "current" node before moving to their children.
5. The loop continues until all nodes in the graph (or tree) have been visited.
![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-16/Tree-Breadth.jpghttps://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-16/Tree-Breadth.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-16/Test-Tree-Breadth.png)
