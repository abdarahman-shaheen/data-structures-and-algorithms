# Linked list

## Approach & Efficiency
**Algorithm**
1. create a variable and calculate the start index and last index in the array (Low-High).
2. if the low is less than the high you can find the key else the key is not found.
3. calculate the mid index for array med =(Low+high)/2.
4. if the element index med equals the key stop and we found the key.
5. else check key element is less on greater than the med element.
6. the key is less the med element changes the value of high=mid-1.
7. key is greater the med element change the value of low=mid+1.
8. repeat the operation to find key.
![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-Challenge-3/Binary-Search.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-Challenge-3/Test-BinarySearch.png)
