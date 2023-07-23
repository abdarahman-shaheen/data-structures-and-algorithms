# Stack-bracket

## Approach & Efficiency
1. Initialize an empty stack to store opening brackets encountered in the input string.
2. Iterate through each character in the input string.
3. If the character is an opening bracket ('(', '[', or '{'), push it onto the stack.
4. If the character is a closing bracket (')', ']', or '}'), check if the stack is empty.
   a. If the stack is empty, return false since there is no corresponding opening bracket for the current closing bracket.
   b. If the stack is not empty, pop the top element from the stack and compare it with the current closing bracket.
   c. If the popped element does not match the expected opening bracket for the current closing bracket, return false.
5. After processing all characters in the input string, check if the stack is empty.
   a. If the stack is empty, return true, indicating that all brackets are balanced.
   b. If the stack is not empty, return false, indicating that there are unmatched opening brackets in the input.

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)
