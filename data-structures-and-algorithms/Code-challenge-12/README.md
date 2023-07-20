# stack-queue-animal-shelter

## Approach & Efficiency
## ALGORTHM
1Enqueue:
Input: An instance of the Animal class representing the animal to be added to the shelter.
Output: None (void)
Algorithm:
Check the species of the animal.
If the species is "cat," enqueue the animal into the Cats queue.
If the species is "dog," enqueue the animal into the Dogs queue.
Dequeue:
Input: A string 'pref' representing the preferred species to dequeue ("cat" or "dog").
Output: The oldest animal of the specified species (Animal object).
Algorithm:
If 'pref' is "cat," dequeue the oldest animal from the Cats queue and return it.
If 'pref' is "dog," dequeue the oldest animal from the Dogs queue and return it.
If the preference is neither "cat" nor "dog," throw an ArgumentException.
countDog:
Input: A List<Animal> to store the count and names of dogs.
Output: None (void)
Algorithm:
Output the count of dogs in the Dogs queue.
Iterate through the Dogs queue and add each dog's name to the List<Animal> 'dogAnimal'.
countCat:
Input: A List<Animal> to store the count and names of cats.
Output: None (void)
Algorithm:
Output the count of cats in the Cats queue.
Iterate through the Cats queue and add each cat's name to the List<Animal> 'catAnimal'.
 elements.

![white](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-5/Linked-list.jpg)
![test](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-6/Linked-list-insertion.png)
