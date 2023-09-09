# Merge-Sorted-Array

## Approach & Efficiency
Approach:

Step 1: Initialize Movie List

Create a list called "movies" to store Movie objects.
Populate the list with Movie objects, each having Title, Year, and Genres.

Step 2: Sort Movies by Year

Create an empty list called "sorted by year."
Use a sorting algorithm (e.g., Bubble Sort) to iterate through the movies list:
Compare the release years of adjacent movies.
If the year of the current movie is greater than the next one, swap them.
Repeat this process until the list is sorted by year.
Store the sorted list in "sortedByYear."

Step 3: Sort Movies by Title

Create an empty list called "sorted by title."
Use a sorting algorithm to iterate through the movies list:
For each movie, remove common articles ("The," "A," "An") from the title.
Compare the modified titles of adjacent movies.
If the modified title of the current movie comes after the next one alphabetically, swap them.
Repeat this process until the list is sorted by title.
Store the sorted list in "sorted by title."

Step 4: Output Results
Print a table header with two columns: "Title" and "Year."
Print a separator line.
For each movie in "sorted by year," print its title and year in the table format.
Print a message indicating that the movies are sorted by title.
For each movie in "sorted by title," print its title.
![](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-20/Sort-Movie.jpg)
![](https://github.com/abdarahman-shaheen/data-structures-and-algorithms/blob/master/data-structures-and-algorithms/Code-challenge-20/Test-Sort-Movie.png)



