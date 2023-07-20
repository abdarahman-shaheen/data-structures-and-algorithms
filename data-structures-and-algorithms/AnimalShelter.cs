using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class AnimalShelter
    {
        private Queue<Animal> dogsAndCat;

        private Queue<Animal> Test;

        public AnimalShelter()
        {
            dogsAndCat = new Queue<Animal>();
            Test = new Queue<Animal>();
        }
        public void Enqueue(Animal animal)
        {
            if (animal.Species == "dog" || animal.Species == "cat")
            {
                dogsAndCat.Enqueue(animal);
            }
            else
            {
                throw new ArgumentException("Invalid animal species. Only 'dog' or 'cat' allowed.");
            }
        }
        public Animal Dequeue(string pref)
        {
            Queue<Animal> tempQueue = new Queue<Animal>();

            while (dogsAndCat.Count > 0)
            {
                Animal currentAnimal = dogsAndCat.Dequeue();

                if (currentAnimal.Species == pref)
                {
                    while (tempQueue.Count > 0)
                    {
                        dogsAndCat.Enqueue(tempQueue.Dequeue());
                    }
                    return currentAnimal;
                }
                tempQueue.Enqueue(currentAnimal);
            }
            if (pref != "dog" && pref != "cat")
            {
                throw new ArgumentException("Invalid preference. Only 'dog' or 'cat' allowed.");
            }
            return null;
        }
        public void PrintCount()
        {
            Console.WriteLine("the number of dogs and cats is :"+ dogsAndCat.Count);
        }
    }

    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
    }


}
