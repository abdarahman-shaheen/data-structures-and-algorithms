using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_and_algorithms
{
    public class AnimalShelter
    {
        private Queue<Animal> dogs;
        private Queue<Animal> cats;

        public AnimalShelter()
        {
            dogs = new Queue<Animal>();
            cats = new Queue<Animal>();
        }
        public void Enqueue(Animal animal)
        {
            if (animal.Species == "dog")
            {
                dogs.Enqueue(animal);
            }
            else if (animal.Species == "cat")
            {
                cats.Enqueue(animal);
            }
            else
            {
                throw new ArgumentException("Invalid animal species. Only 'dog' or 'cat' allowed.");
            }
        }
        public Animal Dequeue(string pref)
        {
            if (pref == "dog" && dogs.Count > 0)
            {
                return dogs.Dequeue();
            }
            else if (pref == "cat" && cats.Count > 0)
            {
                return cats.Dequeue();
            }
            else if (pref != "dog" && pref != "cat")
            {
                throw new ArgumentException("Invalid preference. Only 'dog' or 'cat' allowed.");
            }
            return null;
        }
        public void PrintCount()
        {
            Console.WriteLine("the number of dogs is :"+ dogs.Count);
            Console.WriteLine("the number of cat is :" + cats.Count);
        }
    }

    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
    }


}
