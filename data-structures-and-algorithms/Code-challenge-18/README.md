# Sorted-Array

## Approach & Efficiency
Algorithm
Insertion sort works by dividing the input array into a "sorted" section and an "unsorted" section. The algorithm iterates through the unsorted section, considering one element at a time. It compares the current element with the elements in the sorted section and inserts the current element into its correct position within the sorted section.

Efficiency
Time Complexity: In the worst-case scenario, insertion sort has a time complexity of O(n^2), where 'n' is the number of elements in the array. This happens when the array is in reverse order, and each element must be compared with all elements in the sorted section.
Space Complexity: Insertion sort has a space complexity of O(1), as it doesn't require additional memory proportional to the input size.e.

This method takes an array of integers as input and returns a new array with the integers sorted in ascending order using the insertion sort algorithm.