# Merge-Sorted-Array

## Approach & Efficiency
Approach:

Divide: The input array is divided into two halves until the base case is reached (i.e., when the array size is 1 or less).
This is done recursively, creating a binary tree structure where each node represents a subarray.

Conquer: Once the base case is reached (i.e., the subarrays have a size of 1 or less), the merging process begins. Subarrays are merged together in sorted order.

Merge: The Merge function takes two sorted arrays (left and right) and merges them into a single sorted array (arr) by comparing elements from both arrays. The merged result is then copied back to the arr array.
Efficiency

Time Complexity: The MergeSort algorithm consistently has a time complexity of O(n log n) in the average and worst cases.Space Complexity: Insertion sort has a space complexity of O(1), as it doesn't require additional memory proportional to the input size.e.

Space Complexity: The space complexity of the provided implementation is O(n) due to the additional space required for creating temporary arrays during the merging step. 